# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def delete_knowledge(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders()
        return self.delete_knowledge_with_options(request, headers, runtime)

    async def delete_knowledge_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders()
        return await self.delete_knowledge_with_options_async(request, headers, runtime)

    def delete_knowledge_with_options(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteKnowledgeResponse(),
            self.do_roarequest('DeleteKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/knowledges/batchDelete', 'json', req, runtime)
        )

    async def delete_knowledge_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.DeleteKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.DeleteKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.DeleteKnowledgeResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.DeleteKnowledgeResponse(),
            await self.do_roarequest_async('DeleteKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/knowledges/batchDelete', 'json', req, runtime)
        )

    def create_ticket(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTicketHeaders()
        return self.create_ticket_with_options(request, headers, runtime)

    async def create_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateTicketHeaders()
        return await self.create_ticket_with_options_async(request, headers, runtime)

    def create_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
        headers: dingtalkservice_group__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTicketResponse(),
            self.do_roarequest('CreateTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets', 'json', req, runtime)
        )

    async def create_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateTicketRequest,
        headers: dingtalkservice_group__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.creator_union_id):
            body['creatorUnionId'] = request.creator_union_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.scene_context):
            body['sceneContext'] = request.scene_context
        if not UtilClient.is_unset(request.open_template_biz_id):
            body['openTemplateBizId'] = request.open_template_biz_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateTicketResponse(),
            await self.do_roarequest_async('CreateTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets', 'json', req, runtime)
        )

    def assign_ticket(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AssignTicketHeaders()
        return self.assign_ticket_with_options(request, headers, runtime)

    async def assign_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AssignTicketHeaders()
        return await self.assign_ticket_with_options_async(request, headers, runtime)

    def assign_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
        headers: dingtalkservice_group__1__0_models.AssignTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
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
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AssignTicketResponse(),
            self.do_roarequest('AssignTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/assign', 'none', req, runtime)
        )

    async def assign_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AssignTicketRequest,
        headers: dingtalkservice_group__1__0_models.AssignTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AssignTicketResponse:
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
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AssignTicketResponse(),
            await self.do_roarequest_async('AssignTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/assign', 'none', req, runtime)
        )

    def finish_ticket(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.FinishTicketHeaders()
        return self.finish_ticket_with_options(request, headers, runtime)

    async def finish_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.FinishTicketHeaders()
        return await self.finish_ticket_with_options_async(request, headers, runtime)

    def finish_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
        headers: dingtalkservice_group__1__0_models.FinishTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.FinishTicketResponse(),
            self.do_roarequest('FinishTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/finish', 'none', req, runtime)
        )

    async def finish_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.FinishTicketRequest,
        headers: dingtalkservice_group__1__0_models.FinishTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.FinishTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.FinishTicketResponse(),
            await self.do_roarequest_async('FinishTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/finish', 'none', req, runtime)
        )

    def search_group(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SearchGroupHeaders()
        return self.search_group_with_options(request, headers, runtime)

    async def search_group_async(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SearchGroupHeaders()
        return await self.search_group_with_options_async(request, headers, runtime)

    def search_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
        headers: dingtalkservice_group__1__0_models.SearchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
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
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SearchGroupResponse(),
            self.do_roarequest('SearchGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups/search', 'json', req, runtime)
        )

    async def search_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SearchGroupRequest,
        headers: dingtalkservice_group__1__0_models.SearchGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SearchGroupResponse:
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
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SearchGroupResponse(),
            await self.do_roarequest_async('SearchGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups/search', 'json', req, runtime)
        )

    def update_ticket(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateTicketHeaders()
        return self.update_ticket_with_options(request, headers, runtime)

    async def update_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UpdateTicketHeaders()
        return await self.update_ticket_with_options_async(request, headers, runtime)

    def update_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
        headers: dingtalkservice_group__1__0_models.UpdateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateTicketResponse(),
            self.do_roarequest('UpdateTicket', 'serviceGroup_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/serviceGroup/tickets', 'none', req, runtime)
        )

    async def update_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UpdateTicketRequest,
        headers: dingtalkservice_group__1__0_models.UpdateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UpdateTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.custom_fields):
            body['customFields'] = request.custom_fields
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UpdateTicketResponse(),
            await self.do_roarequest_async('UpdateTicket', 'serviceGroup_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/serviceGroup/tickets', 'none', req, runtime)
        )

    def create_group(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupHeaders()
        return self.create_group_with_options(request, headers, runtime)

    async def create_group_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CreateGroupHeaders()
        return await self.create_group_with_options_async(request, headers, runtime)

    def create_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_biz_id):
            body['groupBizId'] = request.group_biz_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.owner_staff_id):
            body['ownerStaffId'] = request.owner_staff_id
        if not UtilClient.is_unset(request.member_staff_ids):
            body['memberStaffIds'] = request.member_staff_ids
        if not UtilClient.is_unset(request.group_tag_names):
            body['groupTagNames'] = request.group_tag_names
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupResponse(),
            self.do_roarequest('CreateGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups', 'json', req, runtime)
        )

    async def create_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CreateGroupRequest,
        headers: dingtalkservice_group__1__0_models.CreateGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CreateGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_biz_id):
            body['groupBizId'] = request.group_biz_id
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.owner_staff_id):
            body['ownerStaffId'] = request.owner_staff_id
        if not UtilClient.is_unset(request.member_staff_ids):
            body['memberStaffIds'] = request.member_staff_ids
        if not UtilClient.is_unset(request.group_tag_names):
            body['groupTagNames'] = request.group_tag_names
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CreateGroupResponse(),
            await self.do_roarequest_async('CreateGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups', 'json', req, runtime)
        )

    def transfer_ticket(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TransferTicketHeaders()
        return self.transfer_ticket_with_options(request, headers, runtime)

    async def transfer_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TransferTicketHeaders()
        return await self.transfer_ticket_with_options_async(request, headers, runtime)

    def transfer_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
        headers: dingtalkservice_group__1__0_models.TransferTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TransferTicketResponse(),
            self.do_roarequest('TransferTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/transfer', 'none', req, runtime)
        )

    async def transfer_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.TransferTicketRequest,
        headers: dingtalkservice_group__1__0_models.TransferTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TransferTicketResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.processor_union_ids):
            body['processorUnionIds'] = request.processor_union_ids
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TransferTicketResponse(),
            await self.do_roarequest_async('TransferTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/transfer', 'none', req, runtime)
        )

    def add_knowledge(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddKnowledgeHeaders()
        return self.add_knowledge_with_options(request, headers, runtime)

    async def add_knowledge_async(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddKnowledgeHeaders()
        return await self.add_knowledge_with_options_async(request, headers, runtime)

    def add_knowledge_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.link_url):
            body['linkUrl'] = request.link_url
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddKnowledgeResponse(),
            self.do_roarequest('AddKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/knowledges', 'json', req, runtime)
        )

    async def add_knowledge_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddKnowledgeRequest,
        headers: dingtalkservice_group__1__0_models.AddKnowledgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddKnowledgeResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.library_key):
            body['libraryKey'] = request.library_key
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.link_url):
            body['linkUrl'] = request.link_url
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddKnowledgeResponse(),
            await self.do_roarequest_async('AddKnowledge', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/knowledges', 'json', req, runtime)
        )

    def batch_get_group_set_config(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders()
        return self.batch_get_group_set_config_with_options(request, headers, runtime)

    async def batch_get_group_set_config_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders()
        return await self.batch_get_group_set_config_with_options_async(request, headers, runtime)

    def batch_get_group_set_config_with_options(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
        headers: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.config_keys):
            body['configKeys'] = request.config_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse(),
            self.do_roarequest('BatchGetGroupSetConfig', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groupSetConfigs/batchQuery', 'json', req, runtime)
        )

    async def batch_get_group_set_config_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigRequest,
        headers: dingtalkservice_group__1__0_models.BatchGetGroupSetConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_group_set_id):
            body['openGroupSetId'] = request.open_group_set_id
        if not UtilClient.is_unset(request.config_keys):
            body['configKeys'] = request.config_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.BatchGetGroupSetConfigResponse(),
            await self.do_roarequest_async('BatchGetGroupSetConfig', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groupSetConfigs/batchQuery', 'json', req, runtime)
        )

    def list_ticket_operate_record(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders()
        return self.list_ticket_operate_record_with_options(request, headers, runtime)

    async def list_ticket_operate_record_async(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders()
        return await self.list_ticket_operate_record_with_options_async(request, headers, runtime)

    def list_ticket_operate_record_with_options(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
        headers: dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse(),
            self.do_roarequest('ListTicketOperateRecord', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/tickets/operateRecords', 'json', req, runtime)
        )

    async def list_ticket_operate_record_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.ListTicketOperateRecordRequest,
        headers: dingtalkservice_group__1__0_models.ListTicketOperateRecordHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListTicketOperateRecordResponse(),
            await self.do_roarequest_async('ListTicketOperateRecord', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/tickets/operateRecords', 'json', req, runtime)
        )

    def query_service_group_message_read_status(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders()
        return self.query_service_group_message_read_status_with_options(request, headers, runtime)

    async def query_service_group_message_read_status_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders()
        return await self.query_service_group_message_read_status_with_options_async(request, headers, runtime)

    def query_service_group_message_read_status_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
        headers: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_task_id):
            body['openMsgTaskId'] = request.open_msg_task_id
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse(),
            self.do_roarequest('QueryServiceGroupMessageReadStatus', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/messages/readStatus/query', 'json', req, runtime)
        )

    async def query_service_group_message_read_status_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusRequest,
        headers: dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_task_id):
            body['openMsgTaskId'] = request.open_msg_task_id
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryServiceGroupMessageReadStatusResponse(),
            await self.do_roarequest_async('QueryServiceGroupMessageReadStatus', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/messages/readStatus/query', 'json', req, runtime)
        )

    def add_library(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddLibraryHeaders()
        return self.add_library_with_options(request, headers, runtime)

    async def add_library_async(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddLibraryHeaders()
        return await self.add_library_with_options_async(request, headers, runtime)

    def add_library_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.open_team_ids):
            body['openTeamIds'] = request.open_team_ids
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddLibraryResponse(),
            self.do_roarequest('AddLibrary', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/librarys', 'json', req, runtime)
        )

    async def add_library_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddLibraryRequest,
        headers: dingtalkservice_group__1__0_models.AddLibraryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddLibraryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.open_team_ids):
            body['openTeamIds'] = request.open_team_ids
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.source_primary_key):
            body['sourcePrimaryKey'] = request.source_primary_key
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddLibraryResponse(),
            await self.do_roarequest_async('AddLibrary', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/librarys', 'json', req, runtime)
        )

    def query_group(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupHeaders()
        return self.query_group_with_options(request, headers, runtime)

    async def query_group_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.QueryGroupHeaders()
        return await self.query_group_with_options_async(request, headers, runtime)

    def query_group_with_options(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupResponse(),
            self.do_roarequest('QueryGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups/query', 'json', req, runtime)
        )

    async def query_group_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.QueryGroupRequest,
        headers: dingtalkservice_group__1__0_models.QueryGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.QueryGroupResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.biz_id):
            body['bizId'] = request.biz_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.QueryGroupResponse(),
            await self.do_roarequest_async('QueryGroup', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/groups/query', 'json', req, runtime)
        )

    def close_human_session(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseHumanSessionHeaders()
        return self.close_human_session_with_options(request, headers, runtime)

    async def close_human_session_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.CloseHumanSessionHeaders()
        return await self.close_human_session_with_options_async(request, headers, runtime)

    def close_human_session_with_options(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
        headers: dingtalkservice_group__1__0_models.CloseHumanSessionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.visitor_union_id):
            body['visitorUnionId'] = request.visitor_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseHumanSessionResponse(),
            self.do_roarequest('CloseHumanSession', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/humanSessions/close', 'json', req, runtime)
        )

    async def close_human_session_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.CloseHumanSessionRequest,
        headers: dingtalkservice_group__1__0_models.CloseHumanSessionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.CloseHumanSessionResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.visitor_union_id):
            body['visitorUnionId'] = request.visitor_union_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.CloseHumanSessionResponse(),
            await self.do_roarequest_async('CloseHumanSession', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/humanSessions/close', 'json', req, runtime)
        )

    def urge_ticket(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UrgeTicketHeaders()
        return self.urge_ticket_with_options(request, headers, runtime)

    async def urge_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.UrgeTicketHeaders()
        return await self.urge_ticket_with_options_async(request, headers, runtime)

    def urge_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
        headers: dingtalkservice_group__1__0_models.UrgeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
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
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UrgeTicketResponse(),
            self.do_roarequest('UrgeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/urge', 'none', req, runtime)
        )

    async def urge_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.UrgeTicketRequest,
        headers: dingtalkservice_group__1__0_models.UrgeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.UrgeTicketResponse:
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
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.UrgeTicketResponse(),
            await self.do_roarequest_async('UrgeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/urge', 'none', req, runtime)
        )

    def get_ticket(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetTicketHeaders()
        return self.get_ticket_with_options(request, headers, runtime)

    async def get_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetTicketHeaders()
        return await self.get_ticket_with_options_async(request, headers, runtime)

    def get_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
        headers: dingtalkservice_group__1__0_models.GetTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetTicketResponse(),
            self.do_roarequest('GetTicket', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/tickets', 'json', req, runtime)
        )

    async def get_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetTicketRequest,
        headers: dingtalkservice_group__1__0_models.GetTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetTicketResponse:
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
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetTicketResponse(),
            await self.do_roarequest_async('GetTicket', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/tickets', 'json', req, runtime)
        )

    def get_oss_temp_url(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetOssTempUrlHeaders()
        return self.get_oss_temp_url_with_options(request, headers, runtime)

    async def get_oss_temp_url_async(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetOssTempUrlHeaders()
        return await self.get_oss_temp_url_with_options_async(request, headers, runtime)

    def get_oss_temp_url_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
        headers: dingtalkservice_group__1__0_models.GetOssTempUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.key):
            query['key'] = request.key
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.fetch_mode):
            query['fetchMode'] = request.fetch_mode
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetOssTempUrlResponse(),
            self.do_roarequest('GetOssTempUrl', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/ossServices/tempUrls', 'json', req, runtime)
        )

    async def get_oss_temp_url_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetOssTempUrlRequest,
        headers: dingtalkservice_group__1__0_models.GetOssTempUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetOssTempUrlResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_team_id):
            query['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.key):
            query['key'] = request.key
        if not UtilClient.is_unset(request.file_name):
            query['fileName'] = request.file_name
        if not UtilClient.is_unset(request.fetch_mode):
            query['fetchMode'] = request.fetch_mode
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetOssTempUrlResponse(),
            await self.do_roarequest_async('GetOssTempUrl', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/ossServices/tempUrls', 'json', req, runtime)
        )

    def take_ticket(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TakeTicketHeaders()
        return self.take_ticket_with_options(request, headers, runtime)

    async def take_ticket_async(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.TakeTicketHeaders()
        return await self.take_ticket_with_options_async(request, headers, runtime)

    def take_ticket_with_options(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
        headers: dingtalkservice_group__1__0_models.TakeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.taker_union_id):
            body['takerUnionId'] = request.taker_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TakeTicketResponse(),
            self.do_roarequest('TakeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/apply', 'none', req, runtime)
        )

    async def take_ticket_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.TakeTicketRequest,
        headers: dingtalkservice_group__1__0_models.TakeTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.TakeTicketResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.taker_union_id):
            body['takerUnionId'] = request.taker_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.TakeTicketResponse(),
            await self.do_roarequest_async('TakeTicket', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/apply', 'none', req, runtime)
        )

    def send_service_group_message(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders()
        return self.send_service_group_message_with_options(request, headers, runtime)

    async def send_service_group_message_async(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders()
        return await self.send_service_group_message_with_options_async(request, headers, runtime)

    def send_service_group_message_with_options(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
        headers: dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.is_at_all):
            body['isAtAll'] = request.is_at_all
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_dingtalk_ids):
            body['atDingtalkIds'] = request.at_dingtalk_ids
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_dingtalk_ids):
            body['receiverDingtalkIds'] = request.receiver_dingtalk_ids
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.btn_orientation):
            body['btnOrientation'] = request.btn_orientation
        if not UtilClient.is_unset(request.btns):
            body['btns'] = request.btns
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse(),
            self.do_roarequest('SendServiceGroupMessage', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/messages/send', 'json', req, runtime)
        )

    async def send_service_group_message_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.SendServiceGroupMessageRequest,
        headers: dingtalkservice_group__1__0_models.SendServiceGroupMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_isv_org_id):
            body['dingIsvOrgId'] = request.ding_isv_org_id
        if not UtilClient.is_unset(request.ding_org_id):
            body['dingOrgId'] = request.ding_org_id
        if not UtilClient.is_unset(request.ding_token_grant_type):
            body['dingTokenGrantType'] = request.ding_token_grant_type
        if not UtilClient.is_unset(request.ding_suite_key):
            body['dingSuiteKey'] = request.ding_suite_key
        if not UtilClient.is_unset(request.target_open_conversation_id):
            body['targetOpenConversationId'] = request.target_open_conversation_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.is_at_all):
            body['isAtAll'] = request.is_at_all
        if not UtilClient.is_unset(request.at_mobiles):
            body['atMobiles'] = request.at_mobiles
        if not UtilClient.is_unset(request.at_dingtalk_ids):
            body['atDingtalkIds'] = request.at_dingtalk_ids
        if not UtilClient.is_unset(request.at_union_ids):
            body['atUnionIds'] = request.at_union_ids
        if not UtilClient.is_unset(request.receiver_mobiles):
            body['receiverMobiles'] = request.receiver_mobiles
        if not UtilClient.is_unset(request.receiver_dingtalk_ids):
            body['receiverDingtalkIds'] = request.receiver_dingtalk_ids
        if not UtilClient.is_unset(request.receiver_union_ids):
            body['receiverUnionIds'] = request.receiver_union_ids
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.btn_orientation):
            body['btnOrientation'] = request.btn_orientation
        if not UtilClient.is_unset(request.btns):
            body['btns'] = request.btns
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.SendServiceGroupMessageResponse(),
            await self.do_roarequest_async('SendServiceGroupMessage', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/messages/send', 'json', req, runtime)
        )

    def get_storage_policy(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetStoragePolicyHeaders()
        return self.get_storage_policy_with_options(request, headers, runtime)

    async def get_storage_policy_async(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.GetStoragePolicyHeaders()
        return await self.get_storage_policy_with_options_async(request, headers, runtime)

    def get_storage_policy_with_options(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
        headers: dingtalkservice_group__1__0_models.GetStoragePolicyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetStoragePolicyResponse(),
            self.do_roarequest('GetStoragePolicy', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/ossServices/policies', 'json', req, runtime)
        )

    async def get_storage_policy_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.GetStoragePolicyRequest,
        headers: dingtalkservice_group__1__0_models.GetStoragePolicyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.GetStoragePolicyResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.biz_type):
            body['bizType'] = request.biz_type
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.GetStoragePolicyResponse(),
            await self.do_roarequest_async('GetStoragePolicy', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/ossServices/policies', 'json', req, runtime)
        )

    def list_user_teams(
        self,
        user_id: str,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListUserTeamsHeaders()
        return self.list_user_teams_with_options(user_id, headers, runtime)

    async def list_user_teams_async(
        self,
        user_id: str,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.ListUserTeamsHeaders()
        return await self.list_user_teams_with_options_async(user_id, headers, runtime)

    def list_user_teams_with_options(
        self,
        user_id: str,
        headers: dingtalkservice_group__1__0_models.ListUserTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListUserTeamsResponse(),
            self.do_roarequest('ListUserTeams', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/users/{user_id}/teams', 'json', req, runtime)
        )

    async def list_user_teams_with_options_async(
        self,
        user_id: str,
        headers: dingtalkservice_group__1__0_models.ListUserTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.ListUserTeamsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.ListUserTeamsResponse(),
            await self.do_roarequest_async('ListUserTeams', 'serviceGroup_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/serviceGroup/users/{user_id}/teams', 'json', req, runtime)
        )

    def add_ticket_memo(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddTicketMemoHeaders()
        return self.add_ticket_memo_with_options(request, headers, runtime)

    async def add_ticket_memo_async(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkservice_group__1__0_models.AddTicketMemoHeaders()
        return await self.add_ticket_memo_with_options_async(request, headers, runtime)

    def add_ticket_memo_with_options(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
        headers: dingtalkservice_group__1__0_models.AddTicketMemoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddTicketMemoResponse(),
            self.do_roarequest('AddTicketMemo', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/memos', 'none', req, runtime)
        )

    async def add_ticket_memo_with_options_async(
        self,
        request: dingtalkservice_group__1__0_models.AddTicketMemoRequest,
        headers: dingtalkservice_group__1__0_models.AddTicketMemoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkservice_group__1__0_models.AddTicketMemoResponse:
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
        if not UtilClient.is_unset(request.open_team_id):
            body['openTeamId'] = request.open_team_id
        if not UtilClient.is_unset(request.processor_union_id):
            body['processorUnionId'] = request.processor_union_id
        if not UtilClient.is_unset(request.open_ticket_id):
            body['openTicketId'] = request.open_ticket_id
        if not UtilClient.is_unset(request.ticket_memo):
            body['ticketMemo'] = request.ticket_memo
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkservice_group__1__0_models.AddTicketMemoResponse(),
            await self.do_roarequest_async('AddTicketMemo', 'serviceGroup_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/serviceGroup/tickets/memos', 'none', req, runtime)
        )
