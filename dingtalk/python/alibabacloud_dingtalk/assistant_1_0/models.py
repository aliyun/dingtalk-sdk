# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
from typing import Dict, List, Any


class AddDomainWordsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class AddDomainWordsRequestDomainWords(TeaModel):
    def __init__(
        self,
        description: str = None,
        domain_word: str = None,
        formal_words: List[str] = None,
    ):
        self.description = description
        self.domain_word = domain_word
        self.formal_words = formal_words

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.domain_word is not None:
            result['domainWord'] = self.domain_word
        if self.formal_words is not None:
            result['formalWords'] = self.formal_words
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('domainWord') is not None:
            self.domain_word = m.get('domainWord')
        if m.get('formalWords') is not None:
            self.formal_words = m.get('formalWords')
        return self


class AddDomainWordsRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        domain_words: List[AddDomainWordsRequestDomainWords] = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.domain_words = domain_words

    def validate(self):
        if self.domain_words:
            for k in self.domain_words:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        result['domainWords'] = []
        if self.domain_words is not None:
            for k in self.domain_words:
                result['domainWords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        self.domain_words = []
        if m.get('domainWords') is not None:
            for k in m.get('domainWords'):
                temp_model = AddDomainWordsRequestDomainWords()
                self.domain_words.append(temp_model.from_map(k))
        return self


class AddDomainWordsResponseBody(TeaModel):
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


class AddDomainWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: AddDomainWordsResponseBody = None,
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
            temp_model = AddDomainWordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateAssistantRequest(TeaModel):
    def __init__(
        self,
        custom_agent_mobile_link: str = None,
        custom_agent_pclink: str = None,
        description: str = None,
        icon: str = None,
        instructions: str = None,
        name: str = None,
        operator_union_id: str = None,
        recommend_prompts: List[str] = None,
        welcome_content: str = None,
    ):
        self.custom_agent_mobile_link = custom_agent_mobile_link
        self.custom_agent_pclink = custom_agent_pclink
        # This parameter is required.
        self.description = description
        # This parameter is required.
        self.icon = icon
        # This parameter is required.
        self.instructions = instructions
        # This parameter is required.
        self.name = name
        # This parameter is required.
        self.operator_union_id = operator_union_id
        self.recommend_prompts = recommend_prompts
        # This parameter is required.
        self.welcome_content = welcome_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.custom_agent_mobile_link is not None:
            result['customAgentMobileLink'] = self.custom_agent_mobile_link
        if self.custom_agent_pclink is not None:
            result['customAgentPCLink'] = self.custom_agent_pclink
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.name is not None:
            result['name'] = self.name
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.recommend_prompts is not None:
            result['recommendPrompts'] = self.recommend_prompts
        if self.welcome_content is not None:
            result['welcomeContent'] = self.welcome_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('customAgentMobileLink') is not None:
            self.custom_agent_mobile_link = m.get('customAgentMobileLink')
        if m.get('customAgentPCLink') is not None:
            self.custom_agent_pclink = m.get('customAgentPCLink')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('recommendPrompts') is not None:
            self.recommend_prompts = m.get('recommendPrompts')
        if m.get('welcomeContent') is not None:
            self.welcome_content = m.get('welcomeContent')
        return self


class CreateAssistantResponseBody(TeaModel):
    def __init__(
        self,
        action_names: List[str] = None,
        assistant_id: str = None,
        assistant_union_id: str = None,
        created_at: int = None,
        creator_union_id: str = None,
        description: str = None,
        fallback_content: str = None,
        icon: str = None,
        instructions: str = None,
        knowledge_file_names: List[str] = None,
        model: str = None,
        name: str = None,
        recommend_prompts: List[str] = None,
        unified_app_id: str = None,
        welcome_content: str = None,
    ):
        self.action_names = action_names
        self.assistant_id = assistant_id
        self.assistant_union_id = assistant_union_id
        self.created_at = created_at
        self.creator_union_id = creator_union_id
        self.description = description
        self.fallback_content = fallback_content
        self.icon = icon
        self.instructions = instructions
        self.knowledge_file_names = knowledge_file_names
        self.model = model
        self.name = name
        self.recommend_prompts = recommend_prompts
        self.unified_app_id = unified_app_id
        self.welcome_content = welcome_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_names is not None:
            result['actionNames'] = self.action_names
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.assistant_union_id is not None:
            result['assistantUnionId'] = self.assistant_union_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.fallback_content is not None:
            result['fallbackContent'] = self.fallback_content
        if self.icon is not None:
            result['icon'] = self.icon
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.knowledge_file_names is not None:
            result['knowledgeFileNames'] = self.knowledge_file_names
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.recommend_prompts is not None:
            result['recommendPrompts'] = self.recommend_prompts
        if self.unified_app_id is not None:
            result['unifiedAppId'] = self.unified_app_id
        if self.welcome_content is not None:
            result['welcomeContent'] = self.welcome_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionNames') is not None:
            self.action_names = m.get('actionNames')
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('assistantUnionId') is not None:
            self.assistant_union_id = m.get('assistantUnionId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('fallbackContent') is not None:
            self.fallback_content = m.get('fallbackContent')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('knowledgeFileNames') is not None:
            self.knowledge_file_names = m.get('knowledgeFileNames')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('recommendPrompts') is not None:
            self.recommend_prompts = m.get('recommendPrompts')
        if m.get('unifiedAppId') is not None:
            self.unified_app_id = m.get('unifiedAppId')
        if m.get('welcomeContent') is not None:
            self.welcome_content = m.get('welcomeContent')
        return self


class CreateAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantResponseBody = None,
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
            temp_model = CreateAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateAssistantMessageRequest(TeaModel):
    def __init__(
        self,
        content: str = None,
        metadata: Dict[str, Any] = None,
        role: str = None,
    ):
        # This parameter is required.
        self.content = content
        self.metadata = metadata
        # This parameter is required.
        self.role = role

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.content is not None:
            result['content'] = self.content
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.role is not None:
            result['role'] = self.role
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('role') is not None:
            self.role = m.get('role')
        return self


class CreateAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        content: List[Any] = None,
        created_at: int = None,
        id: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.content = content
        self.created_at = created_at
        self.id = id
        self.metadata = metadata
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.content is not None:
            result['content'] = self.content
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class CreateAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantMessageResponseBody = None,
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
            temp_model = CreateAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantRunHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateAssistantRunRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        instructions: str = None,
        metadata: Dict[str, Any] = None,
        stream: bool = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        self.instructions = instructions
        self.metadata = metadata
        self.stream = stream

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.stream is not None:
            result['stream'] = self.stream
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('stream') is not None:
            self.stream = m.get('stream')
        return self


class CreateAssistantRunResponseBody(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        cancelled_at: int = None,
        completed_at: int = None,
        created_at: int = None,
        expires_at: int = None,
        failed_at: int = None,
        id: str = None,
        last_error_msg: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        started_at: int = None,
        status: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.cancelled_at = cancelled_at
        self.completed_at = completed_at
        self.created_at = created_at
        self.expires_at = expires_at
        self.failed_at = failed_at
        self.id = id
        self.last_error_msg = last_error_msg
        self.metadata = metadata
        self.object = object
        self.started_at = started_at
        self.status = status
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.cancelled_at is not None:
            result['cancelledAt'] = self.cancelled_at
        if self.completed_at is not None:
            result['completedAt'] = self.completed_at
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.expires_at is not None:
            result['expiresAt'] = self.expires_at
        if self.failed_at is not None:
            result['failedAt'] = self.failed_at
        if self.id is not None:
            result['id'] = self.id
        if self.last_error_msg is not None:
            result['lastErrorMsg'] = self.last_error_msg
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.started_at is not None:
            result['startedAt'] = self.started_at
        if self.status is not None:
            result['status'] = self.status
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('cancelledAt') is not None:
            self.cancelled_at = m.get('cancelledAt')
        if m.get('completedAt') is not None:
            self.completed_at = m.get('completedAt')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('expiresAt') is not None:
            self.expires_at = m.get('expiresAt')
        if m.get('failedAt') is not None:
            self.failed_at = m.get('failedAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastErrorMsg') is not None:
            self.last_error_msg = m.get('lastErrorMsg')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('startedAt') is not None:
            self.started_at = m.get('startedAt')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class CreateAssistantRunResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantRunResponseBody = None,
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
            temp_model = CreateAssistantRunResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class CreateAssistantThreadHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class CreateAssistantThreadRequest(TeaModel):
    def __init__(
        self,
        metadata: Dict[str, str] = None,
    ):
        self.metadata = metadata

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.metadata is not None:
            result['metadata'] = self.metadata
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        return self


class CreateAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        created_at: int = None,
        id: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
    ):
        self.created_at = created_at
        self.id = id
        self.metadata = metadata
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class CreateAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: CreateAssistantThreadResponseBody = None,
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
            temp_model = CreateAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteAssistantRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        operator_union_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.operator_union_id = operator_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        return self


class DeleteAssistantResponseBody(TeaModel):
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


class DeleteAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAssistantResponseBody = None,
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
            temp_model = DeleteAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAssistantMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        id: str = None,
        object: str = None,
    ):
        self.deleted = deleted
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class DeleteAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAssistantMessageResponseBody = None,
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
            temp_model = DeleteAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteAssistantThreadHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        deleted: bool = None,
        id: str = None,
        object: str = None,
    ):
        self.deleted = deleted
        self.id = id
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.deleted is not None:
            result['deleted'] = self.deleted
        if self.id is not None:
            result['id'] = self.id
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deleted') is not None:
            self.deleted = m.get('deleted')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class DeleteAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteAssistantThreadResponseBody = None,
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
            temp_model = DeleteAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class DeleteDomainWordsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class DeleteDomainWordsRequestDomainWords(TeaModel):
    def __init__(
        self,
        description: str = None,
        domain_word: str = None,
        formal_words: List[str] = None,
    ):
        self.description = description
        self.domain_word = domain_word
        self.formal_words = formal_words

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.description is not None:
            result['description'] = self.description
        if self.domain_word is not None:
            result['domainWord'] = self.domain_word
        if self.formal_words is not None:
            result['formalWords'] = self.formal_words
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('domainWord') is not None:
            self.domain_word = m.get('domainWord')
        if m.get('formalWords') is not None:
            self.formal_words = m.get('formalWords')
        return self


class DeleteDomainWordsRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        domain_words: List[DeleteDomainWordsRequestDomainWords] = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.domain_words = domain_words

    def validate(self):
        if self.domain_words:
            for k in self.domain_words:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        result['domainWords'] = []
        if self.domain_words is not None:
            for k in self.domain_words:
                result['domainWords'].append(k.to_map() if k else None)
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        self.domain_words = []
        if m.get('domainWords') is not None:
            for k in m.get('domainWords'):
                temp_model = DeleteDomainWordsRequestDomainWords()
                self.domain_words.append(temp_model.from_map(k))
        return self


class DeleteDomainWordsResponseBody(TeaModel):
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


class DeleteDomainWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: DeleteDomainWordsResponseBody = None,
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
            temp_model = DeleteDomainWordsResponseBody()
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
        assistant_id: str = None,
        study_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.study_id = study_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.study_id is not None:
            result['studyId'] = self.study_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('studyId') is not None:
            self.study_id = m.get('studyId')
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


class GetAskDetailHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetAskDetailRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        end_time: int = None,
        offset: int = None,
        page_size: int = None,
        start_time: int = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        self.end_time = end_time
        # This parameter is required.
        self.offset = offset
        # This parameter is required.
        self.page_size = page_size
        self.start_time = start_time

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.end_time is not None:
            result['endTime'] = self.end_time
        if self.offset is not None:
            result['offset'] = self.offset
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.start_time is not None:
            result['startTime'] = self.start_time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('endTime') is not None:
            self.end_time = m.get('endTime')
        if m.get('offset') is not None:
            self.offset = m.get('offset')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('startTime') is not None:
            self.start_time = m.get('startTime')
        return self


