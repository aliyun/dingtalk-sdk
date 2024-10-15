# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.service_group_1_0 import models as dingtalkservice_group__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_contact_member_to_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddContactMemberToGroupRequest,
        headers: dingtalkservice_group__1__0_models.AddContactMemberToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse:
        """
        @summary 添加联系人到群里
        
        @param request: AddContactMemberToGroupRequest
        @param headers: AddContactMemberToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddContactMemberToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.fission_type):
            body['fissionType'] = request.fission_type
        if not UtilClient.is_unset(request.member_union_id):
            body['memberUnionId'] = request.member_union_id
        if not UtilClient.is_unset(request.member_user_id):
            body['memberUserId'] = request.member_user_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddContactMemberToGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def add_contact_member_to_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddContactMemberToGroupRequest,
        headers: dingtalkservice_group__1__0_models.AddContactMemberToGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse:
        """
        @summary 添加联系人到群里
        
        @param request: AddContactMemberToGroupRequest
        @param headers: AddContactMemberToGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddContactMemberToGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.fission_type):
            body['fissionType'] = request.fission_type
        if not UtilClient.is_unset(request.member_union_id):
            body['memberUnionId'] = request.member_union_id
        if not UtilClient.is_unset(request.member_user_id):
            body['memberUserId'] = request.member_user_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddContactMemberToGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/contacts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_contact_member_to_group(
        self,
        request: dingtalkservice_group__1__0_models.AddContactMemberToGroupRequest,
    ) -> dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse:
        """
        @summary 添加联系人到群里
        
        @param request: AddContactMemberToGroupRequest
        @return: AddContactMemberToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddContactMemberToGroupHeaders()
        return self.add_contact_member_to_group_with_options(request, headers, runtime)

    async def add_contact_member_to_group_async(
        self,
        request: dingtalkservice_group__1__0_models.AddContactMemberToGroupRequest,
    ) -> dingtalkservice_group__1__0_models.AddContactMemberToGroupResponse:
        """
        @summary 添加联系人到群里
        
        @param request: AddContactMemberToGroupRequest
        @return: AddContactMemberToGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddContactMemberToGroupHeaders()
        return await self.add_contact_member_to_group_with_options_async(request, headers, runtime)

    def add_knowledge_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        """
        @summary 添加知识点
        
        @param request: AddKnowledgeRequest
        @param headers: AddKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachment_list):
            body['attachmentList'] = request.attachment_list
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.effect_timeend):
            body['effectTimeend'] = request.effect_timeend
        if not UtilClient.is_unset(request.effect_timestart):
            body['effectTimestart'] = request.effect_timestart
        if not UtilClient.is_unset(request.ext_title):
            body['extTitle'] = request.ext_title
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.link_url):
            body['linkUrl'] = request.link_url
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.question_ids):
            body['questionIds'] = request.question_ids
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/knowledges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def add_knowledge_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        """
        @summary 添加知识点
        
        @param request: AddKnowledgeRequest
        @param headers: AddKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachment_list):
            body['attachmentList'] = request.attachment_list
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.effect_timeend):
            body['effectTimeend'] = request.effect_timeend
        if not UtilClient.is_unset(request.effect_timestart):
            body['effectTimestart'] = request.effect_timestart
        if not UtilClient.is_unset(request.ext_title):
            body['extTitle'] = request.ext_title
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.link_url):
            body['linkUrl'] = request.link_url
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.question_ids):
            body['questionIds'] = request.question_ids
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/knowledges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_knowledge(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        """
        @summary 添加知识点
        
        @param request: AddKnowledgeRequest
        @return: AddKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddKnowledgeHeaders()
        return self.add_knowledge_with_options(request, headers, runtime)

    async def add_knowledge_async(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        """
        @summary 添加知识点
        
        @param request: AddKnowledgeRequest
        @return: AddKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddKnowledgeHeaders()
        return await self.add_knowledge_with_options_async(request, headers, runtime)

    def add_library_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        """
        @summary 添加服务群知识库
        
        @param request: AddLibraryRequest
        @param headers: AddLibraryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLibraryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.open_team_ids):
            body['openTeamIds'] = request.open_team_ids
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddLibrary',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/librarys',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddLibraryResponse(),
            self.execute(params, req, runtime)
        )

    async def add_library_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        """
        @summary 添加服务群知识库
        
        @param request: AddLibraryRequest
        @param headers: AddLibraryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddLibraryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.open_team_ids):
            body['openTeamIds'] = request.open_team_ids
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddLibrary',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/librarys',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddLibraryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_library(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        """
        @summary 添加服务群知识库
        
        @param request: AddLibraryRequest
        @return: AddLibraryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddLibraryHeaders()
        return self.add_library_with_options(request, headers, runtime)

    async def add_library_async(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        """
        @summary 添加服务群知识库
        
        @param request: AddLibraryRequest
        @return: AddLibraryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddLibraryHeaders()
        return await self.add_library_with_options_async(request, headers, runtime)

    def add_member_to_service_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddMemberToServiceGroupRequest,
        headers: dingtalkservice_group__1__0_models.AddMemberToServiceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse:
        """
        @summary 添加服务群群成员
        
        @param request: AddMemberToServiceGroupRequest
        @param headers: AddMemberToServiceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMemberToServiceGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddMemberToServiceGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def add_member_to_service_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddMemberToServiceGroupRequest,
        headers: dingtalkservice_group__1__0_models.AddMemberToServiceGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse:
        """
        @summary 添加服务群群成员
        
        @param request: AddMemberToServiceGroupRequest
        @param headers: AddMemberToServiceGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddMemberToServiceGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.user_ids):
            body['userIds'] = request.user_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddMemberToServiceGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_member_to_service_group(
        self,
        request: dingtalkservice_group__1__0_models.AddMemberToServiceGroupRequest,
    ) -> dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse:
        """
        @summary 添加服务群群成员
        
        @param request: AddMemberToServiceGroupRequest
        @return: AddMemberToServiceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddMemberToServiceGroupHeaders()
        return self.add_member_to_service_group_with_options(request, headers, runtime)

    async def add_member_to_service_group_async(
        self,
        request: dingtalkservice_group__1__0_models.AddMemberToServiceGroupRequest,
    ) -> dingtalkservice_group__1__0_models.AddMemberToServiceGroupResponse:
        """
        @summary 添加服务群群成员
        
        @param request: AddMemberToServiceGroupRequest
        @return: AddMemberToServiceGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddMemberToServiceGroupHeaders()
        return await self.add_member_to_service_group_with_options_async(request, headers, runtime)

    def add_open_category_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenCategoryRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenCategoryResponse:
        """
        @summary OpenApi添加知识点类目
        
        @param request: AddOpenCategoryRequest
        @param headers: AddOpenCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.library_id):
            body['libraryId'] = request.library_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenCategory',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openCategories',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def add_open_category_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenCategoryRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenCategoryResponse:
        """
        @summary OpenApi添加知识点类目
        
        @param request: AddOpenCategoryRequest
        @param headers: AddOpenCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.library_id):
            body['libraryId'] = request.library_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.parent_id):
            body['parentId'] = request.parent_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenCategory',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openCategories',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_open_category(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenCategoryRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenCategoryResponse:
        """
        @summary OpenApi添加知识点类目
        
        @param request: AddOpenCategoryRequest
        @return: AddOpenCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenCategoryHeaders()
        return self.add_open_category_with_options(request, headers, runtime)

    async def add_open_category_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenCategoryRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenCategoryResponse:
        """
        @summary OpenApi添加知识点类目
        
        @param request: AddOpenCategoryRequest
        @return: AddOpenCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenCategoryHeaders()
        return await self.add_open_category_with_options_async(request, headers, runtime)

    def add_open_knowledge_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse:
        """
        @summary OpenApi添加知识入库
        
        @param request: AddOpenKnowledgeRequest
        @param headers: AddOpenKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachments):
            body['attachments'] = request.attachments
        if not UtilClient.is_unset(request.category_id):
            body['categoryId'] = request.category_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.effect_timeend):
            body['effectTimeend'] = request.effect_timeend
        if not UtilClient.is_unset(request.effect_timestart):
            body['effectTimestart'] = request.effect_timestart
        if not UtilClient.is_unset(request.ext_title):
            body['extTitle'] = request.ext_title
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.library_id):
            body['libraryId'] = request.library_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.tags):
            body['tags'] = request.tags
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openKnowledges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def add_open_knowledge_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse:
        """
        @summary OpenApi添加知识入库
        
        @param request: AddOpenKnowledgeRequest
        @param headers: AddOpenKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attachments):
            body['attachments'] = request.attachments
        if not UtilClient.is_unset(request.category_id):
            body['categoryId'] = request.category_id
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.effect_timeend):
            body['effectTimeend'] = request.effect_timeend
        if not UtilClient.is_unset(request.effect_timestart):
            body['effectTimestart'] = request.effect_timestart
        if not UtilClient.is_unset(request.ext_title):
            body['extTitle'] = request.ext_title
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.library_id):
            body['libraryId'] = request.library_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.tags):
            body['tags'] = request.tags
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openKnowledges',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_open_knowledge(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse:
        """
        @summary OpenApi添加知识入库
        
        @param request: AddOpenKnowledgeRequest
        @return: AddOpenKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenKnowledgeHeaders()
        return self.add_open_knowledge_with_options(request, headers, runtime)

    async def add_open_knowledge_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenKnowledgeResponse:
        """
        @summary OpenApi添加知识入库
        
        @param request: AddOpenKnowledgeRequest
        @return: AddOpenKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenKnowledgeHeaders()
        return await self.add_open_knowledge_with_options_async(request, headers, runtime)

    def add_open_library_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenLibraryResponse:
        """
        @summary 智能服务群知识库创建
        
        @param request: AddOpenLibraryRequest
        @param headers: AddOpenLibraryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenLibraryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenLibrary',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openLibraries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenLibraryResponse(),
            self.execute(params, req, runtime)
        )

    async def add_open_library_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddOpenLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddOpenLibraryResponse:
        """
        @summary 智能服务群知识库创建
        
        @param request: AddOpenLibraryRequest
        @param headers: AddOpenLibraryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOpenLibraryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.user_name):
            body['userName'] = request.user_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOpenLibrary',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/openLibraries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddOpenLibraryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_open_library(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenLibraryResponse:
        """
        @summary 智能服务群知识库创建
        
        @param request: AddOpenLibraryRequest
        @return: AddOpenLibraryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenLibraryHeaders()
        return self.add_open_library_with_options(request, headers, runtime)

    async def add_open_library_async(
        self,
        request: dingtalkservice_group__1__0_models.AddOpenLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddOpenLibraryResponse:
        """
        @summary 智能服务群知识库创建
        
        @param request: AddOpenLibraryRequest
        @return: AddOpenLibraryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddOpenLibraryHeaders()
        return await self.add_open_library_with_options_async(request, headers, runtime)

    def add_ticket_memo_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
        headers: dingtalkservice_group__1__0_models.AddTicketMemoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        """
        @summary 添加工单备注
        
        @param request: AddTicketMemoRequest
        @param headers: AddTicketMemoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddTicketMemoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddTicketMemo',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/memos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddTicketMemoResponse(),
            self.execute(params, req, runtime)
        )

    async def add_ticket_memo_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
        headers: dingtalkservice_group__1__0_models.AddTicketMemoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        """
        @summary 添加工单备注
        
        @param request: AddTicketMemoRequest
        @param headers: AddTicketMemoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddTicketMemoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddTicketMemo',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/memos',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddTicketMemoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_ticket_memo(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        """
        @summary 添加工单备注
        
        @param request: AddTicketMemoRequest
        @return: AddTicketMemoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddTicketMemoHeaders()
        return self.add_ticket_memo_with_options(request, headers, runtime)

    async def add_ticket_memo_async(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        """
        @summary 添加工单备注
        
        @param request: AddTicketMemoRequest
        @return: AddTicketMemoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddTicketMemoHeaders()
        return await self.add_ticket_memo_with_options_async(request, headers, runtime)

    def assign_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
        headers: dingtalkservice_group__1__0_models.AssignTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        """
        @summary 工单指派
        
        @param request: AssignTicketRequest
        @param headers: AssignTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AssignTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AssignTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AssignTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def assign_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
        headers: dingtalkservice_group__1__0_models.AssignTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        """
        @summary 工单指派
        
        @param request: AssignTicketRequest
        @param headers: AssignTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AssignTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AssignTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/assign',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AssignTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def assign_ticket(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        """
        @summary 工单指派
        
        @param request: AssignTicketRequest
        @return: AssignTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AssignTicketHeaders()
        return self.assign_ticket_with_options(request, headers, runtime)

    async def assign_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        """
        @summary 工单指派
        
        @param request: AssignTicketRequest
        @return: AssignTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AssignTicketHeaders()
        return await self.assign_ticket_with_options_async(request, headers, runtime)

    def batch_binding_group_biz_ids_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsRequest,
        headers: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse:
        """
        @summary 批量绑定服务群业务ID
        
        @param request: BatchBindingGroupBizIdsRequest
        @param headers: BatchBindingGroupBizIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchBindingGroupBizIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.binding_group_biz_ids):
            body['bindingGroupBizIds'] = request.binding_group_biz_ids
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchBindingGroupBizIds',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_binding_group_biz_ids_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsRequest,
        headers: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse:
        """
        @summary 批量绑定服务群业务ID
        
        @param request: BatchBindingGroupBizIdsRequest
        @param headers: BatchBindingGroupBizIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchBindingGroupBizIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.binding_group_biz_ids):
            body['bindingGroupBizIds'] = request.binding_group_biz_ids
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchBindingGroupBizIds',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/bind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_binding_group_biz_ids(
        self,
        request: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsRequest,
    ) -> dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse:
        """
        @summary 批量绑定服务群业务ID
        
        @param request: BatchBindingGroupBizIdsRequest
        @return: BatchBindingGroupBizIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsHeaders()
        return self.batch_binding_group_biz_ids_with_options(request, headers, runtime)

    async def batch_binding_group_biz_ids_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsRequest,
    ) -> dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsResponse:
        """
        @summary 批量绑定服务群业务ID
        
        @param request: BatchBindingGroupBizIdsRequest
        @return: BatchBindingGroupBizIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchBindingGroupBizIdsHeaders()
        return await self.batch_binding_group_biz_ids_with_options_async(request, headers, runtime)

    def batch_get_group_set_config_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
        headers: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        """
        @summary 批量查询群组配置
        
        @param request: BatchGetGroupSetConfigRequest
        @param headers: BatchGetGroupSetConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetGroupSetConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_keys):
            body['configKeys'] = request.config_keys
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchGetGroupSetConfig',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSetConfigs/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_get_group_set_config_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
        headers: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        """
        @summary 批量查询群组配置
        
        @param request: BatchGetGroupSetConfigRequest
        @param headers: BatchGetGroupSetConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchGetGroupSetConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_keys):
            body['configKeys'] = request.config_keys
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchGetGroupSetConfig',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSetConfigs/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_get_group_set_config(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        """
        @summary 批量查询群组配置
        
        @param request: BatchGetGroupSetConfigRequest
        @return: BatchGetGroupSetConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders()
        return self.batch_get_group_set_config_with_options(request, headers, runtime)

    async def batch_get_group_set_config_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        """
        @summary 批量查询群组配置
        
        @param request: BatchGetGroupSetConfigRequest
        @return: BatchGetGroupSetConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders()
        return await self.batch_get_group_set_config_with_options_async(request, headers, runtime)

    def batch_query_customer_send_task_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskRequest,
        headers: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse:
        """
        @summary 批量查询客户群发任务
        
        @param request: BatchQueryCustomerSendTaskRequest
        @param headers: BatchQueryCustomerSendTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryCustomerSendTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.need_rich_statistics):
            body['needRichStatistics'] = request.need_rich_statistics
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_ids):
            body['openBatchTaskIds'] = request.open_batch_task_ids
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryCustomerSendTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_customer_send_task_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskRequest,
        headers: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse:
        """
        @summary 批量查询客户群发任务
        
        @param request: BatchQueryCustomerSendTaskRequest
        @param headers: BatchQueryCustomerSendTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryCustomerSendTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.need_rich_statistics):
            body['needRichStatistics'] = request.need_rich_statistics
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_ids):
            body['openBatchTaskIds'] = request.open_batch_task_ids
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryCustomerSendTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_customer_send_task(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse:
        """
        @summary 批量查询客户群发任务
        
        @param request: BatchQueryCustomerSendTaskRequest
        @return: BatchQueryCustomerSendTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskHeaders()
        return self.batch_query_customer_send_task_with_options(request, headers, runtime)

    async def batch_query_customer_send_task_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskResponse:
        """
        @summary 批量查询客户群发任务
        
        @param request: BatchQueryCustomerSendTaskRequest
        @return: BatchQueryCustomerSendTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQueryCustomerSendTaskHeaders()
        return await self.batch_query_customer_send_task_with_options_async(request, headers, runtime)

    def batch_query_group_member_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryGroupMemberRequest,
        headers: dingtalkservice_group__1__0_models.BatchQueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 批量查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @param headers: BatchQueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryGroupMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryGroupMember',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_group_member_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryGroupMemberRequest,
        headers: dingtalkservice_group__1__0_models.BatchQueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 批量查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @param headers: BatchQueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryGroupMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryGroupMember',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_group_member(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryGroupMemberRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 批量查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @return: BatchQueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQueryGroupMemberHeaders()
        return self.batch_query_group_member_with_options(request, headers, runtime)

    async def batch_query_group_member_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQueryGroupMemberRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 批量查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @return: BatchQueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQueryGroupMemberHeaders()
        return await self.batch_query_group_member_with_options_async(request, headers, runtime)

    def batch_query_send_message_task_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskRequest,
        headers: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse:
        """
        @summary 群发任务批量查询
        
        @param request: BatchQuerySendMessageTaskRequest
        @param headers: BatchQuerySendMessageTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQuerySendMessageTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.get_read_count):
            body['getReadCount'] = request.get_read_count
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQuerySendMessageTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_send_message_task_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskRequest,
        headers: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse:
        """
        @summary 群发任务批量查询
        
        @param request: BatchQuerySendMessageTaskRequest
        @param headers: BatchQuerySendMessageTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQuerySendMessageTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.get_read_count):
            body['getReadCount'] = request.get_read_count
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQuerySendMessageTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_send_message_task(
        self,
        request: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse:
        """
        @summary 群发任务批量查询
        
        @param request: BatchQuerySendMessageTaskRequest
        @return: BatchQuerySendMessageTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskHeaders()
        return self.batch_query_send_message_task_with_options(request, headers, runtime)

    async def batch_query_send_message_task_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskRequest,
    ) -> dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskResponse:
        """
        @summary 群发任务批量查询
        
        @param request: BatchQuerySendMessageTaskRequest
        @return: BatchQuerySendMessageTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchQuerySendMessageTaskHeaders()
        return await self.batch_query_send_message_task_with_options_async(request, headers, runtime)

    def bound_template_to_team_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BoundTemplateToTeamRequest,
        headers: dingtalkservice_group__1__0_models.BoundTemplateToTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse:
        """
        @summary 绑定服务群模板到团队
        
        @param request: BoundTemplateToTeamRequest
        @param headers: BoundTemplateToTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BoundTemplateToTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.robot_config):
            body['robotConfig'] = request.robot_config
        if not UtilClient.is_unset(request.template_desc):
            body['templateDesc'] = request.template_desc
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
        if not UtilClient.is_unset(request.template_type):
            body['templateType'] = request.template_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BoundTemplateToTeam',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/teams/templates/bound',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def bound_template_to_team_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BoundTemplateToTeamRequest,
        headers: dingtalkservice_group__1__0_models.BoundTemplateToTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse:
        """
        @summary 绑定服务群模板到团队
        
        @param request: BoundTemplateToTeamRequest
        @param headers: BoundTemplateToTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BoundTemplateToTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.robot_config):
            body['robotConfig'] = request.robot_config
        if not UtilClient.is_unset(request.template_desc):
            body['templateDesc'] = request.template_desc
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.template_name):
            body['templateName'] = request.template_name
        if not UtilClient.is_unset(request.template_type):
            body['templateType'] = request.template_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BoundTemplateToTeam',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/teams/templates/bound',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def bound_template_to_team(
        self,
        request: dingtalkservice_group__1__0_models.BoundTemplateToTeamRequest,
    ) -> dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse:
        """
        @summary 绑定服务群模板到团队
        
        @param request: BoundTemplateToTeamRequest
        @return: BoundTemplateToTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BoundTemplateToTeamHeaders()
        return self.bound_template_to_team_with_options(request, headers, runtime)

    async def bound_template_to_team_async(
        self,
        request: dingtalkservice_group__1__0_models.BoundTemplateToTeamRequest,
    ) -> dingtalkservice_group__1__0_models.BoundTemplateToTeamResponse:
        """
        @summary 绑定服务群模板到团队
        
        @param request: BoundTemplateToTeamRequest
        @return: BoundTemplateToTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BoundTemplateToTeamHeaders()
        return await self.bound_template_to_team_with_options_async(request, headers, runtime)

    def cancel_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CancelTicketRequest,
        headers: dingtalkservice_group__1__0_models.CancelTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CancelTicketResponse:
        """
        @summary 撤销工单
        
        @param request: CancelTicketRequest
        @param headers: CancelTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CancelTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CancelTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def cancel_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CancelTicketRequest,
        headers: dingtalkservice_group__1__0_models.CancelTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CancelTicketResponse:
        """
        @summary 撤销工单
        
        @param request: CancelTicketRequest
        @param headers: CancelTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CancelTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CancelTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/cancel',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CancelTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cancel_ticket(
        self,
        request: dingtalkservice_group__1__0_models.CancelTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CancelTicketResponse:
        """
        @summary 撤销工单
        
        @param request: CancelTicketRequest
        @return: CancelTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CancelTicketHeaders()
        return self.cancel_ticket_with_options(request, headers, runtime)

    async def cancel_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.CancelTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CancelTicketResponse:
        """
        @summary 撤销工单
        
        @param request: CancelTicketRequest
        @return: CancelTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CancelTicketHeaders()
        return await self.cancel_ticket_with_options_async(request, headers, runtime)

    def category_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CategoryStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.CategoryStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CategoryStatisticsResponse:
        """
        @summary 心声总览自定义分类统计
        
        @param request: CategoryStatisticsRequest
        @param headers: CategoryStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoryStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CategoryStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/categories/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CategoryStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def category_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CategoryStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.CategoryStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CategoryStatisticsResponse:
        """
        @summary 心声总览自定义分类统计
        
        @param request: CategoryStatisticsRequest
        @param headers: CategoryStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoryStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CategoryStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/categories/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CategoryStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def category_statistics(
        self,
        request: dingtalkservice_group__1__0_models.CategoryStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.CategoryStatisticsResponse:
        """
        @summary 心声总览自定义分类统计
        
        @param request: CategoryStatisticsRequest
        @return: CategoryStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CategoryStatisticsHeaders()
        return self.category_statistics_with_options(request, headers, runtime)

    async def category_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.CategoryStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.CategoryStatisticsResponse:
        """
        @summary 心声总览自定义分类统计
        
        @param request: CategoryStatisticsRequest
        @return: CategoryStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CategoryStatisticsHeaders()
        return await self.category_statistics_with_options_async(request, headers, runtime)

    def close_conversation_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CloseConversationRequest,
        headers: dingtalkservice_group__1__0_models.CloseConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseConversationResponse:
        """
        @summary 关闭会话回调
        
        @param request: CloseConversationRequest
        @param headers: CloseConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_tips):
            body['serverTips'] = request.server_tips
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.target_channel):
            body['targetChannel'] = request.target_channel
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CloseConversation',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/conversions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def close_conversation_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseConversationRequest,
        headers: dingtalkservice_group__1__0_models.CloseConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseConversationResponse:
        """
        @summary 关闭会话回调
        
        @param request: CloseConversationRequest
        @param headers: CloseConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_tips):
            body['serverTips'] = request.server_tips
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.target_channel):
            body['targetChannel'] = request.target_channel
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CloseConversation',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/conversions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def close_conversation(
        self,
        request: dingtalkservice_group__1__0_models.CloseConversationRequest,
    ) -> dingtalkservice_group__1__0_models.CloseConversationResponse:
        """
        @summary 关闭会话回调
        
        @param request: CloseConversationRequest
        @return: CloseConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseConversationHeaders()
        return self.close_conversation_with_options(request, headers, runtime)

    async def close_conversation_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseConversationRequest,
    ) -> dingtalkservice_group__1__0_models.CloseConversationResponse:
        """
        @summary 关闭会话回调
        
        @param request: CloseConversationRequest
        @return: CloseConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseConversationHeaders()
        return await self.close_conversation_with_options_async(request, headers, runtime)

    def close_human_session_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
        headers: dingtalkservice_group__1__0_models.CloseHumanSessionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        """
        @summary 关闭人工会话
        
        @param request: CloseHumanSessionRequest
        @param headers: CloseHumanSessionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseHumanSessionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CloseHumanSession',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/humanSessions/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseHumanSessionResponse(),
            self.execute(params, req, runtime)
        )

    async def close_human_session_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
        headers: dingtalkservice_group__1__0_models.CloseHumanSessionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        """
        @summary 关闭人工会话
        
        @param request: CloseHumanSessionRequest
        @param headers: CloseHumanSessionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CloseHumanSessionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CloseHumanSession',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/humanSessions/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseHumanSessionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def close_human_session(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        """
        @summary 关闭人工会话
        
        @param request: CloseHumanSessionRequest
        @return: CloseHumanSessionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseHumanSessionHeaders()
        return self.close_human_session_with_options(request, headers, runtime)

    async def close_human_session_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        """
        @summary 关闭人工会话
        
        @param request: CloseHumanSessionRequest
        @return: CloseHumanSessionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseHumanSessionHeaders()
        return await self.close_human_session_with_options_async(request, headers, runtime)

    def conversation_created_notify_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ConversationCreatedNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationCreatedNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse:
        """
        @summary 客服分配成功通知回调
        
        @param request: ConversationCreatedNotifyRequest
        @param headers: ConversationCreatedNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationCreatedNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_user_id):
            body['alipayUserId'] = request.alipay_user_id
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_name):
            body['serverName'] = request.server_name
        if not UtilClient.is_unset(request.server_tips):
            body['serverTips'] = request.server_tips
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.timeout_remind_tips):
            body['timeoutRemindTips'] = request.timeout_remind_tips
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationCreatedNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse(),
            self.execute(params, req, runtime)
        )

    async def conversation_created_notify_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationCreatedNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationCreatedNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse:
        """
        @summary 客服分配成功通知回调
        
        @param request: ConversationCreatedNotifyRequest
        @param headers: ConversationCreatedNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationCreatedNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_user_id):
            body['alipayUserId'] = request.alipay_user_id
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_name):
            body['serverName'] = request.server_name
        if not UtilClient.is_unset(request.server_tips):
            body['serverTips'] = request.server_tips
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.timeout_remind_tips):
            body['timeoutRemindTips'] = request.timeout_remind_tips
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationCreatedNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def conversation_created_notify(
        self,
        request: dingtalkservice_group__1__0_models.ConversationCreatedNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse:
        """
        @summary 客服分配成功通知回调
        
        @param request: ConversationCreatedNotifyRequest
        @return: ConversationCreatedNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationCreatedNotifyHeaders()
        return self.conversation_created_notify_with_options(request, headers, runtime)

    async def conversation_created_notify_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationCreatedNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationCreatedNotifyResponse:
        """
        @summary 客服分配成功通知回调
        
        @param request: ConversationCreatedNotifyRequest
        @return: ConversationCreatedNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationCreatedNotifyHeaders()
        return await self.conversation_created_notify_with_options_async(request, headers, runtime)

    def conversation_transfer_begin_notify_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse:
        """
        @summary 会话转接开始通知回调
        
        @param request: ConversationTransferBeginNotifyRequest
        @param headers: ConversationTransferBeginNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationTransferBeginNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.source_skill_group_id):
            body['sourceSkillGroupId'] = request.source_skill_group_id
        if not UtilClient.is_unset(request.target_skill_group_id):
            body['targetSkillGroupId'] = request.target_skill_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationTransferBeginNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/transfers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse(),
            self.execute(params, req, runtime)
        )

    async def conversation_transfer_begin_notify_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse:
        """
        @summary 会话转接开始通知回调
        
        @param request: ConversationTransferBeginNotifyRequest
        @param headers: ConversationTransferBeginNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationTransferBeginNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.memo):
            body['memo'] = request.memo
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.source_skill_group_id):
            body['sourceSkillGroupId'] = request.source_skill_group_id
        if not UtilClient.is_unset(request.target_skill_group_id):
            body['targetSkillGroupId'] = request.target_skill_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationTransferBeginNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/transfers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def conversation_transfer_begin_notify(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse:
        """
        @summary 会话转接开始通知回调
        
        @param request: ConversationTransferBeginNotifyRequest
        @return: ConversationTransferBeginNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyHeaders()
        return self.conversation_transfer_begin_notify_with_options(request, headers, runtime)

    async def conversation_transfer_begin_notify_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyResponse:
        """
        @summary 会话转接开始通知回调
        
        @param request: ConversationTransferBeginNotifyRequest
        @return: ConversationTransferBeginNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationTransferBeginNotifyHeaders()
        return await self.conversation_transfer_begin_notify_with_options_async(request, headers, runtime)

    def conversation_transfer_complete_notify_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse:
        """
        @summary 会话转接完成通知回调
        
        @param request: ConversationTransferCompleteNotifyRequest
        @param headers: ConversationTransferCompleteNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationTransferCompleteNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_user_id):
            body['alipayUserId'] = request.alipay_user_id
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationTransferCompleteNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/completes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse(),
            self.execute(params, req, runtime)
        )

    async def conversation_transfer_complete_notify_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyRequest,
        headers: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse:
        """
        @summary 会话转接完成通知回调
        
        @param request: ConversationTransferCompleteNotifyRequest
        @param headers: ConversationTransferCompleteNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ConversationTransferCompleteNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.alipay_user_id):
            body['alipayUserId'] = request.alipay_user_id
        if not UtilClient.is_unset(request.conversation_id):
            body['conversationId'] = request.conversation_id
        if not UtilClient.is_unset(request.nick_name):
            body['nickName'] = request.nick_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ConversationTransferCompleteNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/completes',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def conversation_transfer_complete_notify(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse:
        """
        @summary 会话转接完成通知回调
        
        @param request: ConversationTransferCompleteNotifyRequest
        @return: ConversationTransferCompleteNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyHeaders()
        return self.conversation_transfer_complete_notify_with_options(request, headers, runtime)

    async def conversation_transfer_complete_notify_async(
        self,
        request: dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyResponse:
        """
        @summary 会话转接完成通知回调
        
        @param request: ConversationTransferCompleteNotifyRequest
        @return: ConversationTransferCompleteNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ConversationTransferCompleteNotifyHeaders()
        return await self.conversation_transfer_complete_notify_with_options_async(request, headers, runtime)

    def create_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        """
        @summary 创建服务群
        
        @param request: CreateGroupRequest
        @param headers: CreateGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_biz_id):
            body['groupBizId'] = request.group_biz_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_tag_names):
            body['groupTagNames'] = request.group_tag_names
        if not UtilClient.is_unset(request.member_staff_ids):
            body['memberStaffIds'] = request.member_staff_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.owner_staff_id):
            body['ownerStaffId'] = request.owner_staff_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        """
        @summary 创建服务群
        
        @param request: CreateGroupRequest
        @param headers: CreateGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_biz_id):
            body['groupBizId'] = request.group_biz_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_tag_names):
            body['groupTagNames'] = request.group_tag_names
        if not UtilClient.is_unset(request.member_staff_ids):
            body['memberStaffIds'] = request.member_staff_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.owner_staff_id):
            body['ownerStaffId'] = request.owner_staff_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        """
        @summary 创建服务群
        
        @param request: CreateGroupRequest
        @return: CreateGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        """
        @summary 创建服务群
        
        @param request: CreateGroupRequest
        @return: CreateGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

    def create_group_conversation_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupConversationRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建主动会话接口
        
        @param request: CreateGroupConversationRequest
        @param headers: CreateGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ding_group_id):
            body['dingGroupId'] = request.ding_group_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.ding_user_name):
            body['dingUserName'] = request.ding_user_name
        if not UtilClient.is_unset(request.ext_values):
            body['extValues'] = request.ext_values
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_group_id):
            body['serverGroupId'] = request.server_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroupConversation',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/create/conversations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_conversation_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupConversationRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建主动会话接口
        
        @param request: CreateGroupConversationRequest
        @param headers: CreateGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupConversationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.ding_group_id):
            body['dingGroupId'] = request.ding_group_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.ding_user_name):
            body['dingUserName'] = request.ding_user_name
        if not UtilClient.is_unset(request.ext_values):
            body['extValues'] = request.ext_values
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_group_id):
            body['serverGroupId'] = request.server_group_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroupConversation',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/create/conversations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group_conversation(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupConversationRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建主动会话接口
        
        @param request: CreateGroupConversationRequest
        @return: CreateGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupConversationHeaders()
        return self.create_group_conversation_with_options(request, headers, runtime)

    async def create_group_conversation_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupConversationRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建主动会话接口
        
        @param request: CreateGroupConversationRequest
        @return: CreateGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupConversationHeaders()
        return await self.create_group_conversation_with_options_async(request, headers, runtime)

    def create_group_set_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建服务群群分组
        
        @param request: CreateGroupSetRequest
        @param headers: CreateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupSetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_set_name):
            body['groupSetName'] = request.group_set_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def create_group_set_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建服务群群分组
        
        @param request: CreateGroupSetRequest
        @param headers: CreateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupSetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_set_name):
            body['groupSetName'] = request.group_set_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_group_set(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建服务群群分组
        
        @param request: CreateGroupSetRequest
        @return: CreateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupSetHeaders()
        return self.create_group_set_with_options(request, headers, runtime)

    async def create_group_set_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupSetResponse:
        """
        @summary 创建服务群群分组
        
        @param request: CreateGroupSetRequest
        @return: CreateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupSetHeaders()
        return await self.create_group_set_with_options_async(request, headers, runtime)

    def create_instance_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateInstanceRequest,
        headers: dingtalkservice_group__1__0_models.CreateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: CreateInstanceRequest
        @param headers: CreateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.external_biz_id):
            body['externalBizId'] = request.external_biz_id
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_instance_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateInstanceRequest,
        headers: dingtalkservice_group__1__0_models.CreateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: CreateInstanceRequest
        @param headers: CreateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.external_biz_id):
            body['externalBizId'] = request.external_biz_id
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_instance(
        self,
        request: dingtalkservice_group__1__0_models.CreateInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.CreateInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: CreateInstanceRequest
        @return: CreateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateInstanceHeaders()
        return self.create_instance_with_options(request, headers, runtime)

    async def create_instance_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.CreateInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: CreateInstanceRequest
        @return: CreateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateInstanceHeaders()
        return await self.create_instance_with_options_async(request, headers, runtime)

    def create_team_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateTeamRequest,
        headers: dingtalkservice_group__1__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTeamResponse:
        """
        @summary 创建服务群团队
        
        @param request: CreateTeamRequest
        @param headers: CreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_ding_union_id):
            body['creatorDingUnionId'] = request.creator_ding_union_id
        if not UtilClient.is_unset(request.team_name):
            body['teamName'] = request.team_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTeam',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def create_team_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTeamRequest,
        headers: dingtalkservice_group__1__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTeamResponse:
        """
        @summary 创建服务群团队
        
        @param request: CreateTeamRequest
        @param headers: CreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_ding_union_id):
            body['creatorDingUnionId'] = request.creator_ding_union_id
        if not UtilClient.is_unset(request.team_name):
            body['teamName'] = request.team_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTeam',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_team(
        self,
        request: dingtalkservice_group__1__0_models.CreateTeamRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTeamResponse:
        """
        @summary 创建服务群团队
        
        @param request: CreateTeamRequest
        @return: CreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTeamHeaders()
        return self.create_team_with_options(request, headers, runtime)

    async def create_team_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTeamRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTeamResponse:
        """
        @summary 创建服务群团队
        
        @param request: CreateTeamRequest
        @return: CreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTeamHeaders()
        return await self.create_team_with_options_async(request, headers, runtime)

    def create_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
        headers: dingtalkservice_group__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        """
        @summary 创建工单
        
        @param request: CreateTicketRequest
        @param headers: CreateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def create_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
        headers: dingtalkservice_group__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        """
        @summary 创建工单
        
        @param request: CreateTicketRequest
        @param headers: CreateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_ticket(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        """
        @summary 创建工单
        
        @param request: CreateTicketRequest
        @return: CreateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTicketHeaders()
        return self.create_ticket_with_options(request, headers, runtime)

    async def create_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        """
        @summary 创建工单
        
        @param request: CreateTicketRequest
        @return: CreateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTicketHeaders()
        return await self.create_ticket_with_options_async(request, headers, runtime)

    def customer_send_msg_task_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CustomerSendMsgTaskRequest,
        headers: dingtalkservice_group__1__0_models.CustomerSendMsgTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse:
        """
        @summary 客户群发任务
        
        @param request: CustomerSendMsgTaskRequest
        @param headers: CustomerSendMsgTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomerSendMsgTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.query_customer):
            body['queryCustomer'] = request.query_customer
        if not UtilClient.is_unset(request.send_config):
            body['sendConfig'] = request.send_config
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CustomerSendMsgTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def customer_send_msg_task_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CustomerSendMsgTaskRequest,
        headers: dingtalkservice_group__1__0_models.CustomerSendMsgTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse:
        """
        @summary 客户群发任务
        
        @param request: CustomerSendMsgTaskRequest
        @param headers: CustomerSendMsgTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomerSendMsgTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.query_customer):
            body['queryCustomer'] = request.query_customer
        if not UtilClient.is_unset(request.send_config):
            body['sendConfig'] = request.send_config
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CustomerSendMsgTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def customer_send_msg_task(
        self,
        request: dingtalkservice_group__1__0_models.CustomerSendMsgTaskRequest,
    ) -> dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse:
        """
        @summary 客户群发任务
        
        @param request: CustomerSendMsgTaskRequest
        @return: CustomerSendMsgTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CustomerSendMsgTaskHeaders()
        return self.customer_send_msg_task_with_options(request, headers, runtime)

    async def customer_send_msg_task_async(
        self,
        request: dingtalkservice_group__1__0_models.CustomerSendMsgTaskRequest,
    ) -> dingtalkservice_group__1__0_models.CustomerSendMsgTaskResponse:
        """
        @summary 客户群发任务
        
        @param request: CustomerSendMsgTaskRequest
        @return: CustomerSendMsgTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CustomerSendMsgTaskHeaders()
        return await self.customer_send_msg_task_with_options_async(request, headers, runtime)

    def delete_group_members_from_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupRequest,
        headers: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse:
        """
        @summary 从群或者群组剔除成员
        
        @param request: DeleteGroupMembersFromGroupRequest
        @param headers: DeleteGroupMembersFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGroupMembersFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_group_type):
            body['deleteGroupType'] = request.delete_group_type
        if not UtilClient.is_unset(request.member_union_id):
            body['memberUnionId'] = request.member_union_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteGroupMembersFromGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_group_members_from_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupRequest,
        headers: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse:
        """
        @summary 从群或者群组剔除成员
        
        @param request: DeleteGroupMembersFromGroupRequest
        @param headers: DeleteGroupMembersFromGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteGroupMembersFromGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.delete_group_type):
            body['deleteGroupType'] = request.delete_group_type
        if not UtilClient.is_unset(request.member_union_id):
            body['memberUnionId'] = request.member_union_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteGroupMembersFromGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_group_members_from_group(
        self,
        request: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse:
        """
        @summary 从群或者群组剔除成员
        
        @param request: DeleteGroupMembersFromGroupRequest
        @return: DeleteGroupMembersFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupHeaders()
        return self.delete_group_members_from_group_with_options(request, headers, runtime)

    async def delete_group_members_from_group_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupResponse:
        """
        @summary 从群或者群组剔除成员
        
        @param request: DeleteGroupMembersFromGroupRequest
        @return: DeleteGroupMembersFromGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteGroupMembersFromGroupHeaders()
        return await self.delete_group_members_from_group_with_options_async(request, headers, runtime)

    def delete_instance_with_options(
        self,
        request: dingtalkservice_group__1__0_models.DeleteInstanceRequest,
        headers: dingtalkservice_group__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteInstanceResponse:
        """
        @summary 服务群删除表单实例
        
        @param request: DeleteInstanceRequest
        @param headers: DeleteInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.open_data_instance_id):
            body['openDataInstanceId'] = request.open_data_instance_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_instance_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteInstanceRequest,
        headers: dingtalkservice_group__1__0_models.DeleteInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteInstanceResponse:
        """
        @summary 服务群删除表单实例
        
        @param request: DeleteInstanceRequest
        @param headers: DeleteInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.open_data_instance_id):
            body['openDataInstanceId'] = request.open_data_instance_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_instance(
        self,
        request: dingtalkservice_group__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteInstanceResponse:
        """
        @summary 服务群删除表单实例
        
        @param request: DeleteInstanceRequest
        @return: DeleteInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteInstanceHeaders()
        return self.delete_instance_with_options(request, headers, runtime)

    async def delete_instance_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteInstanceResponse:
        """
        @summary 服务群删除表单实例
        
        @param request: DeleteInstanceRequest
        @return: DeleteInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteInstanceHeaders()
        return await self.delete_instance_with_options_async(request, headers, runtime)

    def delete_knowledge_with_options(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 服务群删除知识点
        
        @param request: DeleteKnowledgeRequest
        @param headers: DeleteKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/knowledges/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteKnowledgeResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_knowledge_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 服务群删除知识点
        
        @param request: DeleteKnowledgeRequest
        @param headers: DeleteKnowledgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteKnowledgeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteKnowledge',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/knowledges/batchDelete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteKnowledgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_knowledge(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 服务群删除知识点
        
        @param request: DeleteKnowledgeRequest
        @return: DeleteKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders()
        return self.delete_knowledge_with_options(request, headers, runtime)

    async def delete_knowledge_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        """
        @summary 服务群删除知识点
        
        @param request: DeleteKnowledgeRequest
        @return: DeleteKnowledgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders()
        return await self.delete_knowledge_with_options_async(request, headers, runtime)

    def emotion_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.EmotionStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.EmotionStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.EmotionStatisticsResponse:
        """
        @summary 客户心声负面情绪统计
        
        @param request: EmotionStatisticsRequest
        @param headers: EmotionStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EmotionStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.max_emotion):
            query['maxEmotion'] = request.max_emotion
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.min_emotion):
            query['minEmotion'] = request.min_emotion
        if not UtilClient.is_unset(request.open_conversation_ids):
            query['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            query['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='EmotionStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/emotions/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.EmotionStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def emotion_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.EmotionStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.EmotionStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.EmotionStatisticsResponse:
        """
        @summary 客户心声负面情绪统计
        
        @param request: EmotionStatisticsRequest
        @param headers: EmotionStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EmotionStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.max_emotion):
            query['maxEmotion'] = request.max_emotion
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.min_emotion):
            query['minEmotion'] = request.min_emotion
        if not UtilClient.is_unset(request.open_conversation_ids):
            query['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            query['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='EmotionStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/emotions/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.EmotionStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def emotion_statistics(
        self,
        request: dingtalkservice_group__1__0_models.EmotionStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.EmotionStatisticsResponse:
        """
        @summary 客户心声负面情绪统计
        
        @param request: EmotionStatisticsRequest
        @return: EmotionStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.EmotionStatisticsHeaders()
        return self.emotion_statistics_with_options(request, headers, runtime)

    async def emotion_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.EmotionStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.EmotionStatisticsResponse:
        """
        @summary 客户心声负面情绪统计
        
        @param request: EmotionStatisticsRequest
        @return: EmotionStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.EmotionStatisticsHeaders()
        return await self.emotion_statistics_with_options_async(request, headers, runtime)

    def finish_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
        headers: dingtalkservice_group__1__0_models.FinishTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        """
        @summary 结单
        
        @param request: FinishTicketRequest
        @param headers: FinishTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FinishTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='FinishTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.FinishTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def finish_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
        headers: dingtalkservice_group__1__0_models.FinishTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        """
        @summary 结单
        
        @param request: FinishTicketRequest
        @param headers: FinishTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FinishTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='FinishTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/finish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.FinishTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def finish_ticket(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        """
        @summary 结单
        
        @param request: FinishTicketRequest
        @return: FinishTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.FinishTicketHeaders()
        return self.finish_ticket_with_options(request, headers, runtime)

    async def finish_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        """
        @summary 结单
        
        @param request: FinishTicketRequest
        @return: FinishTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.FinishTicketHeaders()
        return await self.finish_ticket_with_options_async(request, headers, runtime)

    def get_auth_token_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetAuthTokenRequest,
        headers: dingtalkservice_group__1__0_models.GetAuthTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetAuthTokenResponse:
        """
        @summary 获取签权Token
        
        @param request: GetAuthTokenRequest
        @param headers: GetAuthTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAuthTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.effective_time):
            body['effectiveTime'] = request.effective_time
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_id):
            body['serverId'] = request.server_id
        if not UtilClient.is_unset(request.server_name):
            body['serverName'] = request.server_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetAuthToken',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/get/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetAuthTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def get_auth_token_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetAuthTokenRequest,
        headers: dingtalkservice_group__1__0_models.GetAuthTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetAuthTokenResponse:
        """
        @summary 获取签权Token
        
        @param request: GetAuthTokenRequest
        @param headers: GetAuthTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAuthTokenResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.channel):
            body['channel'] = request.channel
        if not UtilClient.is_unset(request.effective_time):
            body['effectiveTime'] = request.effective_time
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.server_id):
            body['serverId'] = request.server_id
        if not UtilClient.is_unset(request.server_name):
            body['serverName'] = request.server_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetAuthToken',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/get/tokens',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetAuthTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_auth_token(
        self,
        request: dingtalkservice_group__1__0_models.GetAuthTokenRequest,
    ) -> dingtalkservice_group__1__0_models.GetAuthTokenResponse:
        """
        @summary 获取签权Token
        
        @param request: GetAuthTokenRequest
        @return: GetAuthTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetAuthTokenHeaders()
        return self.get_auth_token_with_options(request, headers, runtime)

    async def get_auth_token_async(
        self,
        request: dingtalkservice_group__1__0_models.GetAuthTokenRequest,
    ) -> dingtalkservice_group__1__0_models.GetAuthTokenResponse:
        """
        @summary 获取签权Token
        
        @param request: GetAuthTokenRequest
        @return: GetAuthTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetAuthTokenHeaders()
        return await self.get_auth_token_with_options_async(request, headers, runtime)

    def get_instances_by_ids_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetInstancesByIdsRequest,
        headers: dingtalkservice_group__1__0_models.GetInstancesByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetInstancesByIdsResponse:
        """
        @summary 服务群通过实例ID集合批量查询表单实例数据
        
        @param request: GetInstancesByIdsRequest
        @param headers: GetInstancesByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.open_data_instance_id_list):
            body['openDataInstanceIdList'] = request.open_data_instance_id_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetInstancesByIds',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetInstancesByIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_instances_by_ids_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetInstancesByIdsRequest,
        headers: dingtalkservice_group__1__0_models.GetInstancesByIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetInstancesByIdsResponse:
        """
        @summary 服务群通过实例ID集合批量查询表单实例数据
        
        @param request: GetInstancesByIdsRequest
        @param headers: GetInstancesByIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInstancesByIdsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.open_data_instance_id_list):
            body['openDataInstanceIdList'] = request.open_data_instance_id_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetInstancesByIds',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetInstancesByIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_instances_by_ids(
        self,
        request: dingtalkservice_group__1__0_models.GetInstancesByIdsRequest,
    ) -> dingtalkservice_group__1__0_models.GetInstancesByIdsResponse:
        """
        @summary 服务群通过实例ID集合批量查询表单实例数据
        
        @param request: GetInstancesByIdsRequest
        @return: GetInstancesByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetInstancesByIdsHeaders()
        return self.get_instances_by_ids_with_options(request, headers, runtime)

    async def get_instances_by_ids_async(
        self,
        request: dingtalkservice_group__1__0_models.GetInstancesByIdsRequest,
    ) -> dingtalkservice_group__1__0_models.GetInstancesByIdsResponse:
        """
        @summary 服务群通过实例ID集合批量查询表单实例数据
        
        @param request: GetInstancesByIdsRequest
        @return: GetInstancesByIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetInstancesByIdsHeaders()
        return await self.get_instances_by_ids_with_options_async(request, headers, runtime)

    def get_negative_word_cloud_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetNegativeWordCloudRequest,
        headers: dingtalkservice_group__1__0_models.GetNegativeWordCloudHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse:
        """
        @summary 获取负面心声词云
        
        @param request: GetNegativeWordCloudRequest
        @param headers: GetNegativeWordCloudHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNegativeWordCloudResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetNegativeWordCloud',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/negatives/wordClouds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse(),
            self.execute(params, req, runtime)
        )

    async def get_negative_word_cloud_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetNegativeWordCloudRequest,
        headers: dingtalkservice_group__1__0_models.GetNegativeWordCloudHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse:
        """
        @summary 获取负面心声词云
        
        @param request: GetNegativeWordCloudRequest
        @param headers: GetNegativeWordCloudHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNegativeWordCloudResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetNegativeWordCloud',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/negatives/wordClouds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_negative_word_cloud(
        self,
        request: dingtalkservice_group__1__0_models.GetNegativeWordCloudRequest,
    ) -> dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse:
        """
        @summary 获取负面心声词云
        
        @param request: GetNegativeWordCloudRequest
        @return: GetNegativeWordCloudResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetNegativeWordCloudHeaders()
        return self.get_negative_word_cloud_with_options(request, headers, runtime)

    async def get_negative_word_cloud_async(
        self,
        request: dingtalkservice_group__1__0_models.GetNegativeWordCloudRequest,
    ) -> dingtalkservice_group__1__0_models.GetNegativeWordCloudResponse:
        """
        @summary 获取负面心声词云
        
        @param request: GetNegativeWordCloudRequest
        @return: GetNegativeWordCloudResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetNegativeWordCloudHeaders()
        return await self.get_negative_word_cloud_with_options_async(request, headers, runtime)

    def get_oss_temp_url_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
        headers: dingtalkservice_group__1__0_models.GetOssTempUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        """
        @summary 获取临时访问链接
        
        @param request: GetOssTempUrlRequest
        @param headers: GetOssTempUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOssTempUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.fetch_mode):
            query['fetchMode'] = request.fetch_mode
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.key):
            query['key'] = request.key
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetOssTempUrl',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/ossServices/tempUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetOssTempUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def get_oss_temp_url_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
        headers: dingtalkservice_group__1__0_models.GetOssTempUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        """
        @summary 获取临时访问链接
        
        @param request: GetOssTempUrlRequest
        @param headers: GetOssTempUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOssTempUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.fetch_mode):
            query['fetchMode'] = request.fetch_mode
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.key):
            query['key'] = request.key
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetOssTempUrl',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/ossServices/tempUrls',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetOssTempUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_oss_temp_url(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        """
        @summary 获取临时访问链接
        
        @param request: GetOssTempUrlRequest
        @return: GetOssTempUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetOssTempUrlHeaders()
        return self.get_oss_temp_url_with_options(request, headers, runtime)

    async def get_oss_temp_url_async(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        """
        @summary 获取临时访问链接
        
        @param request: GetOssTempUrlRequest
        @return: GetOssTempUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetOssTempUrlHeaders()
        return await self.get_oss_temp_url_with_options_async(request, headers, runtime)

    def get_storage_policy_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
        headers: dingtalkservice_group__1__0_models.GetStoragePolicyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        """
        @summary 获取表单上传凭证
        
        @param request: GetStoragePolicyRequest
        @param headers: GetStoragePolicyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStoragePolicyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetStoragePolicy',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/ossServices/policies',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetStoragePolicyResponse(),
            self.execute(params, req, runtime)
        )

    async def get_storage_policy_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
        headers: dingtalkservice_group__1__0_models.GetStoragePolicyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        """
        @summary 获取表单上传凭证
        
        @param request: GetStoragePolicyRequest
        @param headers: GetStoragePolicyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStoragePolicyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetStoragePolicy',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/ossServices/policies',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetStoragePolicyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_storage_policy(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        """
        @summary 获取表单上传凭证
        
        @param request: GetStoragePolicyRequest
        @return: GetStoragePolicyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetStoragePolicyHeaders()
        return self.get_storage_policy_with_options(request, headers, runtime)

    async def get_storage_policy_async(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        """
        @summary 获取表单上传凭证
        
        @param request: GetStoragePolicyRequest
        @return: GetStoragePolicyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetStoragePolicyHeaders()
        return await self.get_storage_policy_with_options_async(request, headers, runtime)

    def get_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
        headers: dingtalkservice_group__1__0_models.GetTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        """
        @summary 查询工单详情
        
        @param request: GetTicketRequest
        @param headers: GetTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTicketResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            query['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
        headers: dingtalkservice_group__1__0_models.GetTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        """
        @summary 查询工单详情
        
        @param request: GetTicketRequest
        @param headers: GetTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTicketResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            query['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ticket(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        """
        @summary 查询工单详情
        
        @param request: GetTicketRequest
        @return: GetTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetTicketHeaders()
        return self.get_ticket_with_options(request, headers, runtime)

    async def get_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        """
        @summary 查询工单详情
        
        @param request: GetTicketRequest
        @return: GetTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetTicketHeaders()
        return await self.get_ticket_with_options_async(request, headers, runtime)

    def get_word_cloud_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetWordCloudRequest,
        headers: dingtalkservice_group__1__0_models.GetWordCloudHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetWordCloudResponse:
        """
        @summary 获取心声词云
        
        @param request: GetWordCloudRequest
        @param headers: GetWordCloudHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWordCloudResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetWordCloud',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/wordClouds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetWordCloudResponse(),
            self.execute(params, req, runtime)
        )

    async def get_word_cloud_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetWordCloudRequest,
        headers: dingtalkservice_group__1__0_models.GetWordCloudHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetWordCloudResponse:
        """
        @summary 获取心声词云
        
        @param request: GetWordCloudRequest
        @param headers: GetWordCloudHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetWordCloudResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GetWordCloud',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/wordClouds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetWordCloudResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_word_cloud(
        self,
        request: dingtalkservice_group__1__0_models.GetWordCloudRequest,
    ) -> dingtalkservice_group__1__0_models.GetWordCloudResponse:
        """
        @summary 获取心声词云
        
        @param request: GetWordCloudRequest
        @return: GetWordCloudResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetWordCloudHeaders()
        return self.get_word_cloud_with_options(request, headers, runtime)

    async def get_word_cloud_async(
        self,
        request: dingtalkservice_group__1__0_models.GetWordCloudRequest,
    ) -> dingtalkservice_group__1__0_models.GetWordCloudResponse:
        """
        @summary 获取心声词云
        
        @param request: GetWordCloudRequest
        @return: GetWordCloudResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetWordCloudHeaders()
        return await self.get_word_cloud_with_options_async(request, headers, runtime)

    def group_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GroupStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.GroupStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GroupStatisticsResponse:
        """
        @summary 心声总览群统计
        
        @param request: GroupStatisticsRequest
        @param headers: GroupStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GroupStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/groups/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GroupStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def group_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GroupStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.GroupStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GroupStatisticsResponse:
        """
        @summary 心声总览群统计
        
        @param request: GroupStatisticsRequest
        @param headers: GroupStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='GroupStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/groups/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GroupStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def group_statistics(
        self,
        request: dingtalkservice_group__1__0_models.GroupStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.GroupStatisticsResponse:
        """
        @summary 心声总览群统计
        
        @param request: GroupStatisticsRequest
        @return: GroupStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GroupStatisticsHeaders()
        return self.group_statistics_with_options(request, headers, runtime)

    async def group_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.GroupStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.GroupStatisticsResponse:
        """
        @summary 心声总览群统计
        
        @param request: GroupStatisticsRequest
        @return: GroupStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GroupStatisticsHeaders()
        return await self.group_statistics_with_options_async(request, headers, runtime)

    def intention_category_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse:
        """
        @summary 心声总览意图&自定义分类统计
        
        @param request: IntentionCategoryStatisticsRequest
        @param headers: IntentionCategoryStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IntentionCategoryStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='IntentionCategoryStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def intention_category_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse:
        """
        @summary 心声总览意图&自定义分类统计
        
        @param request: IntentionCategoryStatisticsRequest
        @param headers: IntentionCategoryStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IntentionCategoryStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='IntentionCategoryStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def intention_category_statistics(
        self,
        request: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse:
        """
        @summary 心声总览意图&自定义分类统计
        
        @param request: IntentionCategoryStatisticsRequest
        @return: IntentionCategoryStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.IntentionCategoryStatisticsHeaders()
        return self.intention_category_statistics_with_options(request, headers, runtime)

    async def intention_category_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.IntentionCategoryStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.IntentionCategoryStatisticsResponse:
        """
        @summary 心声总览意图&自定义分类统计
        
        @param request: IntentionCategoryStatisticsRequest
        @return: IntentionCategoryStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.IntentionCategoryStatisticsHeaders()
        return await self.intention_category_statistics_with_options_async(request, headers, runtime)

    def intention_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.IntentionStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.IntentionStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.IntentionStatisticsResponse:
        """
        @summary 心声总览意图统计
        
        @param request: IntentionStatisticsRequest
        @param headers: IntentionStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IntentionStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='IntentionStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/intentions/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.IntentionStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def intention_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.IntentionStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.IntentionStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.IntentionStatisticsResponse:
        """
        @summary 心声总览意图统计
        
        @param request: IntentionStatisticsRequest
        @param headers: IntentionStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IntentionStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='IntentionStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/dashboards/intentions/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.IntentionStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def intention_statistics(
        self,
        request: dingtalkservice_group__1__0_models.IntentionStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.IntentionStatisticsResponse:
        """
        @summary 心声总览意图统计
        
        @param request: IntentionStatisticsRequest
        @return: IntentionStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.IntentionStatisticsHeaders()
        return self.intention_statistics_with_options(request, headers, runtime)

    async def intention_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.IntentionStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.IntentionStatisticsResponse:
        """
        @summary 心声总览意图统计
        
        @param request: IntentionStatisticsRequest
        @return: IntentionStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.IntentionStatisticsHeaders()
        return await self.intention_statistics_with_options_async(request, headers, runtime)

    def list_ticket_operate_record_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
        headers: dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        """
        @summary 查询工单操作记录
        
        @param request: ListTicketOperateRecordRequest
        @param headers: ListTicketOperateRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTicketOperateRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            query['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListTicketOperateRecord',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/operateRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse(),
            self.execute(params, req, runtime)
        )

    async def list_ticket_operate_record_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
        headers: dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        """
        @summary 查询工单操作记录
        
        @param request: ListTicketOperateRecordRequest
        @param headers: ListTicketOperateRecordHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTicketOperateRecordResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            query['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='ListTicketOperateRecord',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/operateRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_ticket_operate_record(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        """
        @summary 查询工单操作记录
        
        @param request: ListTicketOperateRecordRequest
        @return: ListTicketOperateRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders()
        return self.list_ticket_operate_record_with_options(request, headers, runtime)

    async def list_ticket_operate_record_async(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        """
        @summary 查询工单操作记录
        
        @param request: ListTicketOperateRecordRequest
        @return: ListTicketOperateRecordResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders()
        return await self.list_ticket_operate_record_with_options_async(request, headers, runtime)

    def list_user_teams_with_options(
        self,
        user_id: str,
        headers: dingtalkservice_group__1__0_models.ListUserTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        """
        @summary 查询用户所在团队
        
        @param headers: ListUserTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserTeamsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListUserTeams',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/users/{user_id}/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListUserTeamsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_user_teams_with_options_async(
        self,
        user_id: str,
        headers: dingtalkservice_group__1__0_models.ListUserTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        """
        @summary 查询用户所在团队
        
        @param headers: ListUserTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListUserTeamsResponse
        """
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListUserTeams',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/users/{user_id}/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListUserTeamsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_user_teams(
        self,
        user_id: str,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        """
        @summary 查询用户所在团队
        
        @return: ListUserTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListUserTeamsHeaders()
        return self.list_user_teams_with_options(user_id, headers, runtime)

    async def list_user_teams_async(
        self,
        user_id: str,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        """
        @summary 查询用户所在团队
        
        @return: ListUserTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListUserTeamsHeaders()
        return await self.list_user_teams_with_options_async(user_id, headers, runtime)

    def query_active_users_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryActiveUsersRequest,
        headers: dingtalkservice_group__1__0_models.QueryActiveUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryActiveUsersResponse:
        """
        @summary 查询服务群活跃成员
        
        @param request: QueryActiveUsersRequest
        @param headers: QueryActiveUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryActiveUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.top_n):
            query['topN'] = request.top_n
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryActiveUsers',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/queryActiveUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryActiveUsersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_active_users_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryActiveUsersRequest,
        headers: dingtalkservice_group__1__0_models.QueryActiveUsersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryActiveUsersResponse:
        """
        @summary 查询服务群活跃成员
        
        @param request: QueryActiveUsersRequest
        @param headers: QueryActiveUsersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryActiveUsersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.top_n):
            query['topN'] = request.top_n
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryActiveUsers',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/queryActiveUsers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryActiveUsersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_active_users(
        self,
        request: dingtalkservice_group__1__0_models.QueryActiveUsersRequest,
    ) -> dingtalkservice_group__1__0_models.QueryActiveUsersResponse:
        """
        @summary 查询服务群活跃成员
        
        @param request: QueryActiveUsersRequest
        @return: QueryActiveUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryActiveUsersHeaders()
        return self.query_active_users_with_options(request, headers, runtime)

    async def query_active_users_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryActiveUsersRequest,
    ) -> dingtalkservice_group__1__0_models.QueryActiveUsersResponse:
        """
        @summary 查询服务群活跃成员
        
        @param request: QueryActiveUsersRequest
        @return: QueryActiveUsersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryActiveUsersHeaders()
        return await self.query_active_users_with_options_async(request, headers, runtime)

    def query_crm_group_contact_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryCrmGroupContactRequest,
        headers: dingtalkservice_group__1__0_models.QueryCrmGroupContactHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse:
        """
        @summary 群联系人画像检索
        
        @param request: QueryCrmGroupContactRequest
        @param headers: QueryCrmGroupContactHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmGroupContactResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.min_result):
            body['minResult'] = request.min_result
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_fields):
            body['searchFields'] = request.search_fields
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCrmGroupContact',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/contacts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse(),
            self.execute(params, req, runtime)
        )

    async def query_crm_group_contact_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCrmGroupContactRequest,
        headers: dingtalkservice_group__1__0_models.QueryCrmGroupContactHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse:
        """
        @summary 群联系人画像检索
        
        @param request: QueryCrmGroupContactRequest
        @param headers: QueryCrmGroupContactHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCrmGroupContactResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.min_result):
            body['minResult'] = request.min_result
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_fields):
            body['searchFields'] = request.search_fields
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCrmGroupContact',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/contacts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_crm_group_contact(
        self,
        request: dingtalkservice_group__1__0_models.QueryCrmGroupContactRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse:
        """
        @summary 群联系人画像检索
        
        @param request: QueryCrmGroupContactRequest
        @return: QueryCrmGroupContactResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCrmGroupContactHeaders()
        return self.query_crm_group_contact_with_options(request, headers, runtime)

    async def query_crm_group_contact_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCrmGroupContactRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCrmGroupContactResponse:
        """
        @summary 群联系人画像检索
        
        @param request: QueryCrmGroupContactRequest
        @return: QueryCrmGroupContactResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCrmGroupContactHeaders()
        return await self.query_crm_group_contact_with_options_async(request, headers, runtime)

    def query_customer_card_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerCardRequest,
        headers: dingtalkservice_group__1__0_models.QueryCustomerCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerCardResponse:
        """
        @summary 查询客户信息
        
        @param request: QueryCustomerCardRequest
        @param headers: QueryCustomerCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.json_params):
            body['jsonParams'] = request.json_params
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCustomerCard',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/userDetials',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCustomerCardResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_card_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerCardRequest,
        headers: dingtalkservice_group__1__0_models.QueryCustomerCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerCardResponse:
        """
        @summary 查询客户信息
        
        @param request: QueryCustomerCardRequest
        @param headers: QueryCustomerCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerCardResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.json_params):
            body['jsonParams'] = request.json_params
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCustomerCard',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/userDetials',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCustomerCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_card(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerCardRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerCardResponse:
        """
        @summary 查询客户信息
        
        @param request: QueryCustomerCardRequest
        @return: QueryCustomerCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCustomerCardHeaders()
        return self.query_customer_card_with_options(request, headers, runtime)

    async def query_customer_card_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerCardRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerCardResponse:
        """
        @summary 查询客户信息
        
        @param request: QueryCustomerCardRequest
        @return: QueryCustomerCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCustomerCardHeaders()
        return await self.query_customer_card_with_options_async(request, headers, runtime)

    def query_customer_task_user_detail_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailRequest,
        headers: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse:
        """
        @summary 查询客户群发任务客户触达详情
        
        @param request: QueryCustomerTaskUserDetailRequest
        @param headers: QueryCustomerTaskUserDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerTaskUserDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCustomerTaskUserDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_customer_task_user_detail_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailRequest,
        headers: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse:
        """
        @summary 查询客户群发任务客户触达详情
        
        @param request: QueryCustomerTaskUserDetailRequest
        @param headers: QueryCustomerTaskUserDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCustomerTaskUserDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryCustomerTaskUserDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_customer_task_user_detail(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse:
        """
        @summary 查询客户群发任务客户触达详情
        
        @param request: QueryCustomerTaskUserDetailRequest
        @return: QueryCustomerTaskUserDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailHeaders()
        return self.query_customer_task_user_detail_with_options(request, headers, runtime)

    async def query_customer_task_user_detail_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailRequest,
    ) -> dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailResponse:
        """
        @summary 查询客户群发任务客户触达详情
        
        @param request: QueryCustomerTaskUserDetailRequest
        @return: QueryCustomerTaskUserDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryCustomerTaskUserDetailHeaders()
        return await self.query_customer_task_user_detail_with_options_async(request, headers, runtime)

    def query_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        """
        @summary 查询单个服务群信息
        
        @param request: QueryGroupRequest
        @param headers: QueryGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        """
        @summary 查询单个服务群信息
        
        @param request: QueryGroupRequest
        @param headers: QueryGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        """
        @summary 查询单个服务群信息
        
        @param request: QueryGroupRequest
        @return: QueryGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupHeaders()
        return self.query_group_with_options(request, headers, runtime)

    async def query_group_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        """
        @summary 查询单个服务群信息
        
        @param request: QueryGroupRequest
        @return: QueryGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupHeaders()
        return await self.query_group_with_options_async(request, headers, runtime)

    def query_group_member_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupMemberRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询指定群成员
        
        @param request: QueryGroupMemberRequest
        @param headers: QueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryGroupMember',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_member_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupMemberRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询指定群成员
        
        @param request: QueryGroupMemberRequest
        @param headers: QueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryGroupMember',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_member(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupMemberRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询指定群成员
        
        @param request: QueryGroupMemberRequest
        @return: QueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupMemberHeaders()
        return self.query_group_member_with_options(request, headers, runtime)

    async def query_group_member_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupMemberRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询指定群成员
        
        @param request: QueryGroupMemberRequest
        @return: QueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupMemberHeaders()
        return await self.query_group_member_with_options_async(request, headers, runtime)

    def query_group_set_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupSetResponse:
        """
        @summary 查询服务群群组信息
        
        @param request: QueryGroupSetRequest
        @param headers: QueryGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupSetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def query_group_set_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupSetResponse:
        """
        @summary 查询服务群群组信息
        
        @param request: QueryGroupSetRequest
        @param headers: QueryGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupSetResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='QueryGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groupSets',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_group_set(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupSetResponse:
        """
        @summary 查询服务群群组信息
        
        @param request: QueryGroupSetRequest
        @return: QueryGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupSetHeaders()
        return self.query_group_set_with_options(request, headers, runtime)

    async def query_group_set_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupSetResponse:
        """
        @summary 查询服务群群组信息
        
        @param request: QueryGroupSetRequest
        @return: QueryGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupSetHeaders()
        return await self.query_group_set_with_options_async(request, headers, runtime)

    def query_instances_by_multi_conditions_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsRequest,
        headers: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse:
        """
        @summary 服务群通过多添件进行组合检索表单数据实例集合
        
        @param request: QueryInstancesByMultiConditionsRequest
        @param headers: QueryInstancesByMultiConditionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInstancesByMultiConditionsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_fields):
            body['searchFields'] = request.search_fields
        if not UtilClient.is_unset(request.sort_fields):
            body['sortFields'] = request.sort_fields
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryInstancesByMultiConditions',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_instances_by_multi_conditions_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsRequest,
        headers: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse:
        """
        @summary 服务群通过多添件进行组合检索表单数据实例集合
        
        @param request: QueryInstancesByMultiConditionsRequest
        @param headers: QueryInstancesByMultiConditionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInstancesByMultiConditionsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_fields):
            body['searchFields'] = request.search_fields
        if not UtilClient.is_unset(request.sort_fields):
            body['sortFields'] = request.sort_fields
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryInstancesByMultiConditions',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_instances_by_multi_conditions(
        self,
        request: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsRequest,
    ) -> dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse:
        """
        @summary 服务群通过多添件进行组合检索表单数据实例集合
        
        @param request: QueryInstancesByMultiConditionsRequest
        @return: QueryInstancesByMultiConditionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsHeaders()
        return self.query_instances_by_multi_conditions_with_options(request, headers, runtime)

    async def query_instances_by_multi_conditions_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsRequest,
    ) -> dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsResponse:
        """
        @summary 服务群通过多添件进行组合检索表单数据实例集合
        
        @param request: QueryInstancesByMultiConditionsRequest
        @return: QueryInstancesByMultiConditionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryInstancesByMultiConditionsHeaders()
        return await self.query_instances_by_multi_conditions_with_options_async(request, headers, runtime)

    def query_send_msg_task_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse:
        """
        @summary 群发任务统计查询
        
        @param request: QuerySendMsgTaskStatisticsRequest
        @param headers: QuerySendMsgTaskStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySendMsgTaskStatisticsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QuerySendMsgTaskStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_send_msg_task_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse:
        """
        @summary 群发任务统计查询
        
        @param request: QuerySendMsgTaskStatisticsRequest
        @param headers: QuerySendMsgTaskStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySendMsgTaskStatisticsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QuerySendMsgTaskStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_send_msg_task_statistics(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse:
        """
        @summary 群发任务统计查询
        
        @param request: QuerySendMsgTaskStatisticsRequest
        @return: QuerySendMsgTaskStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsHeaders()
        return self.query_send_msg_task_statistics_with_options(request, headers, runtime)

    async def query_send_msg_task_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsResponse:
        """
        @summary 群发任务统计查询
        
        @param request: QuerySendMsgTaskStatisticsRequest
        @return: QuerySendMsgTaskStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsHeaders()
        return await self.query_send_msg_task_statistics_with_options_async(request, headers, runtime)

    def query_send_msg_task_statistics_detail_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailRequest,
        headers: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse:
        """
        @summary 群发任务群维度的统计数据
        
        @param request: QuerySendMsgTaskStatisticsDetailRequest
        @param headers: QuerySendMsgTaskStatisticsDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySendMsgTaskStatisticsDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QuerySendMsgTaskStatisticsDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/statistics/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def query_send_msg_task_statistics_detail_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailRequest,
        headers: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse:
        """
        @summary 群发任务群维度的统计数据
        
        @param request: QuerySendMsgTaskStatisticsDetailRequest
        @param headers: QuerySendMsgTaskStatisticsDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySendMsgTaskStatisticsDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_batch_task_id):
            body['openBatchTaskId'] = request.open_batch_task_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QuerySendMsgTaskStatisticsDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tasks/statistics/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_send_msg_task_statistics_detail(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailRequest,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse:
        """
        @summary 群发任务群维度的统计数据
        
        @param request: QuerySendMsgTaskStatisticsDetailRequest
        @return: QuerySendMsgTaskStatisticsDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailHeaders()
        return self.query_send_msg_task_statistics_detail_with_options(request, headers, runtime)

    async def query_send_msg_task_statistics_detail_async(
        self,
        request: dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailRequest,
    ) -> dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailResponse:
        """
        @summary 群发任务群维度的统计数据
        
        @param request: QuerySendMsgTaskStatisticsDetailRequest
        @return: QuerySendMsgTaskStatisticsDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QuerySendMsgTaskStatisticsDetailHeaders()
        return await self.query_send_msg_task_statistics_detail_with_options_async(request, headers, runtime)

    def query_service_group_message_read_status_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
        headers: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        """
        @summary 查消息的已读/未读列表
        
        @param request: QueryServiceGroupMessageReadStatusRequest
        @param headers: QueryServiceGroupMessageReadStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryServiceGroupMessageReadStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_task_id):
            body['openMsgTaskId'] = request.open_msg_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryServiceGroupMessageReadStatus',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/readStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_service_group_message_read_status_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
        headers: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        """
        @summary 查消息的已读/未读列表
        
        @param request: QueryServiceGroupMessageReadStatusRequest
        @param headers: QueryServiceGroupMessageReadStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryServiceGroupMessageReadStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_task_id):
            body['openMsgTaskId'] = request.open_msg_task_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueryServiceGroupMessageReadStatus',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/readStatus/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_service_group_message_read_status(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        """
        @summary 查消息的已读/未读列表
        
        @param request: QueryServiceGroupMessageReadStatusRequest
        @return: QueryServiceGroupMessageReadStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders()
        return self.query_service_group_message_read_status_with_options(request, headers, runtime)

    async def query_service_group_message_read_status_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        """
        @summary 查消息的已读/未读列表
        
        @param request: QueryServiceGroupMessageReadStatusRequest
        @return: QueryServiceGroupMessageReadStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders()
        return await self.query_service_group_message_read_status_with_options_async(request, headers, runtime)

    def queue_notify_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueueNotifyRequest,
        headers: dingtalkservice_group__1__0_models.QueueNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueueNotifyResponse:
        """
        @summary 外部DT工作台排队通知回调
        
        @param request: QueueNotifyRequest
        @param headers: QueueNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueueNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.estimate_wait_min):
            body['estimateWaitMin'] = request.estimate_wait_min
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.queue_place):
            body['queuePlace'] = request.queue_place
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.target_channel):
            body['targetChannel'] = request.target_channel
        if not UtilClient.is_unset(request.tips):
            body['tips'] = request.tips
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueueNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/dts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueueNotifyResponse(),
            self.execute(params, req, runtime)
        )

    async def queue_notify_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueueNotifyRequest,
        headers: dingtalkservice_group__1__0_models.QueueNotifyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueueNotifyResponse:
        """
        @summary 外部DT工作台排队通知回调
        
        @param request: QueueNotifyRequest
        @param headers: QueueNotifyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueueNotifyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.estimate_wait_min):
            body['estimateWaitMin'] = request.estimate_wait_min
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.queue_place):
            body['queuePlace'] = request.queue_place
        if not UtilClient.is_unset(request.service_token):
            body['serviceToken'] = request.service_token
        if not UtilClient.is_unset(request.target_channel):
            body['targetChannel'] = request.target_channel
        if not UtilClient.is_unset(request.tips):
            body['tips'] = request.tips
        if not UtilClient.is_unset(request.visitor_token):
            body['visitorToken'] = request.visitor_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='QueueNotify',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/dts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueueNotifyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def queue_notify(
        self,
        request: dingtalkservice_group__1__0_models.QueueNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.QueueNotifyResponse:
        """
        @summary 外部DT工作台排队通知回调
        
        @param request: QueueNotifyRequest
        @return: QueueNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueueNotifyHeaders()
        return self.queue_notify_with_options(request, headers, runtime)

    async def queue_notify_async(
        self,
        request: dingtalkservice_group__1__0_models.QueueNotifyRequest,
    ) -> dingtalkservice_group__1__0_models.QueueNotifyResponse:
        """
        @summary 外部DT工作台排队通知回调
        
        @param request: QueueNotifyRequest
        @return: QueueNotifyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueueNotifyHeaders()
        return await self.queue_notify_with_options_async(request, headers, runtime)

    def remove_contact_from_org_with_options(
        self,
        request: dingtalkservice_group__1__0_models.RemoveContactFromOrgRequest,
        headers: dingtalkservice_group__1__0_models.RemoveContactFromOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse:
        """
        @summary 组织剔除联系人
        
        @param request: RemoveContactFromOrgRequest
        @param headers: RemoveContactFromOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveContactFromOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_union_id):
            body['contactUnionId'] = request.contact_union_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveContactFromOrg',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/organizations/contacts/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_contact_from_org_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.RemoveContactFromOrgRequest,
        headers: dingtalkservice_group__1__0_models.RemoveContactFromOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse:
        """
        @summary 组织剔除联系人
        
        @param request: RemoveContactFromOrgRequest
        @param headers: RemoveContactFromOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveContactFromOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.contact_union_id):
            body['contactUnionId'] = request.contact_union_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RemoveContactFromOrg',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/organizations/contacts/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_contact_from_org(
        self,
        request: dingtalkservice_group__1__0_models.RemoveContactFromOrgRequest,
    ) -> dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse:
        """
        @summary 组织剔除联系人
        
        @param request: RemoveContactFromOrgRequest
        @return: RemoveContactFromOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RemoveContactFromOrgHeaders()
        return self.remove_contact_from_org_with_options(request, headers, runtime)

    async def remove_contact_from_org_async(
        self,
        request: dingtalkservice_group__1__0_models.RemoveContactFromOrgRequest,
    ) -> dingtalkservice_group__1__0_models.RemoveContactFromOrgResponse:
        """
        @summary 组织剔除联系人
        
        @param request: RemoveContactFromOrgRequest
        @return: RemoveContactFromOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RemoveContactFromOrgHeaders()
        return await self.remove_contact_from_org_with_options_async(request, headers, runtime)

    def report_customer_detail_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerDetailRequest,
        headers: dingtalkservice_group__1__0_models.ReportCustomerDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerDetailResponse:
        """
        @summary 指定群的客户活跃明细查询
        
        @param request: ReportCustomerDetailRequest
        @param headers: ReportCustomerDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportCustomerDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.has_login):
            body['hasLogin'] = request.has_login
        if not UtilClient.is_unset(request.has_open_conv):
            body['hasOpenConv'] = request.has_open_conv
        if not UtilClient.is_unset(request.max_dt):
            body['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            body['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReportCustomerDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/activities/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ReportCustomerDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def report_customer_detail_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerDetailRequest,
        headers: dingtalkservice_group__1__0_models.ReportCustomerDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerDetailResponse:
        """
        @summary 指定群的客户活跃明细查询
        
        @param request: ReportCustomerDetailRequest
        @param headers: ReportCustomerDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportCustomerDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.has_login):
            body['hasLogin'] = request.has_login
        if not UtilClient.is_unset(request.has_open_conv):
            body['hasOpenConv'] = request.has_open_conv
        if not UtilClient.is_unset(request.max_dt):
            body['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            body['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReportCustomerDetail',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/activities/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ReportCustomerDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_customer_detail(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerDetailRequest,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerDetailResponse:
        """
        @summary 指定群的客户活跃明细查询
        
        @param request: ReportCustomerDetailRequest
        @return: ReportCustomerDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ReportCustomerDetailHeaders()
        return self.report_customer_detail_with_options(request, headers, runtime)

    async def report_customer_detail_async(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerDetailRequest,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerDetailResponse:
        """
        @summary 指定群的客户活跃明细查询
        
        @param request: ReportCustomerDetailRequest
        @return: ReportCustomerDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ReportCustomerDetailHeaders()
        return await self.report_customer_detail_with_options_async(request, headers, runtime)

    def report_customer_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.ReportCustomerStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse:
        """
        @summary 客户活跃明细指标查询
        
        @param request: ReportCustomerStatisticsRequest
        @param headers: ReportCustomerStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportCustomerStatisticsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_owner_user_ids):
            body['groupOwnerUserIds'] = request.group_owner_user_ids
        if not UtilClient.is_unset(request.group_tags):
            body['groupTags'] = request.group_tags
        if not UtilClient.is_unset(request.max_dt):
            body['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            body['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReportCustomerStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/activities/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def report_customer_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.ReportCustomerStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse:
        """
        @summary 客户活跃明细指标查询
        
        @param request: ReportCustomerStatisticsRequest
        @param headers: ReportCustomerStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReportCustomerStatisticsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_owner_user_ids):
            body['groupOwnerUserIds'] = request.group_owner_user_ids
        if not UtilClient.is_unset(request.group_tags):
            body['groupTags'] = request.group_tags
        if not UtilClient.is_unset(request.max_dt):
            body['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            body['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ReportCustomerStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/activities/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def report_customer_statistics(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse:
        """
        @summary 客户活跃明细指标查询
        
        @param request: ReportCustomerStatisticsRequest
        @return: ReportCustomerStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ReportCustomerStatisticsHeaders()
        return self.report_customer_statistics_with_options(request, headers, runtime)

    async def report_customer_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.ReportCustomerStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.ReportCustomerStatisticsResponse:
        """
        @summary 客户活跃明细指标查询
        
        @param request: ReportCustomerStatisticsRequest
        @return: ReportCustomerStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ReportCustomerStatisticsHeaders()
        return await self.report_customer_statistics_with_options_async(request, headers, runtime)

    def resubmit_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ResubmitTicketRequest,
        headers: dingtalkservice_group__1__0_models.ResubmitTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ResubmitTicketResponse:
        """
        @summary 重新提交工单
        
        @param request: ResubmitTicketRequest
        @param headers: ResubmitTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ResubmitTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ResubmitTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/resubmit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ResubmitTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def resubmit_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ResubmitTicketRequest,
        headers: dingtalkservice_group__1__0_models.ResubmitTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ResubmitTicketResponse:
        """
        @summary 重新提交工单
        
        @param request: ResubmitTicketRequest
        @param headers: ResubmitTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ResubmitTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ResubmitTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/resubmit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ResubmitTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def resubmit_ticket(
        self,
        request: dingtalkservice_group__1__0_models.ResubmitTicketRequest,
    ) -> dingtalkservice_group__1__0_models.ResubmitTicketResponse:
        """
        @summary 重新提交工单
        
        @param request: ResubmitTicketRequest
        @return: ResubmitTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ResubmitTicketHeaders()
        return self.resubmit_ticket_with_options(request, headers, runtime)

    async def resubmit_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.ResubmitTicketRequest,
    ) -> dingtalkservice_group__1__0_models.ResubmitTicketResponse:
        """
        @summary 重新提交工单
        
        @param request: ResubmitTicketRequest
        @return: ResubmitTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ResubmitTicketHeaders()
        return await self.resubmit_ticket_with_options_async(request, headers, runtime)

    def retract_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.RetractTicketRequest,
        headers: dingtalkservice_group__1__0_models.RetractTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RetractTicketResponse:
        """
        @summary 撤回工单
        
        @param request: RetractTicketRequest
        @param headers: RetractTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetractTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RetractTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/retract',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RetractTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def retract_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.RetractTicketRequest,
        headers: dingtalkservice_group__1__0_models.RetractTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RetractTicketResponse:
        """
        @summary 撤回工单
        
        @param request: RetractTicketRequest
        @param headers: RetractTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RetractTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RetractTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/retract',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RetractTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def retract_ticket(
        self,
        request: dingtalkservice_group__1__0_models.RetractTicketRequest,
    ) -> dingtalkservice_group__1__0_models.RetractTicketResponse:
        """
        @summary 撤回工单
        
        @param request: RetractTicketRequest
        @return: RetractTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RetractTicketHeaders()
        return self.retract_ticket_with_options(request, headers, runtime)

    async def retract_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.RetractTicketRequest,
    ) -> dingtalkservice_group__1__0_models.RetractTicketResponse:
        """
        @summary 撤回工单
        
        @param request: RetractTicketRequest
        @return: RetractTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RetractTicketHeaders()
        return await self.retract_ticket_with_options_async(request, headers, runtime)

    def robot_message_recall_with_options(
        self,
        request: dingtalkservice_group__1__0_models.RobotMessageRecallRequest,
        headers: dingtalkservice_group__1__0_models.RobotMessageRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RobotMessageRecallResponse:
        """
        @summary 指定群的机器人消息撤回
        
        @param request: RobotMessageRecallRequest
        @param headers: RobotMessageRecallHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RobotMessageRecallResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_id):
            body['openMsgId'] = request.open_msg_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RobotMessageRecall',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/robots/messages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RobotMessageRecallResponse(),
            self.execute(params, req, runtime)
        )

    async def robot_message_recall_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.RobotMessageRecallRequest,
        headers: dingtalkservice_group__1__0_models.RobotMessageRecallHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.RobotMessageRecallResponse:
        """
        @summary 指定群的机器人消息撤回
        
        @param request: RobotMessageRecallRequest
        @param headers: RobotMessageRecallHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RobotMessageRecallResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_id):
            body['openMsgId'] = request.open_msg_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RobotMessageRecall',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/robots/messages/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.RobotMessageRecallResponse(),
            await self.execute_async(params, req, runtime)
        )

    def robot_message_recall(
        self,
        request: dingtalkservice_group__1__0_models.RobotMessageRecallRequest,
    ) -> dingtalkservice_group__1__0_models.RobotMessageRecallResponse:
        """
        @summary 指定群的机器人消息撤回
        
        @param request: RobotMessageRecallRequest
        @return: RobotMessageRecallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RobotMessageRecallHeaders()
        return self.robot_message_recall_with_options(request, headers, runtime)

    async def robot_message_recall_async(
        self,
        request: dingtalkservice_group__1__0_models.RobotMessageRecallRequest,
    ) -> dingtalkservice_group__1__0_models.RobotMessageRecallResponse:
        """
        @summary 指定群的机器人消息撤回
        
        @param request: RobotMessageRecallRequest
        @return: RobotMessageRecallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.RobotMessageRecallHeaders()
        return await self.robot_message_recall_with_options_async(request, headers, runtime)

    def save_form_instance_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SaveFormInstanceRequest,
        headers: dingtalkservice_group__1__0_models.SaveFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SaveFormInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: SaveFormInstanceRequest
        @param headers: SaveFormInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveFormInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SaveFormInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def save_form_instance_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SaveFormInstanceRequest,
        headers: dingtalkservice_group__1__0_models.SaveFormInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SaveFormInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: SaveFormInstanceRequest
        @param headers: SaveFormInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveFormInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveFormInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/forms/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SaveFormInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_form_instance(
        self,
        request: dingtalkservice_group__1__0_models.SaveFormInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.SaveFormInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: SaveFormInstanceRequest
        @return: SaveFormInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SaveFormInstanceHeaders()
        return self.save_form_instance_with_options(request, headers, runtime)

    async def save_form_instance_async(
        self,
        request: dingtalkservice_group__1__0_models.SaveFormInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.SaveFormInstanceResponse:
        """
        @summary 服务群新增表单实例
        
        @param request: SaveFormInstanceRequest
        @return: SaveFormInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SaveFormInstanceHeaders()
        return await self.save_form_instance_with_options_async(request, headers, runtime)

    def search_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
        headers: dingtalkservice_group__1__0_models.SearchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        """
        @summary 搜索服务群
        
        @param request: SearchGroupRequest
        @param headers: SearchGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_type):
            body['searchType'] = request.search_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SearchGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SearchGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def search_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
        headers: dingtalkservice_group__1__0_models.SearchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        """
        @summary 搜索服务群
        
        @param request: SearchGroupRequest
        @param headers: SearchGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_type):
            body['searchType'] = request.search_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SearchGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SearchGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_group(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        """
        @summary 搜索服务群
        
        @param request: SearchGroupRequest
        @return: SearchGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SearchGroupHeaders()
        return self.search_group_with_options(request, headers, runtime)

    async def search_group_async(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        """
        @summary 搜索服务群
        
        @param request: SearchGroupRequest
        @return: SearchGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SearchGroupHeaders()
        return await self.search_group_with_options_async(request, headers, runtime)

    def send_msg_by_task_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskRequest,
        headers: dingtalkservice_group__1__0_models.SendMsgByTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskResponse:
        """
        @summary 服务群发任务
        
        @param request: SendMsgByTaskRequest
        @param headers: SendMsgByTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgByTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.query_group):
            body['queryGroup'] = request.query_group
        if not UtilClient.is_unset(request.send_config):
            body['sendConfig'] = request.send_config
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMsgByTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/tasks/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendMsgByTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def send_msg_by_task_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskRequest,
        headers: dingtalkservice_group__1__0_models.SendMsgByTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskResponse:
        """
        @summary 服务群发任务
        
        @param request: SendMsgByTaskRequest
        @param headers: SendMsgByTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgByTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.query_group):
            body['queryGroup'] = request.query_group
        if not UtilClient.is_unset(request.send_config):
            body['sendConfig'] = request.send_config
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMsgByTask',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/tasks/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendMsgByTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_msg_by_task(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskRequest,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskResponse:
        """
        @summary 服务群发任务
        
        @param request: SendMsgByTaskRequest
        @return: SendMsgByTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendMsgByTaskHeaders()
        return self.send_msg_by_task_with_options(request, headers, runtime)

    async def send_msg_by_task_async(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskRequest,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskResponse:
        """
        @summary 服务群发任务
        
        @param request: SendMsgByTaskRequest
        @return: SendMsgByTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendMsgByTaskHeaders()
        return await self.send_msg_by_task_with_options_async(request, headers, runtime)

    def send_msg_by_task_support_invite_join_org_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgRequest,
        headers: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse:
        """
        @summary 增强版客户群发
        
        @param request: SendMsgByTaskSupportInviteJoinOrgRequest
        @param headers: SendMsgByTaskSupportInviteJoinOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgByTaskSupportInviteJoinOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.mobile_phones):
            body['mobilePhones'] = request.mobile_phones
        if not UtilClient.is_unset(request.need_url_track):
            body['needUrlTrack'] = request.need_url_track
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.send_channel):
            body['sendChannel'] = request.send_channel
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMsgByTaskSupportInviteJoinOrg',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/groupSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def send_msg_by_task_support_invite_join_org_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgRequest,
        headers: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse:
        """
        @summary 增强版客户群发
        
        @param request: SendMsgByTaskSupportInviteJoinOrgRequest
        @param headers: SendMsgByTaskSupportInviteJoinOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMsgByTaskSupportInviteJoinOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message_content):
            body['messageContent'] = request.message_content
        if not UtilClient.is_unset(request.mobile_phones):
            body['mobilePhones'] = request.mobile_phones
        if not UtilClient.is_unset(request.need_url_track):
            body['needUrlTrack'] = request.need_url_track
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.send_channel):
            body['sendChannel'] = request.send_channel
        if not UtilClient.is_unset(request.task_name):
            body['taskName'] = request.task_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendMsgByTaskSupportInviteJoinOrg',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customers/tasks/groupSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_msg_by_task_support_invite_join_org(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgRequest,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse:
        """
        @summary 增强版客户群发
        
        @param request: SendMsgByTaskSupportInviteJoinOrgRequest
        @return: SendMsgByTaskSupportInviteJoinOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgHeaders()
        return self.send_msg_by_task_support_invite_join_org_with_options(request, headers, runtime)

    async def send_msg_by_task_support_invite_join_org_async(
        self,
        request: dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgRequest,
    ) -> dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgResponse:
        """
        @summary 增强版客户群发
        
        @param request: SendMsgByTaskSupportInviteJoinOrgRequest
        @return: SendMsgByTaskSupportInviteJoinOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendMsgByTaskSupportInviteJoinOrgHeaders()
        return await self.send_msg_by_task_support_invite_join_org_with_options_async(request, headers, runtime)

    def send_service_group_message_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
        headers: dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        """
        @summary 服务群发消息
        
        @param request: SendServiceGroupMessageRequest
        @param headers: SendServiceGroupMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendServiceGroupMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_dingtalk_ids):
            body['atDingtalkIds'] = request.at_dingtalk_ids
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.btn_orientation):
            body['btnOrientation'] = request.btn_orientation
        if not UtilClient.is_unset(request.btns):
            body['btns'] = request.btns
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.has_content_links):
            body['hasContentLinks'] = request.has_content_links
        if not UtilClient.is_unset(request.is_at_all):
            body['isAtAll'] = request.is_at_all
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.receiver_dingtalk_ids):
            body['receiverDingtalkIds'] = request.receiver_dingtalk_ids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendServiceGroupMessage',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_service_group_message_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
        headers: dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        """
        @summary 服务群发消息
        
        @param request: SendServiceGroupMessageRequest
        @param headers: SendServiceGroupMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendServiceGroupMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_dingtalk_ids):
            body['atDingtalkIds'] = request.at_dingtalk_ids
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.btn_orientation):
            body['btnOrientation'] = request.btn_orientation
        if not UtilClient.is_unset(request.btns):
            body['btns'] = request.btns
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.has_content_links):
            body['hasContentLinks'] = request.has_content_links
        if not UtilClient.is_unset(request.is_at_all):
            body['isAtAll'] = request.is_at_all
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.receiver_dingtalk_ids):
            body['receiverDingtalkIds'] = request.receiver_dingtalk_ids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendServiceGroupMessage',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_service_group_message(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        """
        @summary 服务群发消息
        
        @param request: SendServiceGroupMessageRequest
        @return: SendServiceGroupMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders()
        return self.send_service_group_message_with_options(request, headers, runtime)

    async def send_service_group_message_async(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        """
        @summary 服务群发消息
        
        @param request: SendServiceGroupMessageRequest
        @return: SendServiceGroupMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders()
        return await self.send_service_group_message_with_options_async(request, headers, runtime)

    def set_robot_config_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SetRobotConfigRequest,
        headers: dingtalkservice_group__1__0_models.SetRobotConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SetRobotConfigResponse:
        """
        @summary 执行阿里内部用户群组机器人服务开关
        
        @param request: SetRobotConfigRequest
        @param headers: SetRobotConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRobotConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRobotConfig',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/configs/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SetRobotConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def set_robot_config_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SetRobotConfigRequest,
        headers: dingtalkservice_group__1__0_models.SetRobotConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SetRobotConfigResponse:
        """
        @summary 执行阿里内部用户群组机器人服务开关
        
        @param request: SetRobotConfigRequest
        @param headers: SetRobotConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRobotConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetRobotConfig',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/configs/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SetRobotConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_robot_config(
        self,
        request: dingtalkservice_group__1__0_models.SetRobotConfigRequest,
    ) -> dingtalkservice_group__1__0_models.SetRobotConfigResponse:
        """
        @summary 执行阿里内部用户群组机器人服务开关
        
        @param request: SetRobotConfigRequest
        @return: SetRobotConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SetRobotConfigHeaders()
        return self.set_robot_config_with_options(request, headers, runtime)

    async def set_robot_config_async(
        self,
        request: dingtalkservice_group__1__0_models.SetRobotConfigRequest,
    ) -> dingtalkservice_group__1__0_models.SetRobotConfigResponse:
        """
        @summary 执行阿里内部用户群组机器人服务开关
        
        @param request: SetRobotConfigRequest
        @return: SetRobotConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SetRobotConfigHeaders()
        return await self.set_robot_config_with_options_async(request, headers, runtime)

    def take_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
        headers: dingtalkservice_group__1__0_models.TakeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        """
        @summary 申领工单
        
        @param request: TakeTicketRequest
        @param headers: TakeTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TakeTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.taker_union_id):
            body['takerUnionId'] = request.taker_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TakeTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/apply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TakeTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def take_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
        headers: dingtalkservice_group__1__0_models.TakeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        """
        @summary 申领工单
        
        @param request: TakeTicketRequest
        @param headers: TakeTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TakeTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.taker_union_id):
            body['takerUnionId'] = request.taker_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TakeTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/apply',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TakeTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def take_ticket(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        """
        @summary 申领工单
        
        @param request: TakeTicketRequest
        @return: TakeTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TakeTicketHeaders()
        return self.take_ticket_with_options(request, headers, runtime)

    async def take_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        """
        @summary 申领工单
        
        @param request: TakeTicketRequest
        @return: TakeTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TakeTicketHeaders()
        return await self.take_ticket_with_options_async(request, headers, runtime)

    def topic_statistics_with_options(
        self,
        request: dingtalkservice_group__1__0_models.TopicStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.TopicStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TopicStatisticsResponse:
        """
        @summary 客户心声热门话题统计
        
        @param request: TopicStatisticsRequest
        @param headers: TopicStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopicStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_ids):
            query['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_content):
            query['searchContent'] = request.search_content
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='TopicStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/topics/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TopicStatisticsResponse(),
            self.execute(params, req, runtime)
        )

    async def topic_statistics_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.TopicStatisticsRequest,
        headers: dingtalkservice_group__1__0_models.TopicStatisticsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TopicStatisticsResponse:
        """
        @summary 客户心声热门话题统计
        
        @param request: TopicStatisticsRequest
        @param headers: TopicStatisticsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopicStatisticsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_dt):
            query['maxDt'] = request.max_dt
        if not UtilClient.is_unset(request.min_dt):
            query['minDt'] = request.min_dt
        if not UtilClient.is_unset(request.open_conversation_ids):
            query['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.search_content):
            query['searchContent'] = request.search_content
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='TopicStatistics',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/voices/topics/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TopicStatisticsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def topic_statistics(
        self,
        request: dingtalkservice_group__1__0_models.TopicStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.TopicStatisticsResponse:
        """
        @summary 客户心声热门话题统计
        
        @param request: TopicStatisticsRequest
        @return: TopicStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TopicStatisticsHeaders()
        return self.topic_statistics_with_options(request, headers, runtime)

    async def topic_statistics_async(
        self,
        request: dingtalkservice_group__1__0_models.TopicStatisticsRequest,
    ) -> dingtalkservice_group__1__0_models.TopicStatisticsResponse:
        """
        @summary 客户心声热门话题统计
        
        @param request: TopicStatisticsRequest
        @return: TopicStatisticsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TopicStatisticsHeaders()
        return await self.topic_statistics_with_options_async(request, headers, runtime)

    def transfer_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
        headers: dingtalkservice_group__1__0_models.TransferTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        """
        @summary 转交工单
        
        @param request: TransferTicketRequest
        @param headers: TransferTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TransferTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TransferTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def transfer_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
        headers: dingtalkservice_group__1__0_models.TransferTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        """
        @summary 转交工单
        
        @param request: TransferTicketRequest
        @param headers: TransferTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TransferTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TransferTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def transfer_ticket(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        """
        @summary 转交工单
        
        @param request: TransferTicketRequest
        @return: TransferTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TransferTicketHeaders()
        return self.transfer_ticket_with_options(request, headers, runtime)

    async def transfer_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        """
        @summary 转交工单
        
        @param request: TransferTicketRequest
        @return: TransferTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TransferTicketHeaders()
        return await self.transfer_ticket_with_options_async(request, headers, runtime)

    def update_group_set_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.UpdateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupSetResponse:
        """
        @summary 变更群的群组配置信息
        
        @param request: UpdateGroupSetRequest
        @param headers: UpdateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/configurations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateGroupSetResponse(),
            self.execute(params, req, runtime)
        )

    async def update_group_set_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupSetRequest,
        headers: dingtalkservice_group__1__0_models.UpdateGroupSetHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupSetResponse:
        """
        @summary 变更群的群组配置信息
        
        @param request: UpdateGroupSetRequest
        @param headers: UpdateGroupSetHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSetResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupSet',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/groups/configurations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateGroupSetResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_group_set(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupSetResponse:
        """
        @summary 变更群的群组配置信息
        
        @param request: UpdateGroupSetRequest
        @return: UpdateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateGroupSetHeaders()
        return self.update_group_set_with_options(request, headers, runtime)

    async def update_group_set_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupSetRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupSetResponse:
        """
        @summary 变更群的群组配置信息
        
        @param request: UpdateGroupSetRequest
        @return: UpdateGroupSetResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateGroupSetHeaders()
        return await self.update_group_set_with_options_async(request, headers, runtime)

    def update_group_tag_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupTagRequest,
        headers: dingtalkservice_group__1__0_models.UpdateGroupTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupTagResponse:
        """
        @summary 更新服务群标签
        
        @param request: UpdateGroupTagRequest
        @param headers: UpdateGroupTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.tag_names):
            body['tagNames'] = request.tag_names
        if not UtilClient.is_unset(request.update_type):
            body['updateType'] = request.update_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupTag',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tags',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateGroupTagResponse(),
            self.execute(params, req, runtime)
        )

    async def update_group_tag_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupTagRequest,
        headers: dingtalkservice_group__1__0_models.UpdateGroupTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupTagResponse:
        """
        @summary 更新服务群标签
        
        @param request: UpdateGroupTagRequest
        @param headers: UpdateGroupTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        if not UtilClient.is_unset(request.tag_names):
            body['tagNames'] = request.tag_names
        if not UtilClient.is_unset(request.update_type):
            body['updateType'] = request.update_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateGroupTag',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tags',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateGroupTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_group_tag(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupTagRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupTagResponse:
        """
        @summary 更新服务群标签
        
        @param request: UpdateGroupTagRequest
        @return: UpdateGroupTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateGroupTagHeaders()
        return self.update_group_tag_with_options(request, headers, runtime)

    async def update_group_tag_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateGroupTagRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateGroupTagResponse:
        """
        @summary 更新服务群标签
        
        @param request: UpdateGroupTagRequest
        @return: UpdateGroupTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateGroupTagHeaders()
        return await self.update_group_tag_with_options_async(request, headers, runtime)

    def update_instance_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpdateInstanceRequest,
        headers: dingtalkservice_group__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateInstanceResponse:
        """
        @summary 服务群更新表单实例
        
        @param request: UpdateInstanceRequest
        @param headers: UpdateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.external_biz_id):
            body['externalBizId'] = request.external_biz_id
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_data_instance_id):
            body['openDataInstanceId'] = request.open_data_instance_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def update_instance_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateInstanceRequest,
        headers: dingtalkservice_group__1__0_models.UpdateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateInstanceResponse:
        """
        @summary 服务群更新表单实例
        
        @param request: UpdateInstanceRequest
        @param headers: UpdateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.external_biz_id):
            body['externalBizId'] = request.external_biz_id
        if not UtilClient.is_unset(request.form_code):
            body['formCode'] = request.form_code
        if not UtilClient.is_unset(request.form_data_list):
            body['formDataList'] = request.form_data_list
        if not UtilClient.is_unset(request.open_data_instance_id):
            body['openDataInstanceId'] = request.open_data_instance_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.owner_union_id):
            body['ownerUnionId'] = request.owner_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateInstance',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/customForms/instances',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_instance(
        self,
        request: dingtalkservice_group__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateInstanceResponse:
        """
        @summary 服务群更新表单实例
        
        @param request: UpdateInstanceRequest
        @return: UpdateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateInstanceHeaders()
        return self.update_instance_with_options(request, headers, runtime)

    async def update_instance_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateInstanceRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateInstanceResponse:
        """
        @summary 服务群更新表单实例
        
        @param request: UpdateInstanceRequest
        @return: UpdateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateInstanceHeaders()
        return await self.update_instance_with_options_async(request, headers, runtime)

    def update_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
        headers: dingtalkservice_group__1__0_models.UpdateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        """
        @summary 更新工单自定义字段
        
        @param request: UpdateTicketRequest
        @param headers: UpdateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def update_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
        headers: dingtalkservice_group__1__0_models.UpdateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        """
        @summary 更新工单自定义字段
        
        @param request: UpdateTicketRequest
        @param headers: UpdateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_ticket(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        """
        @summary 更新工单自定义字段
        
        @param request: UpdateTicketRequest
        @return: UpdateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateTicketHeaders()
        return self.update_ticket_with_options(request, headers, runtime)

    async def update_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        """
        @summary 更新工单自定义字段
        
        @param request: UpdateTicketRequest
        @return: UpdateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateTicketHeaders()
        return await self.update_ticket_with_options_async(request, headers, runtime)

    def upgrade_cloud_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeCloudGroupRequest,
        headers: dingtalkservice_group__1__0_models.UpgradeCloudGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse:
        """
        @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
        
        @param request: UpgradeCloudGroupRequest
        @param headers: UpgradeCloudGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeCloudGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ccs_instance_id):
            body['ccsInstanceId'] = request.ccs_instance_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpgradeCloudGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/cloudGroups/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def upgrade_cloud_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeCloudGroupRequest,
        headers: dingtalkservice_group__1__0_models.UpgradeCloudGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse:
        """
        @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
        
        @param request: UpgradeCloudGroupRequest
        @param headers: UpgradeCloudGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeCloudGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ccs_instance_id):
            body['ccsInstanceId'] = request.ccs_instance_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpgradeCloudGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/cloudGroups/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upgrade_cloud_group(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeCloudGroupRequest,
    ) -> dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse:
        """
        @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
        
        @param request: UpgradeCloudGroupRequest
        @return: UpgradeCloudGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpgradeCloudGroupHeaders()
        return self.upgrade_cloud_group_with_options(request, headers, runtime)

    async def upgrade_cloud_group_async(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeCloudGroupRequest,
    ) -> dingtalkservice_group__1__0_models.UpgradeCloudGroupResponse:
        """
        @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
        
        @param request: UpgradeCloudGroupRequest
        @return: UpgradeCloudGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpgradeCloudGroupHeaders()
        return await self.upgrade_cloud_group_with_options_async(request, headers, runtime)

    def upgrade_normal_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeNormalGroupRequest,
        headers: dingtalkservice_group__1__0_models.UpgradeNormalGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse:
        """
        @summary 将常规钉群升级为钉钉智能服务群
        
        @param request: UpgradeNormalGroupRequest
        @param headers: UpgradeNormalGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeNormalGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpgradeNormalGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/normalGroups/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def upgrade_normal_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeNormalGroupRequest,
        headers: dingtalkservice_group__1__0_models.UpgradeNormalGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse:
        """
        @summary 将常规钉群升级为钉钉智能服务群
        
        @param request: UpgradeNormalGroupRequest
        @param headers: UpgradeNormalGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpgradeNormalGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpgradeNormalGroup',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/normalGroups/upgrade',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def upgrade_normal_group(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeNormalGroupRequest,
    ) -> dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse:
        """
        @summary 将常规钉群升级为钉钉智能服务群
        
        @param request: UpgradeNormalGroupRequest
        @return: UpgradeNormalGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpgradeNormalGroupHeaders()
        return self.upgrade_normal_group_with_options(request, headers, runtime)

    async def upgrade_normal_group_async(
        self,
        request: dingtalkservice_group__1__0_models.UpgradeNormalGroupRequest,
    ) -> dingtalkservice_group__1__0_models.UpgradeNormalGroupResponse:
        """
        @summary 将常规钉群升级为钉钉智能服务群
        
        @param request: UpgradeNormalGroupRequest
        @return: UpgradeNormalGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpgradeNormalGroupHeaders()
        return await self.upgrade_normal_group_with_options_async(request, headers, runtime)

    def urge_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
        headers: dingtalkservice_group__1__0_models.UrgeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        """
        @summary 工单催办
        
        @param request: UrgeTicketRequest
        @param headers: UrgeTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UrgeTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UrgeTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/urge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UrgeTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def urge_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
        headers: dingtalkservice_group__1__0_models.UrgeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        """
        @summary 工单催办
        
        @param request: UrgeTicketRequest
        @param headers: UrgeTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UrgeTicketResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UrgeTicket',
            version='serviceGroup_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/serviceGroup/tickets/urge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UrgeTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def urge_ticket(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        """
        @summary 工单催办
        
        @param request: UrgeTicketRequest
        @return: UrgeTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UrgeTicketHeaders()
        return self.urge_ticket_with_options(request, headers, runtime)

    async def urge_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        """
        @summary 工单催办
        
        @param request: UrgeTicketRequest
        @return: UrgeTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UrgeTicketHeaders()
        return await self.urge_ticket_with_options_async(request, headers, runtime)
