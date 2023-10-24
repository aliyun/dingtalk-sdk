# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.im_1_0 import models as dingtalkim__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def add_org_text_emotion_with_options(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.AddOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.background_media_id):
            body['backgroundMediaId'] = request.background_media_id
        if not UtilClient.is_unset(request.background_media_id_for_panel):
            body['backgroundMediaIdForPanel'] = request.background_media_id_for_panel
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emotion_name):
            body['emotionName'] = request.emotion_name
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
            action='AddOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddOrgTextEmotionResponse(),
            self.execute(params, req, runtime)
        )

    async def add_org_text_emotion_with_options_async(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.AddOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.background_media_id):
            body['backgroundMediaId'] = request.background_media_id
        if not UtilClient.is_unset(request.background_media_id_for_panel):
            body['backgroundMediaIdForPanel'] = request.background_media_id_for_panel
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emotion_name):
            body['emotionName'] = request.emotion_name
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
            action='AddOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddOrgTextEmotionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_org_text_emotion(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddOrgTextEmotionHeaders()
        return self.add_org_text_emotion_with_options(request, headers, runtime)

    async def add_org_text_emotion_async(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddOrgTextEmotionHeaders()
        return await self.add_org_text_emotion_with_options_async(request, headers, runtime)

    def add_robot_to_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
        headers: dingtalkim__1__0_models.AddRobotToConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
        params = open_api_models.Params(
            action='AddRobotToConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/robots',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddRobotToConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def add_robot_to_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
        headers: dingtalkim__1__0_models.AddRobotToConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
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
        params = open_api_models.Params(
            action='AddRobotToConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/robots',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddRobotToConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_robot_to_conversation(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddRobotToConversationHeaders()
        return self.add_robot_to_conversation_with_options(request, headers, runtime)

    async def add_robot_to_conversation_async(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddRobotToConversationHeaders()
        return await self.add_robot_to_conversation_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='AutoOpenDingTalkConnect',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/apps/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='AutoOpenDingTalkConnect',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/apps/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse(),
            await self.execute_async(params, req, runtime)
        )

    def auto_open_ding_talk_connect(self) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return self.auto_open_ding_talk_connect_with_options(headers, runtime)

    async def auto_open_ding_talk_connect_async(self) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return await self.auto_open_ding_talk_connect_with_options_async(headers, runtime)

    def batch_query_family_school_message_with_options(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
        headers: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_message_ids):
            body['openMessageIds'] = request.open_message_ids
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='BatchQueryFamilySchoolMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/messages/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_family_school_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
        headers: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_message_ids):
            body['openMessageIds'] = request.open_message_ids
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='BatchQueryFamilySchoolMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/messages/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_family_school_message(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders()
        return self.batch_query_family_school_message_with_options(request, headers, runtime)

    async def batch_query_family_school_message_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders()
        return await self.batch_query_family_school_message_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='BatchQueryGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryGroupMemberResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='BatchQueryGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/batchQuery',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.BatchQueryGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CardTemplateBuildAction',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/templates/buildAction',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CardTemplateBuildActionResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CardTemplateBuildAction',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/templates/buildAction',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CardTemplateBuildActionResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='ChangeGroupOwner',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/owners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChangeGroupOwnerResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='ChangeGroupOwner',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/owners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChangeGroupOwnerResponse(),
            await self.execute_async(params, req, runtime)
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

    def chat_id_to_open_conversation_id_with_options(
        self,
        chat_id: str,
        headers: dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ChatIdToOpenConversationId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chat/{chat_id}/convertToOpenConversationId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse(),
            self.execute(params, req, runtime)
        )

    async def chat_id_to_open_conversation_id_with_options_async(
        self,
        chat_id: str,
        headers: dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ChatIdToOpenConversationId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chat/{chat_id}/convertToOpenConversationId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='ChatSubAdminUpdate',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/subAdministrators',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatSubAdminUpdateResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='ChatSubAdminUpdate',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/subAdministrators',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ChatSubAdminUpdateResponse(),
            await self.execute_async(params, req, runtime)
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

    def check_user_is_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
        headers: dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
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
        params = open_api_models.Params(
            action='CheckUserIsGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/members/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CheckUserIsGroupMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def check_user_is_group_member_with_options_async(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
        headers: dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        UtilClient.validate_model(request)
        body = {}
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
        params = open_api_models.Params(
            action='CheckUserIsGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/members/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CheckUserIsGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def check_user_is_group_member(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders()
        return self.check_user_is_group_member_with_options(request, headers, runtime)

    async def check_user_is_group_member_async(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders()
        return await self.check_user_is_group_member_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='CreateCoupleGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/coupleGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateCoupleGroupConversationResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateCoupleGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/coupleGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateCoupleGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateGroupConversationResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateInterconnection',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateInterconnectionResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateInterconnection',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateInterconnectionResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateSceneGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateSceneGroupConversationResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateSceneGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateSceneGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateStoreGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/storeGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateStoreGroupConversationResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='CreateStoreGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/storeGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CreateStoreGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
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

    def delete_org_text_emotion_with_options(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emotion_ids):
            body['emotionIds'] = request.emotion_ids
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
            action='DeleteOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DeleteOrgTextEmotionResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_org_text_emotion_with_options_async(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.emotion_ids):
            body['emotionIds'] = request.emotion_ids
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
            action='DeleteOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DeleteOrgTextEmotionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_org_text_emotion(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders()
        return self.delete_org_text_emotion_with_options(request, headers, runtime)

    async def delete_org_text_emotion_async(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders()
        return await self.delete_org_text_emotion_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='DismissGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/dismiss',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DismissGroupConversationResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='DismissGroupConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/dismiss',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DismissGroupConversationResponse(),
            await self.execute_async(params, req, runtime)
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
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
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
        params = open_api_models.Params(
            action='GetConversationUrl',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetConversationUrlResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.device_id):
            body['deviceId'] = request.device_id
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
        params = open_api_models.Params(
            action='GetConversationUrl',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetConversationUrlResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_family_school_conversation_msg_with_options(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.msg_types):
            body['msgTypes'] = request.msg_types
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='GetFamilySchoolConversationMsg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/messages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse(),
            self.execute(params, req, runtime)
        )

    async def get_family_school_conversation_msg_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.msg_types):
            body['msgTypes'] = request.msg_types
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='GetFamilySchoolConversationMsg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/messages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_family_school_conversation_msg(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders()
        return self.get_family_school_conversation_msg_with_options(request, headers, runtime)

    async def get_family_school_conversation_msg_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders()
        return await self.get_family_school_conversation_msg_with_options_async(request, headers, runtime)

    def get_family_school_conversations_with_options(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='GetFamilySchoolConversations',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetFamilySchoolConversationsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_family_school_conversations_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='GetFamilySchoolConversations',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/familySchools/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetFamilySchoolConversationsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_family_school_conversations(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders()
        return self.get_family_school_conversations_with_options(request, headers, runtime)

    async def get_family_school_conversations_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders()
        return await self.get_family_school_conversations_with_options_async(request, headers, runtime)

    def get_inner_group_members_with_options(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetInnerGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
        params = open_api_models.Params(
            action='GetInnerGroupMembers',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInnerGroupMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def get_inner_group_members_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetInnerGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
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
        params = open_api_models.Params(
            action='GetInnerGroupMembers',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInnerGroupMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_inner_group_members(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInnerGroupMembersHeaders()
        return self.get_inner_group_members_with_options(request, headers, runtime)

    async def get_inner_group_members_async(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInnerGroupMembersHeaders()
        return await self.get_inner_group_members_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='GetInterconnectionUrl',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/sessions/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInterconnectionUrlResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetInterconnectionUrl',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/sessions/urls',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetInterconnectionUrlResponse(),
            await self.execute_async(params, req, runtime)
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

    def get_newest_inner_groups_with_options(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
        headers: dingtalkim__1__0_models.GetNewestInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetNewestInnerGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/activities/innerGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetNewestInnerGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_newest_inner_groups_with_options_async(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
        headers: dingtalkim__1__0_models.GetNewestInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        UtilClient.validate_model(request)
        query = {}
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
        params = open_api_models.Params(
            action='GetNewestInnerGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/activities/innerGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetNewestInnerGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_newest_inner_groups(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetNewestInnerGroupsHeaders()
        return self.get_newest_inner_groups_with_options(request, headers, runtime)

    async def get_newest_inner_groups_async(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetNewestInnerGroupsHeaders()
        return await self.get_newest_inner_groups_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='GetSceneGroupInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupInfoResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetSceneGroupInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetSceneGroupMembers',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupMembersResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GetSceneGroupMembers',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupMembersResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupBanWords',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/words/ban',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupBanWordsResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupBanWords',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/words/ban',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupBanWordsResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityInquiry',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/inquiries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityInquiryResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityInquiry',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/inquiries/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityInquiryResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityOrderConfirm',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/orders/confirm',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityOrderConfirm',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/orders/confirm',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityOrderPlace',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/orders/place',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupCapacityOrderPlace',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/orders/place',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupManageQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/managements/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageQueryResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupManageQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/managements/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageQueryResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupManageReduce',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/reduce',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageReduceResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='GroupManageReduce',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/capacities/reduce',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GroupManageReduceResponse(),
            await self.execute_async(params, req, runtime)
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

    def install_robot_to_org_with_options(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
        headers: dingtalkim__1__0_models.InstallRobotToOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.outgoing_token):
            body['outgoingToken'] = request.outgoing_token
        if not UtilClient.is_unset(request.outgoing_url):
            body['outgoingUrl'] = request.outgoing_url
        if not UtilClient.is_unset(request.preview_media_id):
            body['previewMediaId'] = request.preview_media_id
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
        params = open_api_models.Params(
            action='InstallRobotToOrg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/robots/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InstallRobotToOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def install_robot_to_org_with_options_async(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
        headers: dingtalkim__1__0_models.InstallRobotToOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.outgoing_token):
            body['outgoingToken'] = request.outgoing_token
        if not UtilClient.is_unset(request.outgoing_url):
            body['outgoingUrl'] = request.outgoing_url
        if not UtilClient.is_unset(request.preview_media_id):
            body['previewMediaId'] = request.preview_media_id
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
        params = open_api_models.Params(
            action='InstallRobotToOrg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/robots/install',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InstallRobotToOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def install_robot_to_org(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InstallRobotToOrgHeaders()
        return self.install_robot_to_org_with_options(request, headers, runtime)

    async def install_robot_to_org_async(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InstallRobotToOrgHeaders()
        return await self.install_robot_to_org_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='InteractiveCardCreateInstance',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='InteractiveCardCreateInstance',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse(),
            await self.execute_async(params, req, runtime)
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

    def list_org_text_emotion_with_options(
        self,
        headers: dingtalkim__1__0_models.ListOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ListOrgTextEmotionResponse(),
            self.execute(params, req, runtime)
        )

    async def list_org_text_emotion_with_options_async(
        self,
        headers: dingtalkim__1__0_models.ListOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListOrgTextEmotion',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/textEmotions',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ListOrgTextEmotionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_org_text_emotion(self) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListOrgTextEmotionHeaders()
        return self.list_org_text_emotion_with_options(headers, runtime)

    async def list_org_text_emotion_async(self) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListOrgTextEmotionHeaders()
        return await self.list_org_text_emotion_with_options_async(headers, runtime)

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
        params = open_api_models.Params(
            action='QueryGroupInfoByMemberAuth',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/memberAuthorizations/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupInfoByMemberAuth',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/memberAuthorizations/groups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/conversations/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/conversations/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMemberByMemberAuth',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/memberAuthorizations/groups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMemberByMemberAuth',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/memberAuthorizations/groups/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMuteStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/muteSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMuteStatusResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryGroupMuteStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/muteSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryGroupMuteStatusResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryMembersOfGroupRole',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/roles/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryMembersOfGroupRole',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/roles/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QuerySceneGroupTemplateRobot',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/templates/robots',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QuerySceneGroupTemplateRobot',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/templates/robots',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QuerySingleGroup',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/doubleGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySingleGroupResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QuerySingleGroup',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/doubleGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QuerySingleGroupResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryUnReadMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/unReadMsgs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnReadMessageResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='QueryUnReadMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/unReadMsgs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnReadMessageResponse(),
            await self.execute_async(params, req, runtime)
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

    def remove_robot_from_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
        headers: dingtalkim__1__0_models.RemoveRobotFromConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_bot_user_id):
            body['chatBotUserId'] = request.chat_bot_user_id
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
        params = open_api_models.Params(
            action='RemoveRobotFromConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/robots/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveRobotFromConversationResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_robot_from_conversation_with_options_async(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
        headers: dingtalkim__1__0_models.RemoveRobotFromConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_bot_user_id):
            body['chatBotUserId'] = request.chat_bot_user_id
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
        params = open_api_models.Params(
            action='RemoveRobotFromConversation',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/robots/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveRobotFromConversationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_robot_from_conversation(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveRobotFromConversationHeaders()
        return self.remove_robot_from_conversation_with_options(request, headers, runtime)

    async def remove_robot_from_conversation_async(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveRobotFromConversationHeaders()
        return await self.remove_robot_from_conversation_with_options_async(request, headers, runtime)

    def search_inner_groups_with_options(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
        headers: dingtalkim__1__0_models.SearchInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.search_key):
            body['searchKey'] = request.search_key
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
            action='SearchInnerGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SearchInnerGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def search_inner_groups_with_options_async(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
        headers: dingtalkim__1__0_models.SearchInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.search_key):
            body['searchKey'] = request.search_key
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
            action='SearchInnerGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SearchInnerGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_inner_groups(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SearchInnerGroupsHeaders()
        return self.search_inner_groups_with_options(request, headers, runtime)

    async def search_inner_groups_async(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SearchInnerGroupsHeaders()
        return await self.search_inner_groups_with_options_async(request, headers, runtime)

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
        if not UtilClient.is_unset(request.digital_worker_code):
            body['digitalWorkerCode'] = request.digital_worker_code
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
        params = open_api_models.Params(
            action='SendInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendInteractiveCardResponse(),
            self.execute(params, req, runtime)
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
        if not UtilClient.is_unset(request.digital_worker_code):
            body['digitalWorkerCode'] = request.digital_worker_code
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
        params = open_api_models.Params(
            action='SendInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
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

    def send_otointeractive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendOTOInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
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
        params = open_api_models.Params(
            action='SendOTOInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/privateChat/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendOTOInteractiveCardResponse(),
            self.execute(params, req, runtime)
        )

    async def send_otointeractive_card_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendOTOInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
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
        params = open_api_models.Params(
            action='SendOTOInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/privateChat/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendOTOInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_otointeractive_card(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendOTOInteractiveCardHeaders()
        return self.send_otointeractive_card_with_options(request, headers, runtime)

    async def send_otointeractive_card_async(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendOTOInteractiveCardHeaders()
        return await self.send_otointeractive_card_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='SendRobotInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/v1.0/robot/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotInteractiveCardResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='SendRobotInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/v1.0/robot/interactiveCards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='SendRobotMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/robotMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotMessageResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='SendRobotMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/robotMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendRobotMessageResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='SendTemplateInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/templates/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendTemplateInteractiveCardResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='SendTemplateInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards/templates/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendTemplateInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
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

    def set_right_panel_with_options(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
        headers: dingtalkim__1__0_models.SetRightPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.right_panel_close_permitted):
            body['rightPanelClosePermitted'] = request.right_panel_close_permitted
        if not UtilClient.is_unset(request.right_panel_open_status):
            body['rightPanelOpenStatus'] = request.right_panel_open_status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.web_wnd_params):
            body['webWndParams'] = request.web_wnd_params
        if not UtilClient.is_unset(request.width):
            body['width'] = request.width
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
            action='SetRightPanel',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/rightPanels/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SetRightPanelResponse(),
            self.execute(params, req, runtime)
        )

    async def set_right_panel_with_options_async(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
        headers: dingtalkim__1__0_models.SetRightPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.right_panel_close_permitted):
            body['rightPanelClosePermitted'] = request.right_panel_close_permitted
        if not UtilClient.is_unset(request.right_panel_open_status):
            body['rightPanelOpenStatus'] = request.right_panel_open_status
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.web_wnd_params):
            body['webWndParams'] = request.web_wnd_params
        if not UtilClient.is_unset(request.width):
            body['width'] = request.width
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
            action='SetRightPanel',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/rightPanels/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SetRightPanelResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_right_panel(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SetRightPanelHeaders()
        return self.set_right_panel_with_options(request, headers, runtime)

    async def set_right_panel_async(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SetRightPanelHeaders()
        return await self.set_right_panel_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='TopboxClose',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxCloseResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='TopboxClose',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/topBoxes/close',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxCloseResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='TopboxOpen',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/topBoxes/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxOpenResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='TopboxOpen',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/topBoxes/open',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.TopboxOpenResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupAvatar',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/avatars',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupAvatarResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupAvatar',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/avatars',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupAvatarResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupName',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupNameResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupName',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupNameResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupPermission',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupPermissionResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupPermission',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/permissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupPermissionResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupSubAdmin',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/subAdmins',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupSubAdminResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateGroupSubAdmin',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/subAdmins',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateGroupSubAdminResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateInteractiveCardResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interactiveCards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateMemberBanWords',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/muteMembers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberBanWordsResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateMemberBanWords',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/muteMembers/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberBanWordsResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateMemberGroupNick',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/groupNicks',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberGroupNickResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateMemberGroupNick',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/groupNicks',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateMemberGroupNickResponse(),
            await self.execute_async(params, req, runtime)
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

    def update_robot_in_org_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.outgoing_token):
            body['outgoingToken'] = request.outgoing_token
        if not UtilClient.is_unset(request.outgoing_url):
            body['outgoingUrl'] = request.outgoing_url
        if not UtilClient.is_unset(request.preview_media_id):
            body['previewMediaId'] = request.preview_media_id
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
        params = open_api_models.Params(
            action='UpdateRobotInOrg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/robots',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def update_robot_in_org_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.brief):
            body['brief'] = request.brief
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.outgoing_token):
            body['outgoingToken'] = request.outgoing_token
        if not UtilClient.is_unset(request.outgoing_url):
            body['outgoingUrl'] = request.outgoing_url
        if not UtilClient.is_unset(request.preview_media_id):
            body['previewMediaId'] = request.preview_media_id
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
        params = open_api_models.Params(
            action='UpdateRobotInOrg',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/organizations/robots',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_robot_in_org(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInOrgHeaders()
        return self.update_robot_in_org_with_options(request, headers, runtime)

    async def update_robot_in_org_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInOrgHeaders()
        return await self.update_robot_in_org_with_options_async(request, headers, runtime)

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
        params = open_api_models.Params(
            action='UpdateRobotInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/robots/interactiveCards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateRobotInteractiveCard',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/robots/interactiveCards',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateTheGroupRolesOfGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/groupRoles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='UpdateTheGroupRolesOfGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/sceneGroups/members/groupRoles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='addGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddGroupMemberResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='addGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='removeGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveGroupMemberResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='removeGroupMember',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/groups/members/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.RemoveGroupMemberResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='sendDingMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/dingMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendDingMessageResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='sendDingMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/dingMessages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendDingMessageResponse(),
            await self.execute_async(params, req, runtime)
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
        params = open_api_models.Params(
            action='sendMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendMessageResponse(),
            self.execute(params, req, runtime)
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
        params = open_api_models.Params(
            action='sendMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/interconnections/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendMessageResponse(),
            await self.execute_async(params, req, runtime)
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
