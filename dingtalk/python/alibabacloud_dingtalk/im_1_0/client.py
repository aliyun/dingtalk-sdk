# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.im_1_0 import models as dingtalkim__1__0_models
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

    def auto_open_ding_talk_connect(self) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return self.auto_open_ding_talk_connect_with_options(headers, runtime)

    async def auto_open_ding_talk_connect_async(self) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return await self.auto_open_ding_talk_connect_with_options_async(headers, runtime)

    def auto_open_ding_talk_connect_with_options(
        self,
        headers: dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse(),
            self.do_roarequest('AutoOpenDingTalkConnect', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/apps/open', 'json', req, runtime)
        )

    async def auto_open_ding_talk_connect_with_options_async(
        self,
        headers: dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse(),
            await self.do_roarequest_async('AutoOpenDingTalkConnect', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/apps/open', 'json', req, runtime)
        )

    def batch_query_group_member(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryGroupMemberHeaders()
        return self.batch_query_group_member_with_options(request, headers, runtime)

    async def batch_query_group_member_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryGroupMemberHeaders()
        return await self.batch_query_group_member_with_options_async(request, headers, runtime)

    def batch_query_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.BatchQueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryGroupMemberResponse(),
            self.do_roarequest('BatchQueryGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/members/batchQuery', 'json', req, runtime)
        )

    async def batch_query_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.BatchQueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryGroupMemberResponse(),
            await self.do_roarequest_async('BatchQueryGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/members/batchQuery', 'json', req, runtime)
        )

    def card_template_build_action(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CardTemplateBuildActionHeaders()
        return self.card_template_build_action_with_options(request, headers, runtime)

    async def card_template_build_action_async(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CardTemplateBuildActionHeaders()
        return await self.card_template_build_action_with_options_async(request, headers, runtime)

    def card_template_build_action_with_options(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
        headers: dingtalkim__1__0_models.CardTemplateBuildActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.card_template_json):
            body['cardTemplateJson'] = request.card_template_json
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CardTemplateBuildActionResponse(),
            self.do_roarequest('CardTemplateBuildAction', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/templates/buildAction', 'json', req, runtime)
        )

    async def card_template_build_action_with_options_async(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
        headers: dingtalkim__1__0_models.CardTemplateBuildActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action):
            body['action'] = request.action
        if not UtilClient.is_unset(request.card_template_json):
            body['cardTemplateJson'] = request.card_template_json
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CardTemplateBuildActionResponse(),
            await self.do_roarequest_async('CardTemplateBuildAction', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/templates/buildAction', 'json', req, runtime)
        )

    def change_group_owner(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChangeGroupOwnerHeaders()
        return self.change_group_owner_with_options(request, headers, runtime)

    async def change_group_owner_async(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChangeGroupOwnerHeaders()
        return await self.change_group_owner_with_options_async(request, headers, runtime)

    def change_group_owner_with_options(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
        headers: dingtalkim__1__0_models.ChangeGroupOwnerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_owner_type):
            body['groupOwnerType'] = request.group_owner_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChangeGroupOwnerResponse(),
            self.do_roarequest('ChangeGroupOwner', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/owners', 'json', req, runtime)
        )

    async def change_group_owner_with_options_async(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
        headers: dingtalkim__1__0_models.ChangeGroupOwnerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_owner_type):
            body['groupOwnerType'] = request.group_owner_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChangeGroupOwnerResponse(),
            await self.do_roarequest_async('ChangeGroupOwner', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/owners', 'json', req, runtime)
        )

    def chat_id_to_open_conversation_id(
        self,
        chat_id: str,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders()
        return self.chat_id_to_open_conversation_id_with_options(chat_id, headers, runtime)

    async def chat_id_to_open_conversation_id_async(
        self,
        chat_id: str,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders()
        return await self.chat_id_to_open_conversation_id_with_options_async(chat_id, headers, runtime)

    def chat_id_to_open_conversation_id_with_options(
        self,
        chat_id: str,
        headers: dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        chat_id = OpenApiUtilClient.get_encode_param(chat_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse(),
            self.do_roarequest('ChatIdToOpenConversationId', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/chat/{chat_id}/convertToOpenConversationId', 'json', req, runtime)
        )

    async def chat_id_to_open_conversation_id_with_options_async(
        self,
        chat_id: str,
        headers: dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        chat_id = OpenApiUtilClient.get_encode_param(chat_id)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse(),
            await self.do_roarequest_async('ChatIdToOpenConversationId', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/chat/{chat_id}/convertToOpenConversationId', 'json', req, runtime)
        )

    def chat_sub_admin_update(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatSubAdminUpdateHeaders()
        return self.chat_sub_admin_update_with_options(request, headers, runtime)

    async def chat_sub_admin_update_async(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatSubAdminUpdateHeaders()
        return await self.chat_sub_admin_update_with_options_async(request, headers, runtime)

    def chat_sub_admin_update_with_options(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
        headers: dingtalkim__1__0_models.ChatSubAdminUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatSubAdminUpdateResponse(),
            self.do_roarequest('ChatSubAdminUpdate', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/subAdministrators', 'json', req, runtime)
        )

    async def chat_sub_admin_update_with_options_async(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
        headers: dingtalkim__1__0_models.ChatSubAdminUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatSubAdminUpdateResponse(),
            await self.do_roarequest_async('ChatSubAdminUpdate', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/subAdministrators', 'json', req, runtime)
        )

    def create_couple_group_conversation(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders()
        return self.create_couple_group_conversation_with_options(request, headers, runtime)

    async def create_couple_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders()
        return await self.create_couple_group_conversation_with_options_async(request, headers, runtime)

    def create_couple_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateCoupleGroupConversationResponse(),
            self.do_roarequest('CreateCoupleGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/coupleGroups', 'json', req, runtime)
        )

    async def create_couple_group_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateCoupleGroupConversationResponse(),
            await self.do_roarequest_async('CreateCoupleGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/coupleGroups', 'json', req, runtime)
        )

    def create_group_conversation(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateGroupConversationHeaders()
        return self.create_group_conversation_with_options(request, headers, runtime)

    async def create_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateGroupConversationHeaders()
        return await self.create_group_conversation_with_options_async(request, headers, runtime)

    def create_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_owner_type):
            body['groupOwnerType'] = request.group_owner_type
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateGroupConversationResponse(),
            self.do_roarequest('CreateGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups', 'json', req, runtime)
        )

    async def create_group_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.group_owner_type):
            body['groupOwnerType'] = request.group_owner_type
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateGroupConversationResponse(),
            await self.do_roarequest_async('CreateGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups', 'json', req, runtime)
        )

    def create_interconnection(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateInterconnectionHeaders()
        return self.create_interconnection_with_options(request, headers, runtime)

    async def create_interconnection_async(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateInterconnectionHeaders()
        return await self.create_interconnection_with_options_async(request, headers, runtime)

    def create_interconnection_with_options(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
        headers: dingtalkim__1__0_models.CreateInterconnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.interconnections):
            body['interconnections'] = request.interconnections
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateInterconnectionResponse(),
            self.do_roarequest('CreateInterconnection', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections', 'json', req, runtime)
        )

    async def create_interconnection_with_options_async(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
        headers: dingtalkim__1__0_models.CreateInterconnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.interconnections):
            body['interconnections'] = request.interconnections
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateInterconnectionResponse(),
            await self.do_roarequest_async('CreateInterconnection', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections', 'json', req, runtime)
        )

    def create_scene_group_conversation(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateSceneGroupConversationHeaders()
        return self.create_scene_group_conversation_with_options(request, headers, runtime)

    async def create_scene_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateSceneGroupConversationHeaders()
        return await self.create_scene_group_conversation_with_options_async(request, headers, runtime)

    def create_scene_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateSceneGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.features):
            body['features'] = request.features
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.management_options):
            body['managementOptions'] = request.management_options
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateSceneGroupConversationResponse(),
            self.do_roarequest('CreateSceneGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups', 'json', req, runtime)
        )

    async def create_scene_group_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateSceneGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.features):
            body['features'] = request.features
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner_id):
            body['groupOwnerId'] = request.group_owner_id
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.management_options):
            body['managementOptions'] = request.management_options
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        if not UtilClient.is_unset(request.uuid):
            body['uuid'] = request.uuid
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateSceneGroupConversationResponse(),
            await self.do_roarequest_async('CreateSceneGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups', 'json', req, runtime)
        )

    def create_store_group_conversation(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateStoreGroupConversationHeaders()
        return self.create_store_group_conversation_with_options(request, headers, runtime)

    async def create_store_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateStoreGroupConversationHeaders()
        return await self.create_store_group_conversation_with_options_async(request, headers, runtime)

    def create_store_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateStoreGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.business_unique_key):
            body['businessUniqueKey'] = request.business_unique_key
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateStoreGroupConversationResponse(),
            self.do_roarequest('CreateStoreGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/storeGroups', 'json', req, runtime)
        )

    async def create_store_group_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateStoreGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.business_unique_key):
            body['businessUniqueKey'] = request.business_unique_key
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateStoreGroupConversationResponse(),
            await self.do_roarequest_async('CreateStoreGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/storeGroups', 'json', req, runtime)
        )

    def dismiss_group_conversation(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DismissGroupConversationHeaders()
        return self.dismiss_group_conversation_with_options(request, headers, runtime)

    async def dismiss_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DismissGroupConversationHeaders()
        return await self.dismiss_group_conversation_with_options_async(request, headers, runtime)

    def dismiss_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
        headers: dingtalkim__1__0_models.DismissGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DismissGroupConversationResponse(),
            self.do_roarequest('DismissGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/dismiss', 'json', req, runtime)
        )

    async def dismiss_group_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
        headers: dingtalkim__1__0_models.DismissGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DismissGroupConversationResponse(),
            await self.do_roarequest_async('DismissGroupConversation', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/dismiss', 'json', req, runtime)
        )

    def get_conversation_url(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetConversationUrlHeaders()
        return self.get_conversation_url_with_options(request, headers, runtime)

    async def get_conversation_url_async(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetConversationUrlHeaders()
        return await self.get_conversation_url_with_options_async(request, headers, runtime)

    def get_conversation_url_with_options(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
        headers: dingtalkim__1__0_models.GetConversationUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.channel_code):
            body['channelCode'] = request.channel_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.source_code):
            body['sourceCode'] = request.source_code
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetConversationUrlResponse(),
            self.do_roarequest('GetConversationUrl', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/conversations/urls', 'json', req, runtime)
        )

    async def get_conversation_url_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
        headers: dingtalkim__1__0_models.GetConversationUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.channel_code):
            body['channelCode'] = request.channel_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.source_code):
            body['sourceCode'] = request.source_code
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetConversationUrlResponse(),
            await self.do_roarequest_async('GetConversationUrl', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/conversations/urls', 'json', req, runtime)
        )

    def get_interconnection_url(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInterconnectionUrlHeaders()
        return self.get_interconnection_url_with_options(request, headers, runtime)

    async def get_interconnection_url_async(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInterconnectionUrlHeaders()
        return await self.get_interconnection_url_with_options_async(request, headers, runtime)

    def get_interconnection_url_with_options(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
        headers: dingtalkim__1__0_models.GetInterconnectionUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_avatar):
            body['appUserAvatar'] = request.app_user_avatar
        if not UtilClient.is_unset(request.app_user_avatar_type):
            body['appUserAvatarType'] = request.app_user_avatar_type
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.app_user_mobile_number):
            body['appUserMobileNumber'] = request.app_user_mobile_number
        if not UtilClient.is_unset(request.app_user_name):
            body['appUserName'] = request.app_user_name
        if not UtilClient.is_unset(request.msg_page_type):
            body['msgPageType'] = request.msg_page_type
        if not UtilClient.is_unset(request.qr_code):
            body['qrCode'] = request.qr_code
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.source_code):
            body['sourceCode'] = request.source_code
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInterconnectionUrlResponse(),
            self.do_roarequest('GetInterconnectionUrl', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/sessions/urls', 'json', req, runtime)
        )

    async def get_interconnection_url_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
        headers: dingtalkim__1__0_models.GetInterconnectionUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_avatar):
            body['appUserAvatar'] = request.app_user_avatar
        if not UtilClient.is_unset(request.app_user_avatar_type):
            body['appUserAvatarType'] = request.app_user_avatar_type
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.app_user_mobile_number):
            body['appUserMobileNumber'] = request.app_user_mobile_number
        if not UtilClient.is_unset(request.app_user_name):
            body['appUserName'] = request.app_user_name
        if not UtilClient.is_unset(request.msg_page_type):
            body['msgPageType'] = request.msg_page_type
        if not UtilClient.is_unset(request.qr_code):
            body['qrCode'] = request.qr_code
        if not UtilClient.is_unset(request.signature):
            body['signature'] = request.signature
        if not UtilClient.is_unset(request.source_code):
            body['sourceCode'] = request.source_code
        if not UtilClient.is_unset(request.source_type):
            body['sourceType'] = request.source_type
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInterconnectionUrlResponse(),
            await self.do_roarequest_async('GetInterconnectionUrl', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/sessions/urls', 'json', req, runtime)
        )

    def get_scene_group_info(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupInfoHeaders()
        return self.get_scene_group_info_with_options(request, headers, runtime)

    async def get_scene_group_info_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupInfoHeaders()
        return await self.get_scene_group_info_with_options_async(request, headers, runtime)

    def get_scene_group_info_with_options(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupInfoResponse(),
            self.do_roarequest('GetSceneGroupInfo', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/query', 'json', req, runtime)
        )

    async def get_scene_group_info_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupInfoResponse(),
            await self.do_roarequest_async('GetSceneGroupInfo', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/query', 'json', req, runtime)
        )

    def get_scene_group_members(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupMembersHeaders()
        return self.get_scene_group_members_with_options(request, headers, runtime)

    async def get_scene_group_members_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupMembersHeaders()
        return await self.get_scene_group_members_with_options_async(request, headers, runtime)

    def get_scene_group_members_with_options(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupMembersResponse(),
            self.do_roarequest('GetSceneGroupMembers', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/members/query', 'json', req, runtime)
        )

    async def get_scene_group_members_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.cursor):
            body['cursor'] = request.cursor
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.size):
            body['size'] = request.size
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupMembersResponse(),
            await self.do_roarequest_async('GetSceneGroupMembers', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/members/query', 'json', req, runtime)
        )

    def group_ban_words(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupBanWordsHeaders()
        return self.group_ban_words_with_options(request, headers, runtime)

    async def group_ban_words_async(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupBanWordsHeaders()
        return await self.group_ban_words_with_options_async(request, headers, runtime)

    def group_ban_words_with_options(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
        headers: dingtalkim__1__0_models.GroupBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ban_words_mode):
            body['banWordsMode'] = request.ban_words_mode
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupBanWordsResponse(),
            self.do_roarequest('GroupBanWords', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/words/ban', 'none', req, runtime)
        )

    async def group_ban_words_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
        headers: dingtalkim__1__0_models.GroupBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ban_words_mode):
            body['banWordsMode'] = request.ban_words_mode
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupBanWordsResponse(),
            await self.do_roarequest_async('GroupBanWords', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/words/ban', 'none', req, runtime)
        )

    def group_capacity_inquiry(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityInquiryHeaders()
        return self.group_capacity_inquiry_with_options(request, headers, runtime)

    async def group_capacity_inquiry_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityInquiryHeaders()
        return await self.group_capacity_inquiry_with_options_async(request, headers, runtime)

    def group_capacity_inquiry_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
        headers: dingtalkim__1__0_models.GroupCapacityInquiryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.effective_duration):
            body['effectiveDuration'] = request.effective_duration
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        if not UtilClient.is_unset(request.target_capacity):
            body['targetCapacity'] = request.target_capacity
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityInquiryResponse(),
            self.do_roarequest('GroupCapacityInquiry', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/inquiries/query', 'json', req, runtime)
        )

    async def group_capacity_inquiry_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
        headers: dingtalkim__1__0_models.GroupCapacityInquiryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.effective_duration):
            body['effectiveDuration'] = request.effective_duration
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        if not UtilClient.is_unset(request.target_capacity):
            body['targetCapacity'] = request.target_capacity
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityInquiryResponse(),
            await self.do_roarequest_async('GroupCapacityInquiry', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/inquiries/query', 'json', req, runtime)
        )

    def group_capacity_order_confirm(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders()
        return self.group_capacity_order_confirm_with_options(request, headers, runtime)

    async def group_capacity_order_confirm_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders()
        return await self.group_capacity_order_confirm_with_options_async(request, headers, runtime)

    def group_capacity_order_confirm_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse(),
            self.do_roarequest('GroupCapacityOrderConfirm', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/orders/confirm', 'json', req, runtime)
        )

    async def group_capacity_order_confirm_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse(),
            await self.do_roarequest_async('GroupCapacityOrderConfirm', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/orders/confirm', 'json', req, runtime)
        )

    def group_capacity_order_place(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders()
        return self.group_capacity_order_place_with_options(request, headers, runtime)

    async def group_capacity_order_place_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders()
        return await self.group_capacity_order_place_with_options_async(request, headers, runtime)

    def group_capacity_order_place_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_price):
            body['actualPrice'] = request.actual_price
        if not UtilClient.is_unset(request.current_capacity):
            body['currentCapacity'] = request.current_capacity
        if not UtilClient.is_unset(request.current_effect_until):
            body['currentEffectUntil'] = request.current_effect_until
        if not UtilClient.is_unset(request.discount):
            body['discount'] = request.discount
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.marked_price):
            body['markedPrice'] = request.marked_price
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.target_capacity):
            body['targetCapacity'] = request.target_capacity
        if not UtilClient.is_unset(request.target_effect_until):
            body['targetEffectUntil'] = request.target_effect_until
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse(),
            self.do_roarequest('GroupCapacityOrderPlace', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/orders/place', 'json', req, runtime)
        )

    async def group_capacity_order_place_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.actual_price):
            body['actualPrice'] = request.actual_price
        if not UtilClient.is_unset(request.current_capacity):
            body['currentCapacity'] = request.current_capacity
        if not UtilClient.is_unset(request.current_effect_until):
            body['currentEffectUntil'] = request.current_effect_until
        if not UtilClient.is_unset(request.discount):
            body['discount'] = request.discount
        if not UtilClient.is_unset(request.ext_info):
            body['extInfo'] = request.ext_info
        if not UtilClient.is_unset(request.marked_price):
            body['markedPrice'] = request.marked_price
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator):
            body['operator'] = request.operator
        if not UtilClient.is_unset(request.target_capacity):
            body['targetCapacity'] = request.target_capacity
        if not UtilClient.is_unset(request.target_effect_until):
            body['targetEffectUntil'] = request.target_effect_until
        if not UtilClient.is_unset(request.token):
            body['token'] = request.token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse(),
            await self.do_roarequest_async('GroupCapacityOrderPlace', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/orders/place', 'json', req, runtime)
        )

    def group_manage_query(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageQueryHeaders()
        return self.group_manage_query_with_options(request, headers, runtime)

    async def group_manage_query_async(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageQueryHeaders()
        return await self.group_manage_query_with_options_async(request, headers, runtime)

    def group_manage_query_with_options(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
        headers: dingtalkim__1__0_models.GroupManageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.created_after):
            body['createdAfter'] = request.created_after
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_member_samples):
            body['groupMemberSamples'] = request.group_member_samples
        if not UtilClient.is_unset(request.group_owner):
            body['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.group_title_keywords):
            body['groupTitleKeywords'] = request.group_title_keywords
        if not UtilClient.is_unset(request.group_url):
            body['groupUrl'] = request.group_url
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.members_over):
            body['membersOver'] = request.members_over
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageQueryResponse(),
            self.do_roarequest('GroupManageQuery', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/managements/query', 'json', req, runtime)
        )

    async def group_manage_query_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
        headers: dingtalkim__1__0_models.GroupManageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.created_after):
            body['createdAfter'] = request.created_after
        if not UtilClient.is_unset(request.group_id):
            body['groupId'] = request.group_id
        if not UtilClient.is_unset(request.group_member_samples):
            body['groupMemberSamples'] = request.group_member_samples
        if not UtilClient.is_unset(request.group_owner):
            body['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.group_title_keywords):
            body['groupTitleKeywords'] = request.group_title_keywords
        if not UtilClient.is_unset(request.group_url):
            body['groupUrl'] = request.group_url
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.members_over):
            body['membersOver'] = request.members_over
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageQueryResponse(),
            await self.do_roarequest_async('GroupManageQuery', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/managements/query', 'json', req, runtime)
        )

    def group_manage_reduce(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageReduceHeaders()
        return self.group_manage_reduce_with_options(request, headers, runtime)

    async def group_manage_reduce_async(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageReduceHeaders()
        return await self.group_manage_reduce_with_options_async(request, headers, runtime)

    def group_manage_reduce_with_options(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
        headers: dingtalkim__1__0_models.GroupManageReduceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.capacity_limit):
            body['capacityLimit'] = request.capacity_limit
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageReduceResponse(),
            self.do_roarequest('GroupManageReduce', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/reduce', 'none', req, runtime)
        )

    async def group_manage_reduce_with_options_async(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
        headers: dingtalkim__1__0_models.GroupManageReduceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.capacity_limit):
            body['capacityLimit'] = request.capacity_limit
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.options):
            body['options'] = request.options
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageReduceResponse(),
            await self.do_roarequest_async('GroupManageReduce', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/groups/capacities/reduce', 'none', req, runtime)
        )

    def interactive_card_create_instance(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders()
        return self.interactive_card_create_instance_with_options(request, headers, runtime)

    async def interactive_card_create_instance_async(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders()
        return await self.interactive_card_create_instance_with_options_async(request, headers, runtime)

    def interactive_card_create_instance_with_options(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
        headers: dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse(),
            self.do_roarequest('InteractiveCardCreateInstance', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/instances', 'json', req, runtime)
        )

    async def interactive_card_create_instance_with_options_async(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
        headers: dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse(),
            await self.do_roarequest_async('InteractiveCardCreateInstance', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/instances', 'json', req, runtime)
        )

    def query_group_info_by_member_auth(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders()
        return self.query_group_info_by_member_auth_with_options(request, headers, runtime)

    async def query_group_info_by_member_auth_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders()
        return await self.query_group_info_by_member_auth_with_options_async(request, headers, runtime)

    def query_group_info_by_member_auth_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse(),
            self.do_roarequest('QueryGroupInfoByMemberAuth', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/memberAuthorizations/groups/query', 'json', req, runtime)
        )

    async def query_group_info_by_member_auth_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse(),
            await self.do_roarequest_async('QueryGroupInfoByMemberAuth', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/memberAuthorizations/groups/query', 'json', req, runtime)
        )

    def query_group_member(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberHeaders()
        return self.query_group_member_with_options(request, headers, runtime)

    async def query_group_member_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberHeaders()
        return await self.query_group_member_with_options_async(request, headers, runtime)

    def query_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberResponse(),
            self.do_roarequest('QueryGroupMember', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/interconnections/conversations/members', 'json', req, runtime)
        )

    async def query_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberResponse(),
            await self.do_roarequest_async('QueryGroupMember', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/interconnections/conversations/members', 'json', req, runtime)
        )

    def query_group_member_by_member_auth(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders()
        return self.query_group_member_by_member_auth_with_options(request, headers, runtime)

    async def query_group_member_by_member_auth_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders()
        return await self.query_group_member_by_member_auth_with_options_async(request, headers, runtime)

    def query_group_member_by_member_auth_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse(),
            self.do_roarequest('QueryGroupMemberByMemberAuth', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/memberAuthorizations/groups/members/query', 'json', req, runtime)
        )

    async def query_group_member_by_member_auth_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse(),
            await self.do_roarequest_async('QueryGroupMemberByMemberAuth', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/memberAuthorizations/groups/members/query', 'json', req, runtime)
        )

    def query_group_mute_status(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMuteStatusHeaders()
        return self.query_group_mute_status_with_options(request, headers, runtime)

    async def query_group_mute_status_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMuteStatusHeaders()
        return await self.query_group_mute_status_with_options_async(request, headers, runtime)

    def query_group_mute_status_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
        headers: dingtalkim__1__0_models.QueryGroupMuteStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMuteStatusResponse(),
            self.do_roarequest('QueryGroupMuteStatus', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/sceneGroups/muteSettings', 'json', req, runtime)
        )

    async def query_group_mute_status_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
        headers: dingtalkim__1__0_models.QueryGroupMuteStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMuteStatusResponse(),
            await self.do_roarequest_async('QueryGroupMuteStatus', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/sceneGroups/muteSettings', 'json', req, runtime)
        )

    def query_members_of_group_role(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders()
        return self.query_members_of_group_role_with_options(request, headers, runtime)

    async def query_members_of_group_role_async(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders()
        return await self.query_members_of_group_role_with_options_async(request, headers, runtime)

    def query_members_of_group_role_with_options(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
        headers: dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse(),
            self.do_roarequest('QueryMembersOfGroupRole', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/roles/members/query', 'json', req, runtime)
        )

    async def query_members_of_group_role_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
        headers: dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
        if not UtilClient.is_unset(request.timestamp):
            body['timestamp'] = request.timestamp
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse(),
            await self.do_roarequest_async('QueryMembersOfGroupRole', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/roles/members/query', 'json', req, runtime)
        )

    def query_scene_group_template_robot(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders()
        return self.query_scene_group_template_robot_with_options(request, headers, runtime)

    async def query_scene_group_template_robot_async(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders()
        return await self.query_scene_group_template_robot_with_options_async(request, headers, runtime)

    def query_scene_group_template_robot_with_options(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
        headers: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse(),
            self.do_roarequest('QuerySceneGroupTemplateRobot', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/sceneGroups/templates/robots', 'json', req, runtime)
        )

    async def query_scene_group_template_robot_with_options_async(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
        headers: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            query['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.robot_code):
            query['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse(),
            await self.do_roarequest_async('QuerySceneGroupTemplateRobot', 'im_1.0', 'HTTP', 'GET', 'AK', f'/v1.0/im/sceneGroups/templates/robots', 'json', req, runtime)
        )

    def query_single_group(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySingleGroupHeaders()
        return self.query_single_group_with_options(request, headers, runtime)

    async def query_single_group_async(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySingleGroupHeaders()
        return await self.query_single_group_with_options_async(request, headers, runtime)

    def query_single_group_with_options(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
        headers: dingtalkim__1__0_models.QuerySingleGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_members):
            body['groupMembers'] = request.group_members
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySingleGroupResponse(),
            self.do_roarequest('QuerySingleGroup', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/doubleGroups/query', 'json', req, runtime)
        )

    async def query_single_group_with_options_async(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
        headers: dingtalkim__1__0_models.QuerySingleGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_members):
            body['groupMembers'] = request.group_members
        if not UtilClient.is_unset(request.group_template_id):
            body['groupTemplateId'] = request.group_template_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySingleGroupResponse(),
            await self.do_roarequest_async('QuerySingleGroup', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/doubleGroups/query', 'json', req, runtime)
        )

    def query_un_read_message(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnReadMessageHeaders()
        return self.query_un_read_message_with_options(request, headers, runtime)

    async def query_un_read_message_async(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnReadMessageHeaders()
        return await self.query_un_read_message_with_options_async(request, headers, runtime)

    def query_un_read_message_with_options(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
        headers: dingtalkim__1__0_models.QueryUnReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnReadMessageResponse(),
            self.do_roarequest('QueryUnReadMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/unReadMsgs/query', 'json', req, runtime)
        )

    async def query_un_read_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
        headers: dingtalkim__1__0_models.QueryUnReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_id):
            body['appUserId'] = request.app_user_id
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnReadMessageResponse(),
            await self.do_roarequest_async('QueryUnReadMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/unReadMsgs/query', 'json', req, runtime)
        )

    def send_interactive_card(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return self.send_interactive_card_with_options(request, headers, runtime)

    async def send_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return await self.send_interactive_card_with_options_async(request, headers, runtime)

    def send_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_open_ids):
            body['atOpenIds'] = request.at_open_ids
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendInteractiveCardResponse(),
            self.do_roarequest('SendInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/send', 'json', req, runtime)
        )

    async def send_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_open_ids):
            body['atOpenIds'] = request.at_open_ids
        if not UtilClient.is_unset(request.callback_route_key):
            body['callbackRouteKey'] = request.callback_route_key
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.chat_bot_id):
            body['chatBotId'] = request.chat_bot_id
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendInteractiveCardResponse(),
            await self.do_roarequest_async('SendInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/send', 'json', req, runtime)
        )

    def send_robot_interactive_card(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotInteractiveCardHeaders()
        return self.send_robot_interactive_card_with_options(request, headers, runtime)

    async def send_robot_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotInteractiveCardHeaders()
        return await self.send_robot_interactive_card_with_options_async(request, headers, runtime)

    def send_robot_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.send_options):
            body['sendOptions'] = request.send_options
        if not UtilClient.is_unset(request.single_chat_receiver):
            body['singleChatReceiver'] = request.single_chat_receiver
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotInteractiveCardResponse(),
            self.do_roarequest('SendRobotInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/v1.0/robot/interactiveCards/send', 'json', req, runtime)
        )

    async def send_robot_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.pull_strategy):
            body['pullStrategy'] = request.pull_strategy
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.send_options):
            body['sendOptions'] = request.send_options
        if not UtilClient.is_unset(request.single_chat_receiver):
            body['singleChatReceiver'] = request.single_chat_receiver
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotInteractiveCardResponse(),
            await self.do_roarequest_async('SendRobotInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/v1.0/robot/interactiveCards/send', 'json', req, runtime)
        )

    def send_robot_message(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotMessageHeaders()
        return self.send_robot_message_with_options(request, headers, runtime)

    async def send_robot_message_async(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotMessageHeaders()
        return await self.send_robot_message_with_options_async(request, headers, runtime)

    def send_robot_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
        headers: dingtalkim__1__0_models.SendRobotMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_all):
            body['atAll'] = request.at_all
        if not UtilClient.is_unset(request.at_app_user_id):
            body['atAppUserId'] = request.at_app_user_id
        if not UtilClient.is_unset(request.at_ding_user_id):
            body['atDingUserId'] = request.at_ding_user_id
        if not UtilClient.is_unset(request.msg_content):
            body['msgContent'] = request.msg_content
        if not UtilClient.is_unset(request.msg_type):
            body['msgType'] = request.msg_type
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotMessageResponse(),
            self.do_roarequest('SendRobotMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/robotMessages/send', 'json', req, runtime)
        )

    async def send_robot_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
        headers: dingtalkim__1__0_models.SendRobotMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_all):
            body['atAll'] = request.at_all
        if not UtilClient.is_unset(request.at_app_user_id):
            body['atAppUserId'] = request.at_app_user_id
        if not UtilClient.is_unset(request.at_ding_user_id):
            body['atDingUserId'] = request.at_ding_user_id
        if not UtilClient.is_unset(request.msg_content):
            body['msgContent'] = request.msg_content
        if not UtilClient.is_unset(request.msg_type):
            body['msgType'] = request.msg_type
        if not UtilClient.is_unset(request.open_conversation_ids):
            body['openConversationIds'] = request.open_conversation_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotMessageResponse(),
            await self.do_roarequest_async('SendRobotMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/robotMessages/send', 'json', req, runtime)
        )

    def send_template_interactive_card(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders()
        return self.send_template_interactive_card_with_options(request, headers, runtime)

    async def send_template_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders()
        return await self.send_template_interactive_card_with_options_async(request, headers, runtime)

    def send_template_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.send_options):
            body['sendOptions'] = request.send_options
        if not UtilClient.is_unset(request.single_chat_receiver):
            body['singleChatReceiver'] = request.single_chat_receiver
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendTemplateInteractiveCardResponse(),
            self.do_roarequest('SendTemplateInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/templates/send', 'json', req, runtime)
        )

    async def send_template_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.send_options):
            body['sendOptions'] = request.send_options
        if not UtilClient.is_unset(request.single_chat_receiver):
            body['singleChatReceiver'] = request.single_chat_receiver
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendTemplateInteractiveCardResponse(),
            await self.do_roarequest_async('SendTemplateInteractiveCard', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interactiveCards/templates/send', 'json', req, runtime)
        )

    def topbox_close(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxCloseHeaders()
        return self.topbox_close_with_options(request, headers, runtime)

    async def topbox_close_async(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxCloseHeaders()
        return await self.topbox_close_with_options_async(request, headers, runtime)

    def topbox_close_with_options(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
        headers: dingtalkim__1__0_models.TopboxCloseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxCloseResponse(),
            self.do_roarequest('TopboxClose', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/topBoxes/close', 'none', req, runtime)
        )

    async def topbox_close_with_options_async(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
        headers: dingtalkim__1__0_models.TopboxCloseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxCloseResponse(),
            await self.do_roarequest_async('TopboxClose', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/topBoxes/close', 'none', req, runtime)
        )

    def topbox_open(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxOpenHeaders()
        return self.topbox_open_with_options(request, headers, runtime)

    async def topbox_open_async(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxOpenHeaders()
        return await self.topbox_open_with_options_async(request, headers, runtime)

    def topbox_open_with_options(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
        headers: dingtalkim__1__0_models.TopboxOpenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.expired_time):
            body['expiredTime'] = request.expired_time
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.platforms):
            body['platforms'] = request.platforms
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxOpenResponse(),
            self.do_roarequest('TopboxOpen', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/topBoxes/open', 'none', req, runtime)
        )

    async def topbox_open_with_options_async(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
        headers: dingtalkim__1__0_models.TopboxOpenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.conversation_type):
            body['conversationType'] = request.conversation_type
        if not UtilClient.is_unset(request.cool_app_code):
            body['coolAppCode'] = request.cool_app_code
        if not UtilClient.is_unset(request.expired_time):
            body['expiredTime'] = request.expired_time
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.platforms):
            body['platforms'] = request.platforms
        if not UtilClient.is_unset(request.receiver_user_id_list):
            body['receiverUserIdList'] = request.receiver_user_id_list
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxOpenResponse(),
            await self.do_roarequest_async('TopboxOpen', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/topBoxes/open', 'none', req, runtime)
        )

    def update_group_avatar(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupAvatarHeaders()
        return self.update_group_avatar_with_options(request, headers, runtime)

    async def update_group_avatar_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupAvatarHeaders()
        return await self.update_group_avatar_with_options_async(request, headers, runtime)

    def update_group_avatar_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
        headers: dingtalkim__1__0_models.UpdateGroupAvatarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupAvatarResponse(),
            self.do_roarequest('UpdateGroupAvatar', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/avatars', 'json', req, runtime)
        )

    async def update_group_avatar_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
        headers: dingtalkim__1__0_models.UpdateGroupAvatarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_avatar):
            body['groupAvatar'] = request.group_avatar
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupAvatarResponse(),
            await self.do_roarequest_async('UpdateGroupAvatar', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/avatars', 'json', req, runtime)
        )

    def update_group_name(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupNameHeaders()
        return self.update_group_name_with_options(request, headers, runtime)

    async def update_group_name_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupNameHeaders()
        return await self.update_group_name_with_options_async(request, headers, runtime)

    def update_group_name_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
        headers: dingtalkim__1__0_models.UpdateGroupNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupNameResponse(),
            self.do_roarequest('UpdateGroupName', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/names', 'json', req, runtime)
        )

    async def update_group_name_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
        headers: dingtalkim__1__0_models.UpdateGroupNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupNameResponse(),
            await self.do_roarequest_async('UpdateGroupName', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interconnections/groups/names', 'json', req, runtime)
        )

    def update_group_permission(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupPermissionHeaders()
        return self.update_group_permission_with_options(request, headers, runtime)

    async def update_group_permission_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupPermissionHeaders()
        return await self.update_group_permission_with_options_async(request, headers, runtime)

    def update_group_permission_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
        headers: dingtalkim__1__0_models.UpdateGroupPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.permission_group):
            body['permissionGroup'] = request.permission_group
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupPermissionResponse(),
            self.do_roarequest('UpdateGroupPermission', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/permissions', 'json', req, runtime)
        )

    async def update_group_permission_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
        headers: dingtalkim__1__0_models.UpdateGroupPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.permission_group):
            body['permissionGroup'] = request.permission_group
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupPermissionResponse(),
            await self.do_roarequest_async('UpdateGroupPermission', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/permissions', 'json', req, runtime)
        )

    def update_group_sub_admin(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupSubAdminHeaders()
        return self.update_group_sub_admin_with_options(request, headers, runtime)

    async def update_group_sub_admin_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupSubAdminHeaders()
        return await self.update_group_sub_admin_with_options_async(request, headers, runtime)

    def update_group_sub_admin_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
        headers: dingtalkim__1__0_models.UpdateGroupSubAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupSubAdminResponse(),
            self.do_roarequest('UpdateGroupSubAdmin', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/subAdmins', 'json', req, runtime)
        )

    async def update_group_sub_admin_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
        headers: dingtalkim__1__0_models.UpdateGroupSubAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role):
            body['role'] = request.role
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupSubAdminResponse(),
            await self.do_roarequest_async('UpdateGroupSubAdmin', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/subAdmins', 'json', req, runtime)
        )

    def update_interactive_card(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return self.update_interactive_card_with_options(request, headers, runtime)

    async def update_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return await self.update_interactive_card_with_options_async(request, headers, runtime)

    def update_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateInteractiveCardResponse(),
            self.do_roarequest('UpdateInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interactiveCards', 'json', req, runtime)
        )

    async def update_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.out_track_id):
            body['outTrackId'] = request.out_track_id
        if not UtilClient.is_unset(request.private_data):
            body['privateData'] = request.private_data
        if not UtilClient.is_unset(request.user_id_type):
            body['userIdType'] = request.user_id_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateInteractiveCardResponse(),
            await self.do_roarequest_async('UpdateInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/interactiveCards', 'json', req, runtime)
        )

    def update_member_ban_words(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberBanWordsHeaders()
        return self.update_member_ban_words_with_options(request, headers, runtime)

    async def update_member_ban_words_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberBanWordsHeaders()
        return await self.update_member_ban_words_with_options_async(request, headers, runtime)

    def update_member_ban_words_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
        headers: dingtalkim__1__0_models.UpdateMemberBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mute_duration):
            body['muteDuration'] = request.mute_duration
        if not UtilClient.is_unset(request.mute_status):
            body['muteStatus'] = request.mute_status
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberBanWordsResponse(),
            self.do_roarequest('UpdateMemberBanWords', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/muteMembers/set', 'none', req, runtime)
        )

    async def update_member_ban_words_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
        headers: dingtalkim__1__0_models.UpdateMemberBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mute_duration):
            body['muteDuration'] = request.mute_duration
        if not UtilClient.is_unset(request.mute_status):
            body['muteStatus'] = request.mute_status
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id_list):
            body['userIdList'] = request.user_id_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberBanWordsResponse(),
            await self.do_roarequest_async('UpdateMemberBanWords', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/sceneGroups/muteMembers/set', 'none', req, runtime)
        )

    def update_member_group_nick(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberGroupNickHeaders()
        return self.update_member_group_nick_with_options(request, headers, runtime)

    async def update_member_group_nick_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberGroupNickHeaders()
        return await self.update_member_group_nick_with_options_async(request, headers, runtime)

    def update_member_group_nick_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
        headers: dingtalkim__1__0_models.UpdateMemberGroupNickHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_nick):
            body['groupNick'] = request.group_nick
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberGroupNickResponse(),
            self.do_roarequest('UpdateMemberGroupNick', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/members/groupNicks', 'json', req, runtime)
        )

    async def update_member_group_nick_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
        headers: dingtalkim__1__0_models.UpdateMemberGroupNickHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_nick):
            body['groupNick'] = request.group_nick
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberGroupNickResponse(),
            await self.do_roarequest_async('UpdateMemberGroupNick', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/members/groupNicks', 'json', req, runtime)
        )

    def update_robot_interactive_card(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders()
        return self.update_robot_interactive_card_with_options(request, headers, runtime)

    async def update_robot_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders()
        return await self.update_robot_interactive_card_with_options_async(request, headers, runtime)

    def update_robot_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.update_options):
            body['updateOptions'] = request.update_options
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse(),
            self.do_roarequest('UpdateRobotInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/robots/interactiveCards', 'json', req, runtime)
        )

    async def update_robot_interactive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_biz_id):
            body['cardBizId'] = request.card_biz_id
        if not UtilClient.is_unset(request.card_data):
            body['cardData'] = request.card_data
        if not UtilClient.is_unset(request.union_id_private_data_map):
            body['unionIdPrivateDataMap'] = request.union_id_private_data_map
        if not UtilClient.is_unset(request.update_options):
            body['updateOptions'] = request.update_options
        if not UtilClient.is_unset(request.user_id_private_data_map):
            body['userIdPrivateDataMap'] = request.user_id_private_data_map
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse(),
            await self.do_roarequest_async('UpdateRobotInteractiveCard', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/robots/interactiveCards', 'json', req, runtime)
        )

    def update_the_group_roles_of_group_member(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders()
        return self.update_the_group_roles_of_group_member_with_options(request, headers, runtime)

    async def update_the_group_roles_of_group_member_async(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders()
        return await self.update_the_group_roles_of_group_member_with_options_async(request, headers, runtime)

    def update_the_group_roles_of_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
        headers: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_ids):
            body['openRoleIds'] = request.open_role_ids
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse(),
            self.do_roarequest('UpdateTheGroupRolesOfGroupMember', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/members/groupRoles', 'json', req, runtime)
        )

    async def update_the_group_roles_of_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
        headers: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_ids):
            body['openRoleIds'] = request.open_role_ids
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse(),
            await self.do_roarequest_async('UpdateTheGroupRolesOfGroupMember', 'im_1.0', 'HTTP', 'PUT', 'AK', f'/v1.0/im/sceneGroups/members/groupRoles', 'json', req, runtime)
        )

    def add_group_member(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddGroupMemberHeaders()
        return self.add_group_member_with_options(request, headers, runtime)

    async def add_group_member_async(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddGroupMemberHeaders()
        return await self.add_group_member_with_options_async(request, headers, runtime)

    def add_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
        headers: dingtalkim__1__0_models.AddGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddGroupMemberResponse(),
            self.do_roarequest('addGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/members', 'json', req, runtime)
        )

    async def add_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
        headers: dingtalkim__1__0_models.AddGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddGroupMemberResponse(),
            await self.do_roarequest_async('addGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/members', 'json', req, runtime)
        )

    def remove_group_member(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveGroupMemberHeaders()
        return self.remove_group_member_with_options(request, headers, runtime)

    async def remove_group_member_async(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveGroupMemberHeaders()
        return await self.remove_group_member_with_options_async(request, headers, runtime)

    def remove_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
        headers: dingtalkim__1__0_models.RemoveGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveGroupMemberResponse(),
            self.do_roarequest('removeGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/members/remove', 'json', req, runtime)
        )

    async def remove_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
        headers: dingtalkim__1__0_models.RemoveGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_user_ids):
            body['appUserIds'] = request.app_user_ids
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
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
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveGroupMemberResponse(),
            await self.do_roarequest_async('removeGroupMember', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/groups/members/remove', 'json', req, runtime)
        )

    def send_ding_message(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendDingMessageHeaders()
        return self.send_ding_message_with_options(request, headers, runtime)

    async def send_ding_message_async(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendDingMessageHeaders()
        return await self.send_ding_message_with_options_async(request, headers, runtime)

    def send_ding_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
        headers: dingtalkim__1__0_models.SendDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_id):
            body['receiverId'] = request.receiver_id
        if not UtilClient.is_unset(request.sender_id):
            body['senderId'] = request.sender_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendDingMessageResponse(),
            self.do_roarequest('sendDingMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/dingMessages/send', 'json', req, runtime)
        )

    async def send_ding_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
        headers: dingtalkim__1__0_models.SendDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.code):
            body['code'] = request.code
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_id):
            body['receiverId'] = request.receiver_id
        if not UtilClient.is_unset(request.sender_id):
            body['senderId'] = request.sender_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendDingMessageResponse(),
            await self.do_roarequest_async('sendDingMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/dingMessages/send', 'json', req, runtime)
        )

    def send_message(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
        headers: dingtalkim__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_id):
            body['receiverId'] = request.receiver_id
        if not UtilClient.is_unset(request.sender_id):
            body['senderId'] = request.sender_id
        if not UtilClient.is_unset(request.source_infos):
            body['sourceInfos'] = request.source_infos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendMessageResponse(),
            self.do_roarequest('sendMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/messages/send', 'json', req, runtime)
        )

    async def send_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
        headers: dingtalkim__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.message):
            body['message'] = request.message
        if not UtilClient.is_unset(request.message_type):
            body['messageType'] = request.message_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_id):
            body['receiverId'] = request.receiver_id
        if not UtilClient.is_unset(request.sender_id):
            body['senderId'] = request.sender_id
        if not UtilClient.is_unset(request.source_infos):
            body['sourceInfos'] = request.source_infos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendMessageResponse(),
            await self.do_roarequest_async('sendMessage', 'im_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/im/interconnections/messages/send', 'json', req, runtime)
        )