class GetAskDetailResponseBodyResultListReferences(TeaModel):
    def __init__(
        self,
        name: str = None,
        url: str = None,
    ):
        self.name = name
        self.url = url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.name is not None:
            result['name'] = self.name
        if self.url is not None:
            result['url'] = self.url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('url') is not None:
            self.url = m.get('url')
        return self


class GetAskDetailResponseBodyResultList(TeaModel):
    def __init__(
        self,
        answer: str = None,
        answer_result: str = None,
        comment_tags: List[str] = None,
        is_mark_resolved: bool = None,
        nick: str = None,
        question: str = None,
        references: List[GetAskDetailResponseBodyResultListReferences] = None,
        time: int = None,
    ):
        self.answer = answer
        self.answer_result = answer_result
        self.comment_tags = comment_tags
        self.is_mark_resolved = is_mark_resolved
        self.nick = nick
        self.question = question
        self.references = references
        self.time = time

    def validate(self):
        if self.references:
            for k in self.references:
                if k:
                    k.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.answer is not None:
            result['answer'] = self.answer
        if self.answer_result is not None:
            result['answerResult'] = self.answer_result
        if self.comment_tags is not None:
            result['commentTags'] = self.comment_tags
        if self.is_mark_resolved is not None:
            result['isMarkResolved'] = self.is_mark_resolved
        if self.nick is not None:
            result['nick'] = self.nick
        if self.question is not None:
            result['question'] = self.question
        result['references'] = []
        if self.references is not None:
            for k in self.references:
                result['references'].append(k.to_map() if k else None)
        if self.time is not None:
            result['time'] = self.time
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('answer') is not None:
            self.answer = m.get('answer')
        if m.get('answerResult') is not None:
            self.answer_result = m.get('answerResult')
        if m.get('commentTags') is not None:
            self.comment_tags = m.get('commentTags')
        if m.get('isMarkResolved') is not None:
            self.is_mark_resolved = m.get('isMarkResolved')
        if m.get('nick') is not None:
            self.nick = m.get('nick')
        if m.get('question') is not None:
            self.question = m.get('question')
        self.references = []
        if m.get('references') is not None:
            for k in m.get('references'):
                temp_model = GetAskDetailResponseBodyResultListReferences()
                self.references.append(temp_model.from_map(k))
        if m.get('time') is not None:
            self.time = m.get('time')
        return self


class GetAskDetailResponseBodyResult(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[GetAskDetailResponseBodyResultList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = GetAskDetailResponseBodyResultList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class GetAskDetailResponseBody(TeaModel):
    def __init__(
        self,
        result: GetAskDetailResponseBodyResult = None,
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
            temp_model = GetAskDetailResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetAskDetailResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetAskDetailResponseBody = None,
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
            temp_model = GetAskDetailResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetDomainWordsHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetDomainWordsRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        return self


class GetDomainWordsResponseBody(TeaModel):
    def __init__(
        self,
        result: List[str] = None,
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


class GetDomainWordsResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetDomainWordsResponseBody = None,
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
            temp_model = GetDomainWordsResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class GetKnowledgeListHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class GetKnowledgeListRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
    ):
        self.assistant_id = assistant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        return self


class GetKnowledgeListResponseBodyResult(TeaModel):
    def __init__(
        self,
        doc_format: str = None,
        doc_name: str = None,
        doc_url: str = None,
        status: str = None,
        study_id: str = None,
    ):
        self.doc_format = doc_format
        self.doc_name = doc_name
        self.doc_url = doc_url
        self.status = status
        self.study_id = study_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.doc_format is not None:
            result['docFormat'] = self.doc_format
        if self.doc_name is not None:
            result['docName'] = self.doc_name
        if self.doc_url is not None:
            result['docUrl'] = self.doc_url
        if self.status is not None:
            result['status'] = self.status
        if self.study_id is not None:
            result['studyId'] = self.study_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('docFormat') is not None:
            self.doc_format = m.get('docFormat')
        if m.get('docName') is not None:
            self.doc_name = m.get('docName')
        if m.get('docUrl') is not None:
            self.doc_url = m.get('docUrl')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('studyId') is not None:
            self.study_id = m.get('studyId')
        return self


class GetKnowledgeListResponseBody(TeaModel):
    def __init__(
        self,
        result: List[GetKnowledgeListResponseBodyResult] = None,
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
                temp_model = GetKnowledgeListResponseBodyResult()
                self.result.append(temp_model.from_map(k))
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class GetKnowledgeListResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: GetKnowledgeListResponseBody = None,
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
            temp_model = GetKnowledgeListResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class InstallAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class InstallAssistantRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        is_all_org_member_visible: bool = None,
    ):
        self.assistant_id = assistant_id
        self.is_all_org_member_visible = is_all_org_member_visible

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.is_all_org_member_visible is not None:
            result['isAllOrgMemberVisible'] = self.is_all_org_member_visible
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('isAllOrgMemberVisible') is not None:
            self.is_all_org_member_visible = m.get('isAllOrgMemberVisible')
        return self


class InstallAssistantResponseBody(TeaModel):
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


class InstallAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: InstallAssistantResponseBody = None,
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
            temp_model = InstallAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class LearnKnowledgeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class LearnKnowledgeRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        doc_url: str = None,
    ):
        self.assistant_id = assistant_id
        self.doc_url = doc_url

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.doc_url is not None:
            result['docUrl'] = self.doc_url
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('docUrl') is not None:
            self.doc_url = m.get('docUrl')
        return self


class LearnKnowledgeResponseBody(TeaModel):
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


class LearnKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: LearnKnowledgeResponseBody = None,
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
            temp_model = LearnKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListAssistantRequest(TeaModel):
    def __init__(
        self,
        cursor: int = None,
        page_size: int = None,
        union_id: str = None,
    ):
        self.cursor = cursor
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListAssistantResponseBodyList(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        created_at: int = None,
        creator_union_id: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
    ):
        self.assistant_id = assistant_id
        self.created_at = created_at
        self.creator_union_id = creator_union_id
        self.description = description
        self.icon = icon
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListAssistantResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListAssistantResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListAssistantResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAssistantResponseBody = None,
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
            temp_model = ListAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAssistantMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListAssistantMessageRequest(TeaModel):
    def __init__(
        self,
        limit: int = None,
        order: str = None,
        run_id: str = None,
    ):
        self.limit = limit
        self.order = order
        self.run_id = run_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.limit is not None:
            result['limit'] = self.limit
        if self.order is not None:
            result['order'] = self.order
        if self.run_id is not None:
            result['runId'] = self.run_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('order') is not None:
            self.order = m.get('order')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        return self


class ListAssistantMessageResponseBodyData(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        content: List[Any] = None,
        created_at: int = None,
        id: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.content = content
        self.created_at = created_at
        self.id = id
        self.metadata = metadata
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.content is not None:
            result['content'] = self.content
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class ListAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListAssistantMessageResponseBodyData] = None,
        object: str = None,
    ):
        self.data = data
        self.object = object

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
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListAssistantMessageResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class ListAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAssistantMessageResponseBody = None,
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
            temp_model = ListAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListAssistantRunHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListAssistantRunRequest(TeaModel):
    def __init__(
        self,
        limit: int = None,
        order: str = None,
    ):
        self.limit = limit
        self.order = order

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.limit is not None:
            result['limit'] = self.limit
        if self.order is not None:
            result['order'] = self.order
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('limit') is not None:
            self.limit = m.get('limit')
        if m.get('order') is not None:
            self.order = m.get('order')
        return self


class ListAssistantRunResponseBodyData(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        cancelled_at: int = None,
        completed_at: int = None,
        created_at: int = None,
        expires_at: int = None,
        failed_at: int = None,
        id: str = None,
        last_error_msg: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        started_at: int = None,
        status: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.cancelled_at = cancelled_at
        self.completed_at = completed_at
        self.created_at = created_at
        self.expires_at = expires_at
        self.failed_at = failed_at
        self.id = id
        self.last_error_msg = last_error_msg
        self.metadata = metadata
        self.object = object
        self.started_at = started_at
        self.status = status
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.cancelled_at is not None:
            result['cancelledAt'] = self.cancelled_at
        if self.completed_at is not None:
            result['completedAt'] = self.completed_at
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.expires_at is not None:
            result['expiresAt'] = self.expires_at
        if self.failed_at is not None:
            result['failedAt'] = self.failed_at
        if self.id is not None:
            result['id'] = self.id
        if self.last_error_msg is not None:
            result['lastErrorMsg'] = self.last_error_msg
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.started_at is not None:
            result['startedAt'] = self.started_at
        if self.status is not None:
            result['status'] = self.status
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('cancelledAt') is not None:
            self.cancelled_at = m.get('cancelledAt')
        if m.get('completedAt') is not None:
            self.completed_at = m.get('completedAt')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('expiresAt') is not None:
            self.expires_at = m.get('expiresAt')
        if m.get('failedAt') is not None:
            self.failed_at = m.get('failedAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastErrorMsg') is not None:
            self.last_error_msg = m.get('lastErrorMsg')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('startedAt') is not None:
            self.started_at = m.get('startedAt')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class ListAssistantRunResponseBody(TeaModel):
    def __init__(
        self,
        data: List[ListAssistantRunResponseBodyData] = None,
        object: str = None,
    ):
        self.data = data
        self.object = object

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
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        self.data = []
        if m.get('data') is not None:
            for k in m.get('data'):
                temp_model = ListAssistantRunResponseBodyData()
                self.data.append(temp_model.from_map(k))
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class ListAssistantRunResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListAssistantRunResponseBody = None,
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
            temp_model = ListAssistantRunResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class ListVisibleAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class ListVisibleAssistantRequest(TeaModel):
    def __init__(
        self,
        cursor: int = None,
        name: str = None,
        page_size: int = None,
        union_id: str = None,
    ):
        self.cursor = cursor
        self.name = name
        # This parameter is required.
        self.page_size = page_size
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.cursor is not None:
            result['cursor'] = self.cursor
        if self.name is not None:
            result['name'] = self.name
        if self.page_size is not None:
            result['pageSize'] = self.page_size
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('cursor') is not None:
            self.cursor = m.get('cursor')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('pageSize') is not None:
            self.page_size = m.get('pageSize')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class ListVisibleAssistantResponseBodyList(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        created_at: int = None,
        creator_union_id: str = None,
        description: str = None,
        icon: str = None,
        name: str = None,
    ):
        self.assistant_id = assistant_id
        self.created_at = created_at
        self.creator_union_id = creator_union_id
        self.description = description
        self.icon = icon
        self.name = name

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.icon is not None:
            result['icon'] = self.icon
        if self.name is not None:
            result['name'] = self.name
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('name') is not None:
            self.name = m.get('name')
        return self


class ListVisibleAssistantResponseBody(TeaModel):
    def __init__(
        self,
        has_more: bool = None,
        list: List[ListVisibleAssistantResponseBodyList] = None,
        next_cursor: int = None,
        total_count: int = None,
    ):
        self.has_more = has_more
        self.list = list
        self.next_cursor = next_cursor
        self.total_count = total_count

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
        if self.next_cursor is not None:
            result['nextCursor'] = self.next_cursor
        if self.total_count is not None:
            result['totalCount'] = self.total_count
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('hasMore') is not None:
            self.has_more = m.get('hasMore')
        self.list = []
        if m.get('list') is not None:
            for k in m.get('list'):
                temp_model = ListVisibleAssistantResponseBodyList()
                self.list.append(temp_model.from_map(k))
        if m.get('nextCursor') is not None:
            self.next_cursor = m.get('nextCursor')
        if m.get('totalCount') is not None:
            self.total_count = m.get('totalCount')
        return self


class ListVisibleAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: ListVisibleAssistantResponseBody = None,
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
            temp_model = ListVisibleAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RelearnKnowledgeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RelearnKnowledgeRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        return self


class RelearnKnowledgeResponseBody(TeaModel):
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


class RelearnKnowledgeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RelearnKnowledgeResponseBody = None,
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
            temp_model = RelearnKnowledgeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RemoveAssistantHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RemoveAssistantRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        operator_union_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.operator_union_id = operator_union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        return self


class RemoveAssistantResponseBody(TeaModel):
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


class RemoveAssistantResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RemoveAssistantResponseBody = None,
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
            temp_model = RemoveAssistantResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantBasicInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetrieveAssistantBasicInfoRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        union_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.union_id = union_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.union_id is not None:
            result['unionId'] = self.union_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('unionId') is not None:
            self.union_id = m.get('unionId')
        return self


class RetrieveAssistantBasicInfoResponseBody(TeaModel):
    def __init__(
        self,
        action_names: List[str] = None,
        assistant_id: str = None,
        assistant_union_id: str = None,
        created_at: int = None,
        creator_union_id: str = None,
        description: str = None,
        fallback_content: str = None,
        icon: str = None,
        instructions: str = None,
        knowledge_file_names: List[str] = None,
        model: str = None,
        name: str = None,
        recommend_prompts: List[str] = None,
        unified_app_id: str = None,
        welcome_content: str = None,
    ):
        self.action_names = action_names
        self.assistant_id = assistant_id
        self.assistant_union_id = assistant_union_id
        self.created_at = created_at
        self.creator_union_id = creator_union_id
        self.description = description
        self.fallback_content = fallback_content
        self.icon = icon
        self.instructions = instructions
        self.knowledge_file_names = knowledge_file_names
        self.model = model
        self.name = name
        self.recommend_prompts = recommend_prompts
        self.unified_app_id = unified_app_id
        self.welcome_content = welcome_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_names is not None:
            result['actionNames'] = self.action_names
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.assistant_union_id is not None:
            result['assistantUnionId'] = self.assistant_union_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.fallback_content is not None:
            result['fallbackContent'] = self.fallback_content
        if self.icon is not None:
            result['icon'] = self.icon
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.knowledge_file_names is not None:
            result['knowledgeFileNames'] = self.knowledge_file_names
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.recommend_prompts is not None:
            result['recommendPrompts'] = self.recommend_prompts
        if self.unified_app_id is not None:
            result['unifiedAppId'] = self.unified_app_id
        if self.welcome_content is not None:
            result['welcomeContent'] = self.welcome_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionNames') is not None:
            self.action_names = m.get('actionNames')
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('assistantUnionId') is not None:
            self.assistant_union_id = m.get('assistantUnionId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('fallbackContent') is not None:
            self.fallback_content = m.get('fallbackContent')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('knowledgeFileNames') is not None:
            self.knowledge_file_names = m.get('knowledgeFileNames')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('recommendPrompts') is not None:
            self.recommend_prompts = m.get('recommendPrompts')
        if m.get('unifiedAppId') is not None:
            self.unified_app_id = m.get('unifiedAppId')
        if m.get('welcomeContent') is not None:
            self.welcome_content = m.get('welcomeContent')
        return self


class RetrieveAssistantBasicInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantBasicInfoResponseBody = None,
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
            temp_model = RetrieveAssistantBasicInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantMessageHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetrieveAssistantMessageResponseBody(TeaModel):
    def __init__(
        self,
        assisant_id: str = None,
        content: List[Any] = None,
        created_at: int = None,
        id: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        role: str = None,
        run_id: str = None,
        thread_id: str = None,
    ):
        self.assisant_id = assisant_id
        self.content = content
        self.created_at = created_at
        self.id = id
        self.metadata = metadata
        self.object = object
        self.role = role
        self.run_id = run_id
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assisant_id is not None:
            result['assisantId'] = self.assisant_id
        if self.content is not None:
            result['content'] = self.content
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.role is not None:
            result['role'] = self.role
        if self.run_id is not None:
            result['runId'] = self.run_id
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assisantId') is not None:
            self.assisant_id = m.get('assisantId')
        if m.get('content') is not None:
            self.content = m.get('content')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('role') is not None:
            self.role = m.get('role')
        if m.get('runId') is not None:
            self.run_id = m.get('runId')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class RetrieveAssistantMessageResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantMessageResponseBody = None,
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
            temp_model = RetrieveAssistantMessageResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantRunHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetrieveAssistantRunResponseBody(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        cancelled_at: int = None,
        completed_at: int = None,
        created_at: int = None,
        expires_at: int = None,
        failed_at: int = None,
        id: str = None,
        last_error_msg: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
        started_at: int = None,
        status: str = None,
        thread_id: str = None,
    ):
        self.assistant_id = assistant_id
        self.cancelled_at = cancelled_at
        self.completed_at = completed_at
        self.created_at = created_at
        self.expires_at = expires_at
        self.failed_at = failed_at
        self.id = id
        self.last_error_msg = last_error_msg
        self.metadata = metadata
        self.object = object
        self.started_at = started_at
        self.status = status
        self.thread_id = thread_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.cancelled_at is not None:
            result['cancelledAt'] = self.cancelled_at
        if self.completed_at is not None:
            result['completedAt'] = self.completed_at
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.expires_at is not None:
            result['expiresAt'] = self.expires_at
        if self.failed_at is not None:
            result['failedAt'] = self.failed_at
        if self.id is not None:
            result['id'] = self.id
        if self.last_error_msg is not None:
            result['lastErrorMsg'] = self.last_error_msg
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        if self.started_at is not None:
            result['startedAt'] = self.started_at
        if self.status is not None:
            result['status'] = self.status
        if self.thread_id is not None:
            result['threadId'] = self.thread_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('cancelledAt') is not None:
            self.cancelled_at = m.get('cancelledAt')
        if m.get('completedAt') is not None:
            self.completed_at = m.get('completedAt')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('expiresAt') is not None:
            self.expires_at = m.get('expiresAt')
        if m.get('failedAt') is not None:
            self.failed_at = m.get('failedAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('lastErrorMsg') is not None:
            self.last_error_msg = m.get('lastErrorMsg')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        if m.get('startedAt') is not None:
            self.started_at = m.get('startedAt')
        if m.get('status') is not None:
            self.status = m.get('status')
        if m.get('threadId') is not None:
            self.thread_id = m.get('threadId')
        return self


class RetrieveAssistantRunResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantRunResponseBody = None,
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
            temp_model = RetrieveAssistantRunResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantScopeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetrieveAssistantScopeRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        return self


class RetrieveAssistantScopeResponseBodyResultScopes(TeaModel):
    def __init__(
        self,
        dept_visible_scopes: List[str] = None,
        dynamic_group_scopes: List[str] = None,
        is_admin: bool = None,
        role_visible_scopes: List[str] = None,
        user_visible_scopes: List[str] = None,
    ):
        self.dept_visible_scopes = dept_visible_scopes
        self.dynamic_group_scopes = dynamic_group_scopes
        self.is_admin = is_admin
        self.role_visible_scopes = role_visible_scopes
        self.user_visible_scopes = user_visible_scopes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_visible_scopes is not None:
            result['deptVisibleScopes'] = self.dept_visible_scopes
        if self.dynamic_group_scopes is not None:
            result['dynamicGroupScopes'] = self.dynamic_group_scopes
        if self.is_admin is not None:
            result['isAdmin'] = self.is_admin
        if self.role_visible_scopes is not None:
            result['roleVisibleScopes'] = self.role_visible_scopes
        if self.user_visible_scopes is not None:
            result['userVisibleScopes'] = self.user_visible_scopes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptVisibleScopes') is not None:
            self.dept_visible_scopes = m.get('deptVisibleScopes')
        if m.get('dynamicGroupScopes') is not None:
            self.dynamic_group_scopes = m.get('dynamicGroupScopes')
        if m.get('isAdmin') is not None:
            self.is_admin = m.get('isAdmin')
        if m.get('roleVisibleScopes') is not None:
            self.role_visible_scopes = m.get('roleVisibleScopes')
        if m.get('userVisibleScopes') is not None:
            self.user_visible_scopes = m.get('userVisibleScopes')
        return self


class RetrieveAssistantScopeResponseBodyResult(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        scopes: RetrieveAssistantScopeResponseBodyResultScopes = None,
        sharing: bool = None,
    ):
        self.assistant_id = assistant_id
        self.scopes = scopes
        self.sharing = sharing

    def validate(self):
        if self.scopes:
            self.scopes.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.scopes is not None:
            result['scopes'] = self.scopes.to_map()
        if self.sharing is not None:
            result['sharing'] = self.sharing
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('scopes') is not None:
            temp_model = RetrieveAssistantScopeResponseBodyResultScopes()
            self.scopes = temp_model.from_map(m['scopes'])
        if m.get('sharing') is not None:
            self.sharing = m.get('sharing')
        return self


class RetrieveAssistantScopeResponseBody(TeaModel):
    def __init__(
        self,
        result: RetrieveAssistantScopeResponseBodyResult = None,
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
            temp_model = RetrieveAssistantScopeResponseBodyResult()
            self.result = temp_model.from_map(m['result'])
        if m.get('success') is not None:
            self.success = m.get('success')
        return self


class RetrieveAssistantScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantScopeResponseBody = None,
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
            temp_model = RetrieveAssistantScopeResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class RetrieveAssistantThreadHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class RetrieveAssistantThreadResponseBody(TeaModel):
    def __init__(
        self,
        created_at: int = None,
        id: str = None,
        metadata: Dict[str, Any] = None,
        object: str = None,
    ):
        self.created_at = created_at
        self.id = id
        self.metadata = metadata
        self.object = object

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.id is not None:
            result['id'] = self.id
        if self.metadata is not None:
            result['metadata'] = self.metadata
        if self.object is not None:
            result['object'] = self.object
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('id') is not None:
            self.id = m.get('id')
        if m.get('metadata') is not None:
            self.metadata = m.get('metadata')
        if m.get('object') is not None:
            self.object = m.get('object')
        return self


class RetrieveAssistantThreadResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: RetrieveAssistantThreadResponseBody = None,
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
            temp_model = RetrieveAssistantThreadResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateAssistantBasicInfoHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateAssistantBasicInfoRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        description: str = None,
        fallback_content: str = None,
        icon: str = None,
        instructions: str = None,
        name: str = None,
        operator_union_id: str = None,
        recommend_prompts: List[str] = None,
        welcome_content: str = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        self.description = description
        self.fallback_content = fallback_content
        self.icon = icon
        self.instructions = instructions
        self.name = name
        # This parameter is required.
        self.operator_union_id = operator_union_id
        self.recommend_prompts = recommend_prompts
        self.welcome_content = welcome_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.description is not None:
            result['description'] = self.description
        if self.fallback_content is not None:
            result['fallbackContent'] = self.fallback_content
        if self.icon is not None:
            result['icon'] = self.icon
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.name is not None:
            result['name'] = self.name
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.recommend_prompts is not None:
            result['recommendPrompts'] = self.recommend_prompts
        if self.welcome_content is not None:
            result['welcomeContent'] = self.welcome_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('fallbackContent') is not None:
            self.fallback_content = m.get('fallbackContent')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('recommendPrompts') is not None:
            self.recommend_prompts = m.get('recommendPrompts')
        if m.get('welcomeContent') is not None:
            self.welcome_content = m.get('welcomeContent')
        return self


class UpdateAssistantBasicInfoResponseBody(TeaModel):
    def __init__(
        self,
        action_names: List[str] = None,
        assistant_id: str = None,
        assistant_union_id: str = None,
        created_at: int = None,
        creator_union_id: str = None,
        description: str = None,
        fallback_content: str = None,
        icon: str = None,
        instructions: str = None,
        knowledge_file_names: List[str] = None,
        model: str = None,
        name: str = None,
        recommend_prompts: List[str] = None,
        unified_app_id: str = None,
        welcome_content: str = None,
    ):
        self.action_names = action_names
        self.assistant_id = assistant_id
        self.assistant_union_id = assistant_union_id
        self.created_at = created_at
        self.creator_union_id = creator_union_id
        self.description = description
        self.fallback_content = fallback_content
        self.icon = icon
        self.instructions = instructions
        self.knowledge_file_names = knowledge_file_names
        self.model = model
        self.name = name
        self.recommend_prompts = recommend_prompts
        self.unified_app_id = unified_app_id
        self.welcome_content = welcome_content

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.action_names is not None:
            result['actionNames'] = self.action_names
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.assistant_union_id is not None:
            result['assistantUnionId'] = self.assistant_union_id
        if self.created_at is not None:
            result['createdAt'] = self.created_at
        if self.creator_union_id is not None:
            result['creatorUnionId'] = self.creator_union_id
        if self.description is not None:
            result['description'] = self.description
        if self.fallback_content is not None:
            result['fallbackContent'] = self.fallback_content
        if self.icon is not None:
            result['icon'] = self.icon
        if self.instructions is not None:
            result['instructions'] = self.instructions
        if self.knowledge_file_names is not None:
            result['knowledgeFileNames'] = self.knowledge_file_names
        if self.model is not None:
            result['model'] = self.model
        if self.name is not None:
            result['name'] = self.name
        if self.recommend_prompts is not None:
            result['recommendPrompts'] = self.recommend_prompts
        if self.unified_app_id is not None:
            result['unifiedAppId'] = self.unified_app_id
        if self.welcome_content is not None:
            result['welcomeContent'] = self.welcome_content
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('actionNames') is not None:
            self.action_names = m.get('actionNames')
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('assistantUnionId') is not None:
            self.assistant_union_id = m.get('assistantUnionId')
        if m.get('createdAt') is not None:
            self.created_at = m.get('createdAt')
        if m.get('creatorUnionId') is not None:
            self.creator_union_id = m.get('creatorUnionId')
        if m.get('description') is not None:
            self.description = m.get('description')
        if m.get('fallbackContent') is not None:
            self.fallback_content = m.get('fallbackContent')
        if m.get('icon') is not None:
            self.icon = m.get('icon')
        if m.get('instructions') is not None:
            self.instructions = m.get('instructions')
        if m.get('knowledgeFileNames') is not None:
            self.knowledge_file_names = m.get('knowledgeFileNames')
        if m.get('model') is not None:
            self.model = m.get('model')
        if m.get('name') is not None:
            self.name = m.get('name')
        if m.get('recommendPrompts') is not None:
            self.recommend_prompts = m.get('recommendPrompts')
        if m.get('unifiedAppId') is not None:
            self.unified_app_id = m.get('unifiedAppId')
        if m.get('welcomeContent') is not None:
            self.welcome_content = m.get('welcomeContent')
        return self


class UpdateAssistantBasicInfoResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: UpdateAssistantBasicInfoResponseBody = None,
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
            temp_model = UpdateAssistantBasicInfoResponseBody()
            self.body = temp_model.from_map(m['body'])
        return self


class UpdateAssistantScopeHeaders(TeaModel):
    def __init__(
        self,
        common_headers: Dict[str, str] = None,
        x_acs_dingtalk_access_token: str = None,
    ):
        self.common_headers = common_headers
        self.x_acs_dingtalk_access_token = x_acs_dingtalk_access_token

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.common_headers is not None:
            result['commonHeaders'] = self.common_headers
        if self.x_acs_dingtalk_access_token is not None:
            result['x-acs-dingtalk-access-token'] = self.x_acs_dingtalk_access_token
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('commonHeaders') is not None:
            self.common_headers = m.get('commonHeaders')
        if m.get('x-acs-dingtalk-access-token') is not None:
            self.x_acs_dingtalk_access_token = m.get('x-acs-dingtalk-access-token')
        return self


class UpdateAssistantScopeRequestScopes(TeaModel):
    def __init__(
        self,
        dept_visible_scopes: List[str] = None,
        dynamic_group_scopes: List[str] = None,
        is_admin: bool = None,
        role_visible_scopes: List[str] = None,
        user_visible_scopes: List[str] = None,
    ):
        self.dept_visible_scopes = dept_visible_scopes
        self.dynamic_group_scopes = dynamic_group_scopes
        self.is_admin = is_admin
        self.role_visible_scopes = role_visible_scopes
        self.user_visible_scopes = user_visible_scopes

    def validate(self):
        pass

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.dept_visible_scopes is not None:
            result['deptVisibleScopes'] = self.dept_visible_scopes
        if self.dynamic_group_scopes is not None:
            result['dynamicGroupScopes'] = self.dynamic_group_scopes
        if self.is_admin is not None:
            result['isAdmin'] = self.is_admin
        if self.role_visible_scopes is not None:
            result['roleVisibleScopes'] = self.role_visible_scopes
        if self.user_visible_scopes is not None:
            result['userVisibleScopes'] = self.user_visible_scopes
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('deptVisibleScopes') is not None:
            self.dept_visible_scopes = m.get('deptVisibleScopes')
        if m.get('dynamicGroupScopes') is not None:
            self.dynamic_group_scopes = m.get('dynamicGroupScopes')
        if m.get('isAdmin') is not None:
            self.is_admin = m.get('isAdmin')
        if m.get('roleVisibleScopes') is not None:
            self.role_visible_scopes = m.get('roleVisibleScopes')
        if m.get('userVisibleScopes') is not None:
            self.user_visible_scopes = m.get('userVisibleScopes')
        return self


class UpdateAssistantScopeRequest(TeaModel):
    def __init__(
        self,
        assistant_id: str = None,
        operator_union_id: str = None,
        scopes: UpdateAssistantScopeRequestScopes = None,
        sharing: bool = None,
    ):
        # This parameter is required.
        self.assistant_id = assistant_id
        # This parameter is required.
        self.operator_union_id = operator_union_id
        self.scopes = scopes
        self.sharing = sharing

    def validate(self):
        if self.scopes:
            self.scopes.validate()

    def to_map(self):
        _map = super().to_map()
        if _map is not None:
            return _map

        result = dict()
        if self.assistant_id is not None:
            result['assistantId'] = self.assistant_id
        if self.operator_union_id is not None:
            result['operatorUnionId'] = self.operator_union_id
        if self.scopes is not None:
            result['scopes'] = self.scopes.to_map()
        if self.sharing is not None:
            result['sharing'] = self.sharing
        return result

    def from_map(self, m: dict = None):
        m = m or dict()
        if m.get('assistantId') is not None:
            self.assistant_id = m.get('assistantId')
        if m.get('operatorUnionId') is not None:
            self.operator_union_id = m.get('operatorUnionId')
        if m.get('scopes') is not None:
            temp_model = UpdateAssistantScopeRequestScopes()
            self.scopes = temp_model.from_map(m['scopes'])
        if m.get('sharing') is not None:
            self.sharing = m.get('sharing')
        return self


class UpdateAssistantScopeResponse(TeaModel):
    def __init__(
        self,
        headers: Dict[str, str] = None,
        status_code: int = None,
        body: Any = None,
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


