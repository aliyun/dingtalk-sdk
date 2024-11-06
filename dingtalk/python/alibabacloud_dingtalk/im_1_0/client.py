# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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

    def add_org_text_emotion_with_options(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.AddOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        """
        @summary 添加企业文字表情
        
        @param request: AddOrgTextEmotionRequest
        @param headers: AddOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgTextEmotionResponse
        """
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
        """
        @summary 添加企业文字表情
        
        @param request: AddOrgTextEmotionRequest
        @param headers: AddOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgTextEmotionResponse
        """
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
        """
        @summary 添加企业文字表情
        
        @param request: AddOrgTextEmotionRequest
        @return: AddOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddOrgTextEmotionHeaders()
        return self.add_org_text_emotion_with_options(request, headers, runtime)

    async def add_org_text_emotion_async(
        self,
        request: dingtalkim__1__0_models.AddOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.AddOrgTextEmotionResponse:
        """
        @summary 添加企业文字表情
        
        @param request: AddOrgTextEmotionRequest
        @return: AddOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddOrgTextEmotionHeaders()
        return await self.add_org_text_emotion_with_options_async(request, headers, runtime)

    def add_robot_to_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
        headers: dingtalkim__1__0_models.AddRobotToConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        """
        @summary 添加机器人到会话
        
        @param request: AddRobotToConversationRequest
        @param headers: AddRobotToConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRobotToConversationResponse
        """
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
        """
        @summary 添加机器人到会话
        
        @param request: AddRobotToConversationRequest
        @param headers: AddRobotToConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddRobotToConversationResponse
        """
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
        """
        @summary 添加机器人到会话
        
        @param request: AddRobotToConversationRequest
        @return: AddRobotToConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddRobotToConversationHeaders()
        return self.add_robot_to_conversation_with_options(request, headers, runtime)

    async def add_robot_to_conversation_async(
        self,
        request: dingtalkim__1__0_models.AddRobotToConversationRequest,
    ) -> dingtalkim__1__0_models.AddRobotToConversationResponse:
        """
        @summary 添加机器人到会话
        
        @param request: AddRobotToConversationRequest
        @return: AddRobotToConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddRobotToConversationHeaders()
        return await self.add_robot_to_conversation_with_options_async(request, headers, runtime)

    def add_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.AddUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.AddUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddUnfurlingRegisterResponse:
        """
        @summary 新增链接增强注册规则
        
        @param request: AddUnfurlingRegisterRequest
        @param headers: AddUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
        if not UtilClient.is_unset(request.rule_desc):
            body['ruleDesc'] = request.rule_desc
        if not UtilClient.is_unset(request.rule_match_type):
            body['ruleMatchType'] = request.rule_match_type
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
            action='AddUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def add_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.AddUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.AddUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddUnfurlingRegisterResponse:
        """
        @summary 新增链接增强注册规则
        
        @param request: AddUnfurlingRegisterRequest
        @param headers: AddUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
        if not UtilClient.is_unset(request.rule_desc):
            body['ruleDesc'] = request.rule_desc
        if not UtilClient.is_unset(request.rule_match_type):
            body['ruleMatchType'] = request.rule_match_type
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
            action='AddUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.AddUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_unfurling_register(
        self,
        request: dingtalkim__1__0_models.AddUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.AddUnfurlingRegisterResponse:
        """
        @summary 新增链接增强注册规则
        
        @param request: AddUnfurlingRegisterRequest
        @return: AddUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddUnfurlingRegisterHeaders()
        return self.add_unfurling_register_with_options(request, headers, runtime)

    async def add_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.AddUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.AddUnfurlingRegisterResponse:
        """
        @summary 新增链接增强注册规则
        
        @param request: AddUnfurlingRegisterRequest
        @return: AddUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddUnfurlingRegisterHeaders()
        return await self.add_unfurling_register_with_options_async(request, headers, runtime)

    def auto_open_ding_talk_connect_with_options(
        self,
        headers: dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        """
        @summary 自动开通钉钉客联微应用
        
        @param headers: AutoOpenDingTalkConnectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AutoOpenDingTalkConnectResponse
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
        """
        @summary 自动开通钉钉客联微应用
        
        @param headers: AutoOpenDingTalkConnectHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AutoOpenDingTalkConnectResponse
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
        """
        @summary 自动开通钉钉客联微应用
        
        @return: AutoOpenDingTalkConnectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return self.auto_open_ding_talk_connect_with_options(headers, runtime)

    async def auto_open_ding_talk_connect_async(self) -> dingtalkim__1__0_models.AutoOpenDingTalkConnectResponse:
        """
        @summary 自动开通钉钉客联微应用
        
        @return: AutoOpenDingTalkConnectResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AutoOpenDingTalkConnectHeaders()
        return await self.auto_open_ding_talk_connect_with_options_async(headers, runtime)

    def batch_query_family_school_message_with_options(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
        headers: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        """
        @summary 批量查询家校群消息详情
        
        @param request: BatchQueryFamilySchoolMessageRequest
        @param headers: BatchQueryFamilySchoolMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryFamilySchoolMessageResponse
        """
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
        """
        @summary 批量查询家校群消息详情
        
        @param request: BatchQueryFamilySchoolMessageRequest
        @param headers: BatchQueryFamilySchoolMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryFamilySchoolMessageResponse
        """
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
        """
        @summary 批量查询家校群消息详情
        
        @param request: BatchQueryFamilySchoolMessageRequest
        @return: BatchQueryFamilySchoolMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders()
        return self.batch_query_family_school_message_with_options(request, headers, runtime)

    async def batch_query_family_school_message_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryFamilySchoolMessageRequest,
    ) -> dingtalkim__1__0_models.BatchQueryFamilySchoolMessageResponse:
        """
        @summary 批量查询家校群消息详情
        
        @param request: BatchQueryFamilySchoolMessageRequest
        @return: BatchQueryFamilySchoolMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryFamilySchoolMessageHeaders()
        return await self.batch_query_family_school_message_with_options_async(request, headers, runtime)

    def batch_query_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.BatchQueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @param headers: BatchQueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryGroupMemberResponse
        """
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
        """
        @summary 查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @param headers: BatchQueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryGroupMemberResponse
        """
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
        """
        @summary 查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @return: BatchQueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryGroupMemberHeaders()
        return self.batch_query_group_member_with_options(request, headers, runtime)

    async def batch_query_group_member_async(
        self,
        request: dingtalkim__1__0_models.BatchQueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.BatchQueryGroupMemberResponse:
        """
        @summary 查询群成员
        
        @param request: BatchQueryGroupMemberRequest
        @return: BatchQueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.BatchQueryGroupMemberHeaders()
        return await self.batch_query_group_member_with_options_async(request, headers, runtime)

    def card_template_build_action_with_options(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
        headers: dingtalkim__1__0_models.CardTemplateBuildActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        """
        @summary 钉钉互动卡片模板构建动作
        
        @param request: CardTemplateBuildActionRequest
        @param headers: CardTemplateBuildActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardTemplateBuildActionResponse
        """
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
        """
        @summary 钉钉互动卡片模板构建动作
        
        @param request: CardTemplateBuildActionRequest
        @param headers: CardTemplateBuildActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CardTemplateBuildActionResponse
        """
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
        """
        @summary 钉钉互动卡片模板构建动作
        
        @param request: CardTemplateBuildActionRequest
        @return: CardTemplateBuildActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CardTemplateBuildActionHeaders()
        return self.card_template_build_action_with_options(request, headers, runtime)

    async def card_template_build_action_async(
        self,
        request: dingtalkim__1__0_models.CardTemplateBuildActionRequest,
    ) -> dingtalkim__1__0_models.CardTemplateBuildActionResponse:
        """
        @summary 钉钉互动卡片模板构建动作
        
        @param request: CardTemplateBuildActionRequest
        @return: CardTemplateBuildActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CardTemplateBuildActionHeaders()
        return await self.card_template_build_action_with_options_async(request, headers, runtime)

    def change_group_owner_with_options(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
        headers: dingtalkim__1__0_models.ChangeGroupOwnerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        """
        @summary 更换群主
        
        @param request: ChangeGroupOwnerRequest
        @param headers: ChangeGroupOwnerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeGroupOwnerResponse
        """
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
        """
        @summary 更换群主
        
        @param request: ChangeGroupOwnerRequest
        @param headers: ChangeGroupOwnerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeGroupOwnerResponse
        """
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
        """
        @summary 更换群主
        
        @param request: ChangeGroupOwnerRequest
        @return: ChangeGroupOwnerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChangeGroupOwnerHeaders()
        return self.change_group_owner_with_options(request, headers, runtime)

    async def change_group_owner_async(
        self,
        request: dingtalkim__1__0_models.ChangeGroupOwnerRequest,
    ) -> dingtalkim__1__0_models.ChangeGroupOwnerResponse:
        """
        @summary 更换群主
        
        @param request: ChangeGroupOwnerRequest
        @return: ChangeGroupOwnerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChangeGroupOwnerHeaders()
        return await self.change_group_owner_with_options_async(request, headers, runtime)

    def chat_id_to_open_conversation_id_with_options(
        self,
        chat_id: str,
        headers: dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        """
        @summary 会话开放的ChatId转OpenConversationId
        
        @param headers: ChatIdToOpenConversationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatIdToOpenConversationIdResponse
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
        """
        @summary 会话开放的ChatId转OpenConversationId
        
        @param headers: ChatIdToOpenConversationIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatIdToOpenConversationIdResponse
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
        """
        @summary 会话开放的ChatId转OpenConversationId
        
        @return: ChatIdToOpenConversationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders()
        return self.chat_id_to_open_conversation_id_with_options(chat_id, headers, runtime)

    async def chat_id_to_open_conversation_id_async(
        self,
        chat_id: str,
    ) -> dingtalkim__1__0_models.ChatIdToOpenConversationIdResponse:
        """
        @summary 会话开放的ChatId转OpenConversationId
        
        @return: ChatIdToOpenConversationIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatIdToOpenConversationIdHeaders()
        return await self.chat_id_to_open_conversation_id_with_options_async(chat_id, headers, runtime)

    def chat_sub_admin_update_with_options(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
        headers: dingtalkim__1__0_models.ChatSubAdminUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        """
        @summary 设置群管理员
        
        @param request: ChatSubAdminUpdateRequest
        @param headers: ChatSubAdminUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatSubAdminUpdateResponse
        """
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
        """
        @summary 设置群管理员
        
        @param request: ChatSubAdminUpdateRequest
        @param headers: ChatSubAdminUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChatSubAdminUpdateResponse
        """
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
        """
        @summary 设置群管理员
        
        @param request: ChatSubAdminUpdateRequest
        @return: ChatSubAdminUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatSubAdminUpdateHeaders()
        return self.chat_sub_admin_update_with_options(request, headers, runtime)

    async def chat_sub_admin_update_async(
        self,
        request: dingtalkim__1__0_models.ChatSubAdminUpdateRequest,
    ) -> dingtalkim__1__0_models.ChatSubAdminUpdateResponse:
        """
        @summary 设置群管理员
        
        @param request: ChatSubAdminUpdateRequest
        @return: ChatSubAdminUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ChatSubAdminUpdateHeaders()
        return await self.chat_sub_admin_update_with_options_async(request, headers, runtime)

    def check_user_is_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
        headers: dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        """
        @summary 查询用户是否为企业内部群成员
        
        @param request: CheckUserIsGroupMemberRequest
        @param headers: CheckUserIsGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserIsGroupMemberResponse
        """
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
        """
        @summary 查询用户是否为企业内部群成员
        
        @param request: CheckUserIsGroupMemberRequest
        @param headers: CheckUserIsGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CheckUserIsGroupMemberResponse
        """
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
        """
        @summary 查询用户是否为企业内部群成员
        
        @param request: CheckUserIsGroupMemberRequest
        @return: CheckUserIsGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders()
        return self.check_user_is_group_member_with_options(request, headers, runtime)

    async def check_user_is_group_member_async(
        self,
        request: dingtalkim__1__0_models.CheckUserIsGroupMemberRequest,
    ) -> dingtalkim__1__0_models.CheckUserIsGroupMemberResponse:
        """
        @summary 查询用户是否为企业内部群成员
        
        @param request: CheckUserIsGroupMemberRequest
        @return: CheckUserIsGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CheckUserIsGroupMemberHeaders()
        return await self.check_user_is_group_member_with_options_async(request, headers, runtime)

    def copy_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.CopyUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.CopyUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CopyUnfurlingRegisterResponse:
        """
        @summary 链接增强规则拷贝
        
        @param request: CopyUnfurlingRegisterRequest
        @param headers: CopyUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='CopyUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CopyUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.CopyUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.CopyUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CopyUnfurlingRegisterResponse:
        """
        @summary 链接增强规则拷贝
        
        @param request: CopyUnfurlingRegisterRequest
        @param headers: CopyUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='CopyUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CopyUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_unfurling_register(
        self,
        request: dingtalkim__1__0_models.CopyUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.CopyUnfurlingRegisterResponse:
        """
        @summary 链接增强规则拷贝
        
        @param request: CopyUnfurlingRegisterRequest
        @return: CopyUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CopyUnfurlingRegisterHeaders()
        return self.copy_unfurling_register_with_options(request, headers, runtime)

    async def copy_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.CopyUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.CopyUnfurlingRegisterResponse:
        """
        @summary 链接增强规则拷贝
        
        @param request: CopyUnfurlingRegisterRequest
        @return: CopyUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CopyUnfurlingRegisterHeaders()
        return await self.copy_unfurling_register_with_options_async(request, headers, runtime)

    def count_open_msg_scene_groups_with_options(
        self,
        request: dingtalkim__1__0_models.CountOpenMsgSceneGroupsRequest,
        headers: dingtalkim__1__0_models.CountOpenMsgSceneGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse:
        """
        @summary 查询消息开放群模板下群计数
        
        @param request: CountOpenMsgSceneGroupsRequest
        @param headers: CountOpenMsgSceneGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountOpenMsgSceneGroupsResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='CountOpenMsgSceneGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/openMsgSceneGroups/templates/counts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def count_open_msg_scene_groups_with_options_async(
        self,
        request: dingtalkim__1__0_models.CountOpenMsgSceneGroupsRequest,
        headers: dingtalkim__1__0_models.CountOpenMsgSceneGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse:
        """
        @summary 查询消息开放群模板下群计数
        
        @param request: CountOpenMsgSceneGroupsRequest
        @param headers: CountOpenMsgSceneGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountOpenMsgSceneGroupsResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='CountOpenMsgSceneGroups',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/openMsgSceneGroups/templates/counts/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def count_open_msg_scene_groups(
        self,
        request: dingtalkim__1__0_models.CountOpenMsgSceneGroupsRequest,
    ) -> dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse:
        """
        @summary 查询消息开放群模板下群计数
        
        @param request: CountOpenMsgSceneGroupsRequest
        @return: CountOpenMsgSceneGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CountOpenMsgSceneGroupsHeaders()
        return self.count_open_msg_scene_groups_with_options(request, headers, runtime)

    async def count_open_msg_scene_groups_async(
        self,
        request: dingtalkim__1__0_models.CountOpenMsgSceneGroupsRequest,
    ) -> dingtalkim__1__0_models.CountOpenMsgSceneGroupsResponse:
        """
        @summary 查询消息开放群模板下群计数
        
        @param request: CountOpenMsgSceneGroupsRequest
        @return: CountOpenMsgSceneGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CountOpenMsgSceneGroupsHeaders()
        return await self.count_open_msg_scene_groups_with_options_async(request, headers, runtime)

    def count_scene_groups_by_template_id_with_options(
        self,
        template_id: str,
        headers: dingtalkim__1__0_models.CountSceneGroupsByTemplateIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse:
        """
        @summary 查询群模板关联的群数量
        
        @param headers: CountSceneGroupsByTemplateIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountSceneGroupsByTemplateIdResponse
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
            action='CountSceneGroupsByTemplateId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse(),
            self.execute(params, req, runtime)
        )

    async def count_scene_groups_by_template_id_with_options_async(
        self,
        template_id: str,
        headers: dingtalkim__1__0_models.CountSceneGroupsByTemplateIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse:
        """
        @summary 查询群模板关联的群数量
        
        @param headers: CountSceneGroupsByTemplateIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CountSceneGroupsByTemplateIdResponse
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
            action='CountSceneGroupsByTemplateId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/counts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def count_scene_groups_by_template_id(
        self,
        template_id: str,
    ) -> dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse:
        """
        @summary 查询群模板关联的群数量
        
        @return: CountSceneGroupsByTemplateIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CountSceneGroupsByTemplateIdHeaders()
        return self.count_scene_groups_by_template_id_with_options(template_id, headers, runtime)

    async def count_scene_groups_by_template_id_async(
        self,
        template_id: str,
    ) -> dingtalkim__1__0_models.CountSceneGroupsByTemplateIdResponse:
        """
        @summary 查询群模板关联的群数量
        
        @return: CountSceneGroupsByTemplateIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CountSceneGroupsByTemplateIdHeaders()
        return await self.count_scene_groups_by_template_id_with_options_async(template_id, headers, runtime)

    def create_couple_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        """
        @summary 创建钉外两人群
        
        @param request: CreateCoupleGroupConversationRequest
        @param headers: CreateCoupleGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCoupleGroupConversationResponse
        """
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
        """
        @summary 创建钉外两人群
        
        @param request: CreateCoupleGroupConversationRequest
        @param headers: CreateCoupleGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCoupleGroupConversationResponse
        """
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
        """
        @summary 创建钉外两人群
        
        @param request: CreateCoupleGroupConversationRequest
        @return: CreateCoupleGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders()
        return self.create_couple_group_conversation_with_options(request, headers, runtime)

    async def create_couple_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateCoupleGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateCoupleGroupConversationResponse:
        """
        @summary 创建钉外两人群
        
        @param request: CreateCoupleGroupConversationRequest
        @return: CreateCoupleGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateCoupleGroupConversationHeaders()
        return await self.create_couple_group_conversation_with_options_async(request, headers, runtime)

    def create_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建互通群（支持普通互通群、跨钉两人群）
        
        @param request: CreateGroupConversationRequest
        @param headers: CreateGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupConversationResponse
        """
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
        """
        @summary 创建互通群（支持普通互通群、跨钉两人群）
        
        @param request: CreateGroupConversationRequest
        @param headers: CreateGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateGroupConversationResponse
        """
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
        """
        @summary 创建互通群（支持普通互通群、跨钉两人群）
        
        @param request: CreateGroupConversationRequest
        @return: CreateGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateGroupConversationHeaders()
        return self.create_group_conversation_with_options(request, headers, runtime)

    async def create_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateGroupConversationResponse:
        """
        @summary 创建互通群（支持普通互通群、跨钉两人群）
        
        @param request: CreateGroupConversationRequest
        @return: CreateGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateGroupConversationHeaders()
        return await self.create_group_conversation_with_options_async(request, headers, runtime)

    def create_interconnection_with_options(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
        headers: dingtalkim__1__0_models.CreateInterconnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        """
        @summary 创建钉外账号
        
        @param request: CreateInterconnectionRequest
        @param headers: CreateInterconnectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInterconnectionResponse
        """
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
        """
        @summary 创建钉外账号
        
        @param request: CreateInterconnectionRequest
        @param headers: CreateInterconnectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInterconnectionResponse
        """
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
        """
        @summary 创建钉外账号
        
        @param request: CreateInterconnectionRequest
        @return: CreateInterconnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateInterconnectionHeaders()
        return self.create_interconnection_with_options(request, headers, runtime)

    async def create_interconnection_async(
        self,
        request: dingtalkim__1__0_models.CreateInterconnectionRequest,
    ) -> dingtalkim__1__0_models.CreateInterconnectionResponse:
        """
        @summary 创建钉外账号
        
        @param request: CreateInterconnectionRequest
        @return: CreateInterconnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateInterconnectionHeaders()
        return await self.create_interconnection_with_options_async(request, headers, runtime)

    def create_scene_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateSceneGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        """
        @summary 创建场景群会话
        
        @param request: CreateSceneGroupConversationRequest
        @param headers: CreateSceneGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSceneGroupConversationResponse
        """
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
        """
        @summary 创建场景群会话
        
        @param request: CreateSceneGroupConversationRequest
        @param headers: CreateSceneGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSceneGroupConversationResponse
        """
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
        """
        @summary 创建场景群会话
        
        @param request: CreateSceneGroupConversationRequest
        @return: CreateSceneGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateSceneGroupConversationHeaders()
        return self.create_scene_group_conversation_with_options(request, headers, runtime)

    async def create_scene_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateSceneGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateSceneGroupConversationResponse:
        """
        @summary 创建场景群会话
        
        @param request: CreateSceneGroupConversationRequest
        @return: CreateSceneGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateSceneGroupConversationHeaders()
        return await self.create_scene_group_conversation_with_options_async(request, headers, runtime)

    def create_store_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
        headers: dingtalkim__1__0_models.CreateStoreGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        """
        @summary 创建店铺群
        
        @param request: CreateStoreGroupConversationRequest
        @param headers: CreateStoreGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStoreGroupConversationResponse
        """
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
        """
        @summary 创建店铺群
        
        @param request: CreateStoreGroupConversationRequest
        @param headers: CreateStoreGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateStoreGroupConversationResponse
        """
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
        """
        @summary 创建店铺群
        
        @param request: CreateStoreGroupConversationRequest
        @return: CreateStoreGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateStoreGroupConversationHeaders()
        return self.create_store_group_conversation_with_options(request, headers, runtime)

    async def create_store_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.CreateStoreGroupConversationRequest,
    ) -> dingtalkim__1__0_models.CreateStoreGroupConversationResponse:
        """
        @summary 创建店铺群
        
        @param request: CreateStoreGroupConversationRequest
        @return: CreateStoreGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.CreateStoreGroupConversationHeaders()
        return await self.create_store_group_conversation_with_options_async(request, headers, runtime)

    def debug_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.DebugUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.DebugUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DebugUnfurlingRegisterResponse:
        """
        @summary 链接增强规则调试
        
        @param request: DebugUnfurlingRegisterRequest
        @param headers: DebugUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DebugUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.gray_group_id_list):
            body['grayGroupIdList'] = request.gray_group_id_list
        if not UtilClient.is_unset(request.gray_user_id_list):
            body['grayUserIdList'] = request.gray_user_id_list
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='DebugUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/debug',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DebugUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def debug_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.DebugUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.DebugUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DebugUnfurlingRegisterResponse:
        """
        @summary 链接增强规则调试
        
        @param request: DebugUnfurlingRegisterRequest
        @param headers: DebugUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DebugUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.gray_group_id_list):
            body['grayGroupIdList'] = request.gray_group_id_list
        if not UtilClient.is_unset(request.gray_user_id_list):
            body['grayUserIdList'] = request.gray_user_id_list
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='DebugUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/debug',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.DebugUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def debug_unfurling_register(
        self,
        request: dingtalkim__1__0_models.DebugUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.DebugUnfurlingRegisterResponse:
        """
        @summary 链接增强规则调试
        
        @param request: DebugUnfurlingRegisterRequest
        @return: DebugUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DebugUnfurlingRegisterHeaders()
        return self.debug_unfurling_register_with_options(request, headers, runtime)

    async def debug_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.DebugUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.DebugUnfurlingRegisterResponse:
        """
        @summary 链接增强规则调试
        
        @param request: DebugUnfurlingRegisterRequest
        @return: DebugUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DebugUnfurlingRegisterHeaders()
        return await self.debug_unfurling_register_with_options_async(request, headers, runtime)

    def delete_org_text_emotion_with_options(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
        headers: dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        """
        @summary 删除企业文字表情
        
        @param request: DeleteOrgTextEmotionRequest
        @param headers: DeleteOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteOrgTextEmotionResponse
        """
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
        """
        @summary 删除企业文字表情
        
        @param request: DeleteOrgTextEmotionRequest
        @param headers: DeleteOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteOrgTextEmotionResponse
        """
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
        """
        @summary 删除企业文字表情
        
        @param request: DeleteOrgTextEmotionRequest
        @return: DeleteOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders()
        return self.delete_org_text_emotion_with_options(request, headers, runtime)

    async def delete_org_text_emotion_async(
        self,
        request: dingtalkim__1__0_models.DeleteOrgTextEmotionRequest,
    ) -> dingtalkim__1__0_models.DeleteOrgTextEmotionResponse:
        """
        @summary 删除企业文字表情
        
        @param request: DeleteOrgTextEmotionRequest
        @return: DeleteOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DeleteOrgTextEmotionHeaders()
        return await self.delete_org_text_emotion_with_options_async(request, headers, runtime)

    def dismiss_group_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
        headers: dingtalkim__1__0_models.DismissGroupConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        """
        @summary 解散互通群
        
        @param request: DismissGroupConversationRequest
        @param headers: DismissGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DismissGroupConversationResponse
        """
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
        """
        @summary 解散互通群
        
        @param request: DismissGroupConversationRequest
        @param headers: DismissGroupConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DismissGroupConversationResponse
        """
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
        """
        @summary 解散互通群
        
        @param request: DismissGroupConversationRequest
        @return: DismissGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DismissGroupConversationHeaders()
        return self.dismiss_group_conversation_with_options(request, headers, runtime)

    async def dismiss_group_conversation_async(
        self,
        request: dingtalkim__1__0_models.DismissGroupConversationRequest,
    ) -> dingtalkim__1__0_models.DismissGroupConversationResponse:
        """
        @summary 解散互通群
        
        @param request: DismissGroupConversationRequest
        @return: DismissGroupConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.DismissGroupConversationHeaders()
        return await self.dismiss_group_conversation_with_options_async(request, headers, runtime)

    def get_conversation_url_with_options(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
        headers: dingtalkim__1__0_models.GetConversationUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        """
        @summary 创建ToB会话地址
        
        @param request: GetConversationUrlRequest
        @param headers: GetConversationUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationUrlResponse
        """
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
        """
        @summary 创建ToB会话地址
        
        @param request: GetConversationUrlRequest
        @param headers: GetConversationUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationUrlResponse
        """
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
        """
        @summary 创建ToB会话地址
        
        @param request: GetConversationUrlRequest
        @return: GetConversationUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetConversationUrlHeaders()
        return self.get_conversation_url_with_options(request, headers, runtime)

    async def get_conversation_url_async(
        self,
        request: dingtalkim__1__0_models.GetConversationUrlRequest,
    ) -> dingtalkim__1__0_models.GetConversationUrlResponse:
        """
        @summary 创建ToB会话地址
        
        @param request: GetConversationUrlRequest
        @return: GetConversationUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetConversationUrlHeaders()
        return await self.get_conversation_url_with_options_async(request, headers, runtime)

    def get_family_school_conversation_msg_with_options(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        """
        @summary 查询用户家校群消息(图片&视频Z&富文本)
        
        @param request: GetFamilySchoolConversationMsgRequest
        @param headers: GetFamilySchoolConversationMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFamilySchoolConversationMsgResponse
        """
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
        """
        @summary 查询用户家校群消息(图片&视频Z&富文本)
        
        @param request: GetFamilySchoolConversationMsgRequest
        @param headers: GetFamilySchoolConversationMsgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFamilySchoolConversationMsgResponse
        """
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
        """
        @summary 查询用户家校群消息(图片&视频Z&富文本)
        
        @param request: GetFamilySchoolConversationMsgRequest
        @return: GetFamilySchoolConversationMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders()
        return self.get_family_school_conversation_msg_with_options(request, headers, runtime)

    async def get_family_school_conversation_msg_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationMsgRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationMsgResponse:
        """
        @summary 查询用户家校群消息(图片&视频Z&富文本)
        
        @param request: GetFamilySchoolConversationMsgRequest
        @return: GetFamilySchoolConversationMsgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationMsgHeaders()
        return await self.get_family_school_conversation_msg_with_options_async(request, headers, runtime)

    def get_family_school_conversations_with_options(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
        headers: dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        """
        @summary 查询用户家校群
        
        @param request: GetFamilySchoolConversationsRequest
        @param headers: GetFamilySchoolConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFamilySchoolConversationsResponse
        """
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
        """
        @summary 查询用户家校群
        
        @param request: GetFamilySchoolConversationsRequest
        @param headers: GetFamilySchoolConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetFamilySchoolConversationsResponse
        """
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
        """
        @summary 查询用户家校群
        
        @param request: GetFamilySchoolConversationsRequest
        @return: GetFamilySchoolConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders()
        return self.get_family_school_conversations_with_options(request, headers, runtime)

    async def get_family_school_conversations_async(
        self,
        request: dingtalkim__1__0_models.GetFamilySchoolConversationsRequest,
    ) -> dingtalkim__1__0_models.GetFamilySchoolConversationsResponse:
        """
        @summary 查询用户家校群
        
        @param request: GetFamilySchoolConversationsRequest
        @return: GetFamilySchoolConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetFamilySchoolConversationsHeaders()
        return await self.get_family_school_conversations_with_options_async(request, headers, runtime)

    def get_inner_group_members_with_options(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetInnerGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        """
        @summary 查询企业内部群成员
        
        @param request: GetInnerGroupMembersRequest
        @param headers: GetInnerGroupMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInnerGroupMembersResponse
        """
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
        """
        @summary 查询企业内部群成员
        
        @param request: GetInnerGroupMembersRequest
        @param headers: GetInnerGroupMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInnerGroupMembersResponse
        """
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
        """
        @summary 查询企业内部群成员
        
        @param request: GetInnerGroupMembersRequest
        @return: GetInnerGroupMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInnerGroupMembersHeaders()
        return self.get_inner_group_members_with_options(request, headers, runtime)

    async def get_inner_group_members_async(
        self,
        request: dingtalkim__1__0_models.GetInnerGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetInnerGroupMembersResponse:
        """
        @summary 查询企业内部群成员
        
        @param request: GetInnerGroupMembersRequest
        @return: GetInnerGroupMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInnerGroupMembersHeaders()
        return await self.get_inner_group_members_with_options_async(request, headers, runtime)

    def get_interconnection_url_with_options(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
        headers: dingtalkim__1__0_models.GetInterconnectionUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        """
        @summary 创建客联互通会话地址
        
        @param request: GetInterconnectionUrlRequest
        @param headers: GetInterconnectionUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInterconnectionUrlResponse
        """
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
        """
        @summary 创建客联互通会话地址
        
        @param request: GetInterconnectionUrlRequest
        @param headers: GetInterconnectionUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInterconnectionUrlResponse
        """
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
        """
        @summary 创建客联互通会话地址
        
        @param request: GetInterconnectionUrlRequest
        @return: GetInterconnectionUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInterconnectionUrlHeaders()
        return self.get_interconnection_url_with_options(request, headers, runtime)

    async def get_interconnection_url_async(
        self,
        request: dingtalkim__1__0_models.GetInterconnectionUrlRequest,
    ) -> dingtalkim__1__0_models.GetInterconnectionUrlResponse:
        """
        @summary 创建客联互通会话地址
        
        @param request: GetInterconnectionUrlRequest
        @return: GetInterconnectionUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetInterconnectionUrlHeaders()
        return await self.get_interconnection_url_with_options_async(request, headers, runtime)

    def get_newest_inner_groups_with_options(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
        headers: dingtalkim__1__0_models.GetNewestInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: GetNewestInnerGroupsRequest
        @param headers: GetNewestInnerGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNewestInnerGroupsResponse
        """
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
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: GetNewestInnerGroupsRequest
        @param headers: GetNewestInnerGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetNewestInnerGroupsResponse
        """
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
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: GetNewestInnerGroupsRequest
        @return: GetNewestInnerGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetNewestInnerGroupsHeaders()
        return self.get_newest_inner_groups_with_options(request, headers, runtime)

    async def get_newest_inner_groups_async(
        self,
        request: dingtalkim__1__0_models.GetNewestInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.GetNewestInnerGroupsResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: GetNewestInnerGroupsRequest
        @return: GetNewestInnerGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetNewestInnerGroupsHeaders()
        return await self.get_newest_inner_groups_with_options_async(request, headers, runtime)

    def get_scene_group_info_with_options(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        """
        @summary 查询群简要信息
        
        @param request: GetSceneGroupInfoRequest
        @param headers: GetSceneGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupInfoResponse
        """
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
        """
        @summary 查询群简要信息
        
        @param request: GetSceneGroupInfoRequest
        @param headers: GetSceneGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupInfoResponse
        """
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
        """
        @summary 查询群简要信息
        
        @param request: GetSceneGroupInfoRequest
        @return: GetSceneGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupInfoHeaders()
        return self.get_scene_group_info_with_options(request, headers, runtime)

    async def get_scene_group_info_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupInfoRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupInfoResponse:
        """
        @summary 查询群简要信息
        
        @param request: GetSceneGroupInfoRequest
        @return: GetSceneGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupInfoHeaders()
        return await self.get_scene_group_info_with_options_async(request, headers, runtime)

    def get_scene_group_members_with_options(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
        headers: dingtalkim__1__0_models.GetSceneGroupMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        """
        @summary 查询群成员
        
        @param request: GetSceneGroupMembersRequest
        @param headers: GetSceneGroupMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupMembersResponse
        """
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
        """
        @summary 查询群成员
        
        @param request: GetSceneGroupMembersRequest
        @param headers: GetSceneGroupMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupMembersResponse
        """
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
        """
        @summary 查询群成员
        
        @param request: GetSceneGroupMembersRequest
        @return: GetSceneGroupMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupMembersHeaders()
        return self.get_scene_group_members_with_options(request, headers, runtime)

    async def get_scene_group_members_async(
        self,
        request: dingtalkim__1__0_models.GetSceneGroupMembersRequest,
    ) -> dingtalkim__1__0_models.GetSceneGroupMembersResponse:
        """
        @summary 查询群成员
        
        @param request: GetSceneGroupMembersRequest
        @return: GetSceneGroupMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupMembersHeaders()
        return await self.get_scene_group_members_with_options_async(request, headers, runtime)

    def get_scene_group_template_message_open_status_with_options(
        self,
        template_id: str,
        headers: dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 查询场景群模板消息存档能力开启状态
        
        @param headers: GetSceneGroupTemplateMessageOpenStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupTemplateMessageOpenStatusResponse
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
            action='GetSceneGroupTemplateMessageOpenStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/messageOpenStatuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def get_scene_group_template_message_open_status_with_options_async(
        self,
        template_id: str,
        headers: dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 查询场景群模板消息存档能力开启状态
        
        @param headers: GetSceneGroupTemplateMessageOpenStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSceneGroupTemplateMessageOpenStatusResponse
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
            action='GetSceneGroupTemplateMessageOpenStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/messageOpenStatuses',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_scene_group_template_message_open_status(
        self,
        template_id: str,
    ) -> dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 查询场景群模板消息存档能力开启状态
        
        @return: GetSceneGroupTemplateMessageOpenStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusHeaders()
        return self.get_scene_group_template_message_open_status_with_options(template_id, headers, runtime)

    async def get_scene_group_template_message_open_status_async(
        self,
        template_id: str,
    ) -> dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 查询场景群模板消息存档能力开启状态
        
        @return: GetSceneGroupTemplateMessageOpenStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GetSceneGroupTemplateMessageOpenStatusHeaders()
        return await self.get_scene_group_template_message_open_status_with_options_async(template_id, headers, runtime)

    def group_ban_words_with_options(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
        headers: dingtalkim__1__0_models.GroupBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        """
        @summary 群禁言
        
        @param request: GroupBanWordsRequest
        @param headers: GroupBanWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupBanWordsResponse
        """
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
        """
        @summary 群禁言
        
        @param request: GroupBanWordsRequest
        @param headers: GroupBanWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupBanWordsResponse
        """
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
        """
        @summary 群禁言
        
        @param request: GroupBanWordsRequest
        @return: GroupBanWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupBanWordsHeaders()
        return self.group_ban_words_with_options(request, headers, runtime)

    async def group_ban_words_async(
        self,
        request: dingtalkim__1__0_models.GroupBanWordsRequest,
    ) -> dingtalkim__1__0_models.GroupBanWordsResponse:
        """
        @summary 群禁言
        
        @param request: GroupBanWordsRequest
        @return: GroupBanWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupBanWordsHeaders()
        return await self.group_ban_words_with_options_async(request, headers, runtime)

    def group_capacity_inquiry_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
        headers: dingtalkim__1__0_models.GroupCapacityInquiryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        """
        @summary 群容量扩容询价
        
        @param request: GroupCapacityInquiryRequest
        @param headers: GroupCapacityInquiryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityInquiryResponse
        """
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
        """
        @summary 群容量扩容询价
        
        @param request: GroupCapacityInquiryRequest
        @param headers: GroupCapacityInquiryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityInquiryResponse
        """
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
        """
        @summary 群容量扩容询价
        
        @param request: GroupCapacityInquiryRequest
        @return: GroupCapacityInquiryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityInquiryHeaders()
        return self.group_capacity_inquiry_with_options(request, headers, runtime)

    async def group_capacity_inquiry_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityInquiryRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityInquiryResponse:
        """
        @summary 群容量扩容询价
        
        @param request: GroupCapacityInquiryRequest
        @return: GroupCapacityInquiryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityInquiryHeaders()
        return await self.group_capacity_inquiry_with_options_async(request, headers, runtime)

    def group_capacity_order_confirm_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        """
        @summary 群容量扩容确认下单
        
        @param request: GroupCapacityOrderConfirmRequest
        @param headers: GroupCapacityOrderConfirmHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityOrderConfirmResponse
        """
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
        """
        @summary 群容量扩容确认下单
        
        @param request: GroupCapacityOrderConfirmRequest
        @param headers: GroupCapacityOrderConfirmHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityOrderConfirmResponse
        """
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
        """
        @summary 群容量扩容确认下单
        
        @param request: GroupCapacityOrderConfirmRequest
        @return: GroupCapacityOrderConfirmResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders()
        return self.group_capacity_order_confirm_with_options(request, headers, runtime)

    async def group_capacity_order_confirm_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderConfirmRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderConfirmResponse:
        """
        @summary 群容量扩容确认下单
        
        @param request: GroupCapacityOrderConfirmRequest
        @return: GroupCapacityOrderConfirmResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderConfirmHeaders()
        return await self.group_capacity_order_confirm_with_options_async(request, headers, runtime)

    def group_capacity_order_place_with_options(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
        headers: dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        """
        @summary 群容量请求扩容下单
        
        @param request: GroupCapacityOrderPlaceRequest
        @param headers: GroupCapacityOrderPlaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityOrderPlaceResponse
        """
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
        """
        @summary 群容量请求扩容下单
        
        @param request: GroupCapacityOrderPlaceRequest
        @param headers: GroupCapacityOrderPlaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupCapacityOrderPlaceResponse
        """
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
        """
        @summary 群容量请求扩容下单
        
        @param request: GroupCapacityOrderPlaceRequest
        @return: GroupCapacityOrderPlaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders()
        return self.group_capacity_order_place_with_options(request, headers, runtime)

    async def group_capacity_order_place_async(
        self,
        request: dingtalkim__1__0_models.GroupCapacityOrderPlaceRequest,
    ) -> dingtalkim__1__0_models.GroupCapacityOrderPlaceResponse:
        """
        @summary 群容量请求扩容下单
        
        @param request: GroupCapacityOrderPlaceRequest
        @return: GroupCapacityOrderPlaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupCapacityOrderPlaceHeaders()
        return await self.group_capacity_order_place_with_options_async(request, headers, runtime)

    def group_manage_query_with_options(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
        headers: dingtalkim__1__0_models.GroupManageQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        """
        @summary 根据群链接、群号等检索条件，查询群信息
        
        @param request: GroupManageQueryRequest
        @param headers: GroupManageQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupManageQueryResponse
        """
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
        """
        @summary 根据群链接、群号等检索条件，查询群信息
        
        @param request: GroupManageQueryRequest
        @param headers: GroupManageQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupManageQueryResponse
        """
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
        """
        @summary 根据群链接、群号等检索条件，查询群信息
        
        @param request: GroupManageQueryRequest
        @return: GroupManageQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageQueryHeaders()
        return self.group_manage_query_with_options(request, headers, runtime)

    async def group_manage_query_async(
        self,
        request: dingtalkim__1__0_models.GroupManageQueryRequest,
    ) -> dingtalkim__1__0_models.GroupManageQueryResponse:
        """
        @summary 根据群链接、群号等检索条件，查询群信息
        
        @param request: GroupManageQueryRequest
        @return: GroupManageQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageQueryHeaders()
        return await self.group_manage_query_with_options_async(request, headers, runtime)

    def group_manage_reduce_with_options(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
        headers: dingtalkim__1__0_models.GroupManageReduceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        """
        @summary 群管理缩容
        
        @param request: GroupManageReduceRequest
        @param headers: GroupManageReduceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupManageReduceResponse
        """
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
        """
        @summary 群管理缩容
        
        @param request: GroupManageReduceRequest
        @param headers: GroupManageReduceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupManageReduceResponse
        """
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
        """
        @summary 群管理缩容
        
        @param request: GroupManageReduceRequest
        @return: GroupManageReduceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageReduceHeaders()
        return self.group_manage_reduce_with_options(request, headers, runtime)

    async def group_manage_reduce_async(
        self,
        request: dingtalkim__1__0_models.GroupManageReduceRequest,
    ) -> dingtalkim__1__0_models.GroupManageReduceResponse:
        """
        @summary 群管理缩容
        
        @param request: GroupManageReduceRequest
        @return: GroupManageReduceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.GroupManageReduceHeaders()
        return await self.group_manage_reduce_with_options_async(request, headers, runtime)

    def install_robot_to_org_with_options(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
        headers: dingtalkim__1__0_models.InstallRobotToOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        """
        @summary 安装机器人到组织
        
        @param request: InstallRobotToOrgRequest
        @param headers: InstallRobotToOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallRobotToOrgResponse
        """
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
        """
        @summary 安装机器人到组织
        
        @param request: InstallRobotToOrgRequest
        @param headers: InstallRobotToOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InstallRobotToOrgResponse
        """
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
        """
        @summary 安装机器人到组织
        
        @param request: InstallRobotToOrgRequest
        @return: InstallRobotToOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InstallRobotToOrgHeaders()
        return self.install_robot_to_org_with_options(request, headers, runtime)

    async def install_robot_to_org_async(
        self,
        request: dingtalkim__1__0_models.InstallRobotToOrgRequest,
    ) -> dingtalkim__1__0_models.InstallRobotToOrgResponse:
        """
        @summary 安装机器人到组织
        
        @param request: InstallRobotToOrgRequest
        @return: InstallRobotToOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InstallRobotToOrgHeaders()
        return await self.install_robot_to_org_with_options_async(request, headers, runtime)

    def interactive_card_create_instance_with_options(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
        headers: dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        """
        @summary 创建可交互式实例
        
        @param request: InteractiveCardCreateInstanceRequest
        @param headers: InteractiveCardCreateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InteractiveCardCreateInstanceResponse
        """
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
        """
        @summary 创建可交互式实例
        
        @param request: InteractiveCardCreateInstanceRequest
        @param headers: InteractiveCardCreateInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InteractiveCardCreateInstanceResponse
        """
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
        """
        @summary 创建可交互式实例
        
        @param request: InteractiveCardCreateInstanceRequest
        @return: InteractiveCardCreateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders()
        return self.interactive_card_create_instance_with_options(request, headers, runtime)

    async def interactive_card_create_instance_async(
        self,
        request: dingtalkim__1__0_models.InteractiveCardCreateInstanceRequest,
    ) -> dingtalkim__1__0_models.InteractiveCardCreateInstanceResponse:
        """
        @summary 创建可交互式实例
        
        @param request: InteractiveCardCreateInstanceRequest
        @return: InteractiveCardCreateInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.InteractiveCardCreateInstanceHeaders()
        return await self.interactive_card_create_instance_with_options_async(request, headers, runtime)

    def list_org_text_emotion_with_options(
        self,
        headers: dingtalkim__1__0_models.ListOrgTextEmotionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        """
        @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
        
        @param headers: ListOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOrgTextEmotionResponse
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
        """
        @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
        
        @param headers: ListOrgTextEmotionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOrgTextEmotionResponse
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
        """
        @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
        
        @return: ListOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListOrgTextEmotionHeaders()
        return self.list_org_text_emotion_with_options(headers, runtime)

    async def list_org_text_emotion_async(self) -> dingtalkim__1__0_models.ListOrgTextEmotionResponse:
        """
        @summary 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
        
        @return: ListOrgTextEmotionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListOrgTextEmotionHeaders()
        return await self.list_org_text_emotion_with_options_async(headers, runtime)

    def list_scene_groups_by_template_id_with_options(
        self,
        template_id: str,
        request: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdRequest,
        headers: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse:
        """
        @summary 根据模板id查询关联的群
        
        @param request: ListSceneGroupsByTemplateIdRequest
        @param headers: ListSceneGroupsByTemplateIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSceneGroupsByTemplateIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListSceneGroupsByTemplateId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse(),
            self.execute(params, req, runtime)
        )

    async def list_scene_groups_by_template_id_with_options_async(
        self,
        template_id: str,
        request: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdRequest,
        headers: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse:
        """
        @summary 根据模板id查询关联的群
        
        @param request: ListSceneGroupsByTemplateIdRequest
        @param headers: ListSceneGroupsByTemplateIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSceneGroupsByTemplateIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
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
            action='ListSceneGroupsByTemplateId',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/{template_id}/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_scene_groups_by_template_id(
        self,
        template_id: str,
        request: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdRequest,
    ) -> dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse:
        """
        @summary 根据模板id查询关联的群
        
        @param request: ListSceneGroupsByTemplateIdRequest
        @return: ListSceneGroupsByTemplateIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListSceneGroupsByTemplateIdHeaders()
        return self.list_scene_groups_by_template_id_with_options(template_id, request, headers, runtime)

    async def list_scene_groups_by_template_id_async(
        self,
        template_id: str,
        request: dingtalkim__1__0_models.ListSceneGroupsByTemplateIdRequest,
    ) -> dingtalkim__1__0_models.ListSceneGroupsByTemplateIdResponse:
        """
        @summary 根据模板id查询关联的群
        
        @param request: ListSceneGroupsByTemplateIdRequest
        @return: ListSceneGroupsByTemplateIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ListSceneGroupsByTemplateIdHeaders()
        return await self.list_scene_groups_by_template_id_with_options_async(template_id, request, headers, runtime)

    def offline_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.OfflineUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.OfflineUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse:
        """
        @summary 链接增强规则下线
        
        @param request: OfflineUnfurlingRegisterRequest
        @param headers: OfflineUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OfflineUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='OfflineUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def offline_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.OfflineUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.OfflineUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse:
        """
        @summary 链接增强规则下线
        
        @param request: OfflineUnfurlingRegisterRequest
        @param headers: OfflineUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OfflineUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='OfflineUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def offline_unfurling_register(
        self,
        request: dingtalkim__1__0_models.OfflineUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse:
        """
        @summary 链接增强规则下线
        
        @param request: OfflineUnfurlingRegisterRequest
        @return: OfflineUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OfflineUnfurlingRegisterHeaders()
        return self.offline_unfurling_register_with_options(request, headers, runtime)

    async def offline_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.OfflineUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.OfflineUnfurlingRegisterResponse:
        """
        @summary 链接增强规则下线
        
        @param request: OfflineUnfurlingRegisterRequest
        @return: OfflineUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OfflineUnfurlingRegisterHeaders()
        return await self.offline_unfurling_register_with_options_async(request, headers, runtime)

    def open_group_role_add_with_options(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleAddRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleAddResponse:
        """
        @summary 开放场景群新增群角色
        
        @param request: OpenGroupRoleAddRequest
        @param headers: OpenGroupRoleAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
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
            action='OpenGroupRoleAdd',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleAddResponse(),
            self.execute(params, req, runtime)
        )

    async def open_group_role_add_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleAddRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleAddHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleAddResponse:
        """
        @summary 开放场景群新增群角色
        
        @param request: OpenGroupRoleAddRequest
        @param headers: OpenGroupRoleAddHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleAddResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
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
            action='OpenGroupRoleAdd',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleAddResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_group_role_add(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleAddRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleAddResponse:
        """
        @summary 开放场景群新增群角色
        
        @param request: OpenGroupRoleAddRequest
        @return: OpenGroupRoleAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleAddHeaders()
        return self.open_group_role_add_with_options(request, headers, runtime)

    async def open_group_role_add_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleAddRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleAddResponse:
        """
        @summary 开放场景群新增群角色
        
        @param request: OpenGroupRoleAddRequest
        @return: OpenGroupRoleAddResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleAddHeaders()
        return await self.open_group_role_add_with_options_async(request, headers, runtime)

    def open_group_role_query_with_options(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleQueryRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleQueryResponse:
        """
        @summary 开放场景群群角色查询
        
        @param request: OpenGroupRoleQueryRequest
        @param headers: OpenGroupRoleQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleQueryResponse
        """
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
            action='OpenGroupRoleQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def open_group_role_query_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleQueryRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleQueryResponse:
        """
        @summary 开放场景群群角色查询
        
        @param request: OpenGroupRoleQueryRequest
        @param headers: OpenGroupRoleQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleQueryResponse
        """
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
            action='OpenGroupRoleQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_group_role_query(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleQueryRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleQueryResponse:
        """
        @summary 开放场景群群角色查询
        
        @param request: OpenGroupRoleQueryRequest
        @return: OpenGroupRoleQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleQueryHeaders()
        return self.open_group_role_query_with_options(request, headers, runtime)

    async def open_group_role_query_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleQueryRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleQueryResponse:
        """
        @summary 开放场景群群角色查询
        
        @param request: OpenGroupRoleQueryRequest
        @return: OpenGroupRoleQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleQueryHeaders()
        return await self.open_group_role_query_with_options_async(request, headers, runtime)

    def open_group_role_remove_with_options(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleRemoveRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleRemoveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleRemoveResponse:
        """
        @summary 开放场景群群角色移除
        
        @param request: OpenGroupRoleRemoveRequest
        @param headers: OpenGroupRoleRemoveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleRemoveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
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
            action='OpenGroupRoleRemove',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleRemoveResponse(),
            self.execute(params, req, runtime)
        )

    async def open_group_role_remove_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleRemoveRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleRemoveHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleRemoveResponse:
        """
        @summary 开放场景群群角色移除
        
        @param request: OpenGroupRoleRemoveRequest
        @param headers: OpenGroupRoleRemoveHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleRemoveResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
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
            action='OpenGroupRoleRemove',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleRemoveResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_group_role_remove(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleRemoveRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleRemoveResponse:
        """
        @summary 开放场景群群角色移除
        
        @param request: OpenGroupRoleRemoveRequest
        @return: OpenGroupRoleRemoveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleRemoveHeaders()
        return self.open_group_role_remove_with_options(request, headers, runtime)

    async def open_group_role_remove_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleRemoveRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleRemoveResponse:
        """
        @summary 开放场景群群角色移除
        
        @param request: OpenGroupRoleRemoveRequest
        @return: OpenGroupRoleRemoveResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleRemoveHeaders()
        return await self.open_group_role_remove_with_options_async(request, headers, runtime)

    def open_group_role_update_with_options(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleUpdateRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleUpdateResponse:
        """
        @summary 开放场景群群角色变更
        
        @param request: OpenGroupRoleUpdateRequest
        @param headers: OpenGroupRoleUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
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
            action='OpenGroupRoleUpdate',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleUpdateResponse(),
            self.execute(params, req, runtime)
        )

    async def open_group_role_update_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleUpdateRequest,
        headers: dingtalkim__1__0_models.OpenGroupRoleUpdateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupRoleUpdateResponse:
        """
        @summary 开放场景群群角色变更
        
        @param request: OpenGroupRoleUpdateRequest
        @param headers: OpenGroupRoleUpdateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupRoleUpdateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_role_id):
            body['openRoleId'] = request.open_role_id
        if not UtilClient.is_unset(request.role_name):
            body['roleName'] = request.role_name
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
            action='OpenGroupRoleUpdate',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/roles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupRoleUpdateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_group_role_update(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleUpdateRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleUpdateResponse:
        """
        @summary 开放场景群群角色变更
        
        @param request: OpenGroupRoleUpdateRequest
        @return: OpenGroupRoleUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleUpdateHeaders()
        return self.open_group_role_update_with_options(request, headers, runtime)

    async def open_group_role_update_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupRoleUpdateRequest,
    ) -> dingtalkim__1__0_models.OpenGroupRoleUpdateResponse:
        """
        @summary 开放场景群群角色变更
        
        @param request: OpenGroupRoleUpdateRequest
        @return: OpenGroupRoleUpdateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupRoleUpdateHeaders()
        return await self.open_group_role_update_with_options_async(request, headers, runtime)

    def open_group_user_role_query_with_options(
        self,
        request: dingtalkim__1__0_models.OpenGroupUserRoleQueryRequest,
        headers: dingtalkim__1__0_models.OpenGroupUserRoleQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse:
        """
        @summary 开放场景群群成员的群角色信息查询
        
        @param request: OpenGroupUserRoleQueryRequest
        @param headers: OpenGroupUserRoleQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupUserRoleQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.viewed_user_id):
            body['viewedUserId'] = request.viewed_user_id
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
            action='OpenGroupUserRoleQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/users/roles/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse(),
            self.execute(params, req, runtime)
        )

    async def open_group_user_role_query_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupUserRoleQueryRequest,
        headers: dingtalkim__1__0_models.OpenGroupUserRoleQueryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse:
        """
        @summary 开放场景群群成员的群角色信息查询
        
        @param request: OpenGroupUserRoleQueryRequest
        @param headers: OpenGroupUserRoleQueryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenGroupUserRoleQueryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.user_id):
            body['userId'] = request.user_id
        if not UtilClient.is_unset(request.viewed_user_id):
            body['viewedUserId'] = request.viewed_user_id
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
            action='OpenGroupUserRoleQuery',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/users/roles/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_group_user_role_query(
        self,
        request: dingtalkim__1__0_models.OpenGroupUserRoleQueryRequest,
    ) -> dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse:
        """
        @summary 开放场景群群成员的群角色信息查询
        
        @param request: OpenGroupUserRoleQueryRequest
        @return: OpenGroupUserRoleQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupUserRoleQueryHeaders()
        return self.open_group_user_role_query_with_options(request, headers, runtime)

    async def open_group_user_role_query_async(
        self,
        request: dingtalkim__1__0_models.OpenGroupUserRoleQueryRequest,
    ) -> dingtalkim__1__0_models.OpenGroupUserRoleQueryResponse:
        """
        @summary 开放场景群群成员的群角色信息查询
        
        @param request: OpenGroupUserRoleQueryRequest
        @return: OpenGroupUserRoleQueryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenGroupUserRoleQueryHeaders()
        return await self.open_group_user_role_query_with_options_async(request, headers, runtime)

    def open_inner_group_transfer_to_dept_group_with_options(
        self,
        request: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupRequest,
        headers: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse:
        """
        @summary 内部群转部门群
        
        @param request: OpenInnerGroupTransferToDeptGroupRequest
        @param headers: OpenInnerGroupTransferToDeptGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenInnerGroupTransferToDeptGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='OpenInnerGroupTransferToDeptGroup',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/transferToDeptGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def open_inner_group_transfer_to_dept_group_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupRequest,
        headers: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse:
        """
        @summary 内部群转部门群
        
        @param request: OpenInnerGroupTransferToDeptGroupRequest
        @param headers: OpenInnerGroupTransferToDeptGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenInnerGroupTransferToDeptGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
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
            action='OpenInnerGroupTransferToDeptGroup',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/transferToDeptGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_inner_group_transfer_to_dept_group(
        self,
        request: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupRequest,
    ) -> dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse:
        """
        @summary 内部群转部门群
        
        @param request: OpenInnerGroupTransferToDeptGroupRequest
        @return: OpenInnerGroupTransferToDeptGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupHeaders()
        return self.open_inner_group_transfer_to_dept_group_with_options(request, headers, runtime)

    async def open_inner_group_transfer_to_dept_group_async(
        self,
        request: dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupRequest,
    ) -> dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupResponse:
        """
        @summary 内部群转部门群
        
        @param request: OpenInnerGroupTransferToDeptGroupRequest
        @return: OpenInnerGroupTransferToDeptGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenInnerGroupTransferToDeptGroupHeaders()
        return await self.open_inner_group_transfer_to_dept_group_with_options_async(request, headers, runtime)

    def open_search_group_list_with_options(
        self,
        request: dingtalkim__1__0_models.OpenSearchGroupListRequest,
        headers: dingtalkim__1__0_models.OpenSearchGroupListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenSearchGroupListResponse:
        """
        @summary 群搜索
        
        @param request: OpenSearchGroupListRequest
        @param headers: OpenSearchGroupListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenSearchGroupListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='OpenSearchGroupList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenSearchGroupListResponse(),
            self.execute(params, req, runtime)
        )

    async def open_search_group_list_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenSearchGroupListRequest,
        headers: dingtalkim__1__0_models.OpenSearchGroupListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenSearchGroupListResponse:
        """
        @summary 群搜索
        
        @param request: OpenSearchGroupListRequest
        @param headers: OpenSearchGroupListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenSearchGroupListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
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
            action='OpenSearchGroupList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenSearchGroupListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_search_group_list(
        self,
        request: dingtalkim__1__0_models.OpenSearchGroupListRequest,
    ) -> dingtalkim__1__0_models.OpenSearchGroupListResponse:
        """
        @summary 群搜索
        
        @param request: OpenSearchGroupListRequest
        @return: OpenSearchGroupListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenSearchGroupListHeaders()
        return self.open_search_group_list_with_options(request, headers, runtime)

    async def open_search_group_list_async(
        self,
        request: dingtalkim__1__0_models.OpenSearchGroupListRequest,
    ) -> dingtalkim__1__0_models.OpenSearchGroupListResponse:
        """
        @summary 群搜索
        
        @param request: OpenSearchGroupListRequest
        @return: OpenSearchGroupListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenSearchGroupListHeaders()
        return await self.open_search_group_list_with_options_async(request, headers, runtime)

    def open_user_send_card_message_with_options(
        self,
        request: dingtalkim__1__0_models.OpenUserSendCardMessageRequest,
        headers: dingtalkim__1__0_models.OpenUserSendCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenUserSendCardMessageResponse:
        """
        @summary 以个人身份发送卡片消息
        
        @param request: OpenUserSendCardMessageRequest
        @param headers: OpenUserSendCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenUserSendCardMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_content):
            body['cardContent'] = request.card_content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receive_user_id):
            body['receiveUserId'] = request.receive_user_id
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
            action='OpenUserSendCardMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/cardMessages/users/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenUserSendCardMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def open_user_send_card_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.OpenUserSendCardMessageRequest,
        headers: dingtalkim__1__0_models.OpenUserSendCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.OpenUserSendCardMessageResponse:
        """
        @summary 以个人身份发送卡片消息
        
        @param request: OpenUserSendCardMessageRequest
        @param headers: OpenUserSendCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenUserSendCardMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_content):
            body['cardContent'] = request.card_content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receive_user_id):
            body['receiveUserId'] = request.receive_user_id
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
            action='OpenUserSendCardMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/cardMessages/users/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.OpenUserSendCardMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_user_send_card_message(
        self,
        request: dingtalkim__1__0_models.OpenUserSendCardMessageRequest,
    ) -> dingtalkim__1__0_models.OpenUserSendCardMessageResponse:
        """
        @summary 以个人身份发送卡片消息
        
        @param request: OpenUserSendCardMessageRequest
        @return: OpenUserSendCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenUserSendCardMessageHeaders()
        return self.open_user_send_card_message_with_options(request, headers, runtime)

    async def open_user_send_card_message_async(
        self,
        request: dingtalkim__1__0_models.OpenUserSendCardMessageRequest,
    ) -> dingtalkim__1__0_models.OpenUserSendCardMessageResponse:
        """
        @summary 以个人身份发送卡片消息
        
        @param request: OpenUserSendCardMessageRequest
        @return: OpenUserSendCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.OpenUserSendCardMessageHeaders()
        return await self.open_user_send_card_message_with_options_async(request, headers, runtime)

    def personal_send_card_message_with_options(
        self,
        request: dingtalkim__1__0_models.PersonalSendCardMessageRequest,
        headers: dingtalkim__1__0_models.PersonalSendCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.PersonalSendCardMessageResponse:
        """
        @summary 以用户身份发送卡片消息
        
        @param request: PersonalSendCardMessageRequest
        @param headers: PersonalSendCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PersonalSendCardMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_user_ids):
            body['atUserIds'] = request.at_user_ids
        if not UtilClient.is_unset(request.card_content):
            body['cardContent'] = request.card_content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receive_user_id):
            body['receiveUserId'] = request.receive_user_id
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
            action='PersonalSendCardMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.PersonalSendCardMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def personal_send_card_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.PersonalSendCardMessageRequest,
        headers: dingtalkim__1__0_models.PersonalSendCardMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.PersonalSendCardMessageResponse:
        """
        @summary 以用户身份发送卡片消息
        
        @param request: PersonalSendCardMessageRequest
        @param headers: PersonalSendCardMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PersonalSendCardMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.at_user_ids):
            body['atUserIds'] = request.at_user_ids
        if not UtilClient.is_unset(request.card_content):
            body['cardContent'] = request.card_content
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receive_user_id):
            body['receiveUserId'] = request.receive_user_id
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
            action='PersonalSendCardMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/cards/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.PersonalSendCardMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def personal_send_card_message(
        self,
        request: dingtalkim__1__0_models.PersonalSendCardMessageRequest,
    ) -> dingtalkim__1__0_models.PersonalSendCardMessageResponse:
        """
        @summary 以用户身份发送卡片消息
        
        @param request: PersonalSendCardMessageRequest
        @return: PersonalSendCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.PersonalSendCardMessageHeaders()
        return self.personal_send_card_message_with_options(request, headers, runtime)

    async def personal_send_card_message_async(
        self,
        request: dingtalkim__1__0_models.PersonalSendCardMessageRequest,
    ) -> dingtalkim__1__0_models.PersonalSendCardMessageResponse:
        """
        @summary 以用户身份发送卡片消息
        
        @param request: PersonalSendCardMessageRequest
        @return: PersonalSendCardMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.PersonalSendCardMessageHeaders()
        return await self.personal_send_card_message_with_options_async(request, headers, runtime)

    def query_group_info_by_member_auth_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        """
        @summary 成员授权场景下查询群信息
        
        @param request: QueryGroupInfoByMemberAuthRequest
        @param headers: QueryGroupInfoByMemberAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupInfoByMemberAuthResponse
        """
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
        """
        @summary 成员授权场景下查询群信息
        
        @param request: QueryGroupInfoByMemberAuthRequest
        @param headers: QueryGroupInfoByMemberAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupInfoByMemberAuthResponse
        """
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
        """
        @summary 成员授权场景下查询群信息
        
        @param request: QueryGroupInfoByMemberAuthRequest
        @return: QueryGroupInfoByMemberAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders()
        return self.query_group_info_by_member_auth_with_options(request, headers, runtime)

    async def query_group_info_by_member_auth_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupInfoByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupInfoByMemberAuthResponse:
        """
        @summary 成员授权场景下查询群信息
        
        @param request: QueryGroupInfoByMemberAuthRequest
        @return: QueryGroupInfoByMemberAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupInfoByMemberAuthHeaders()
        return await self.query_group_info_by_member_auth_with_options_async(request, headers, runtime)

    def query_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询群成员列表
        
        @param request: QueryGroupMemberRequest
        @param headers: QueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberResponse
        """
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
        """
        @summary 查询群成员列表
        
        @param request: QueryGroupMemberRequest
        @param headers: QueryGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberResponse
        """
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
        """
        @summary 查询群成员列表
        
        @param request: QueryGroupMemberRequest
        @return: QueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberHeaders()
        return self.query_group_member_with_options(request, headers, runtime)

    async def query_group_member_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberResponse:
        """
        @summary 查询群成员列表
        
        @param request: QueryGroupMemberRequest
        @return: QueryGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberHeaders()
        return await self.query_group_member_with_options_async(request, headers, runtime)

    def query_group_member_by_member_auth_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
        headers: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        """
        @summary 成员授权场景下查询群成员
        
        @param request: QueryGroupMemberByMemberAuthRequest
        @param headers: QueryGroupMemberByMemberAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberByMemberAuthResponse
        """
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
        """
        @summary 成员授权场景下查询群成员
        
        @param request: QueryGroupMemberByMemberAuthRequest
        @param headers: QueryGroupMemberByMemberAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMemberByMemberAuthResponse
        """
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
        """
        @summary 成员授权场景下查询群成员
        
        @param request: QueryGroupMemberByMemberAuthRequest
        @return: QueryGroupMemberByMemberAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders()
        return self.query_group_member_by_member_auth_with_options(request, headers, runtime)

    async def query_group_member_by_member_auth_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMemberByMemberAuthRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMemberByMemberAuthResponse:
        """
        @summary 成员授权场景下查询群成员
        
        @param request: QueryGroupMemberByMemberAuthRequest
        @return: QueryGroupMemberByMemberAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMemberByMemberAuthHeaders()
        return await self.query_group_member_by_member_auth_with_options_async(request, headers, runtime)

    def query_group_mute_status_with_options(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
        headers: dingtalkim__1__0_models.QueryGroupMuteStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        """
        @summary 查询群禁言状态
        
        @param request: QueryGroupMuteStatusRequest
        @param headers: QueryGroupMuteStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMuteStatusResponse
        """
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
        """
        @summary 查询群禁言状态
        
        @param request: QueryGroupMuteStatusRequest
        @param headers: QueryGroupMuteStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryGroupMuteStatusResponse
        """
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
        """
        @summary 查询群禁言状态
        
        @param request: QueryGroupMuteStatusRequest
        @return: QueryGroupMuteStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMuteStatusHeaders()
        return self.query_group_mute_status_with_options(request, headers, runtime)

    async def query_group_mute_status_async(
        self,
        request: dingtalkim__1__0_models.QueryGroupMuteStatusRequest,
    ) -> dingtalkim__1__0_models.QueryGroupMuteStatusResponse:
        """
        @summary 查询群禁言状态
        
        @param request: QueryGroupMuteStatusRequest
        @return: QueryGroupMuteStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryGroupMuteStatusHeaders()
        return await self.query_group_mute_status_with_options_async(request, headers, runtime)

    def query_inner_group_member_list_with_options(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupMemberListRequest,
        headers: dingtalkim__1__0_models.QueryInnerGroupMemberListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryInnerGroupMemberListResponse:
        """
        @summary 读取群成员列表
        
        @param request: QueryInnerGroupMemberListRequest
        @param headers: QueryInnerGroupMemberListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInnerGroupMemberListResponse
        """
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
            action='QueryInnerGroupMemberList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/memberLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryInnerGroupMemberListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_inner_group_member_list_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupMemberListRequest,
        headers: dingtalkim__1__0_models.QueryInnerGroupMemberListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryInnerGroupMemberListResponse:
        """
        @summary 读取群成员列表
        
        @param request: QueryInnerGroupMemberListRequest
        @param headers: QueryInnerGroupMemberListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInnerGroupMemberListResponse
        """
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
            action='QueryInnerGroupMemberList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/memberLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryInnerGroupMemberListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_inner_group_member_list(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupMemberListRequest,
    ) -> dingtalkim__1__0_models.QueryInnerGroupMemberListResponse:
        """
        @summary 读取群成员列表
        
        @param request: QueryInnerGroupMemberListRequest
        @return: QueryInnerGroupMemberListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryInnerGroupMemberListHeaders()
        return self.query_inner_group_member_list_with_options(request, headers, runtime)

    async def query_inner_group_member_list_async(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupMemberListRequest,
    ) -> dingtalkim__1__0_models.QueryInnerGroupMemberListResponse:
        """
        @summary 读取群成员列表
        
        @param request: QueryInnerGroupMemberListRequest
        @return: QueryInnerGroupMemberListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryInnerGroupMemberListHeaders()
        return await self.query_inner_group_member_list_with_options_async(request, headers, runtime)

    def query_inner_group_recent_list_with_options(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupRecentListRequest,
        headers: dingtalkim__1__0_models.QueryInnerGroupRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryInnerGroupRecentListResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: QueryInnerGroupRecentListRequest
        @param headers: QueryInnerGroupRecentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInnerGroupRecentListResponse
        """
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
            action='QueryInnerGroupRecentList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/recentLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryInnerGroupRecentListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_inner_group_recent_list_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupRecentListRequest,
        headers: dingtalkim__1__0_models.QueryInnerGroupRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryInnerGroupRecentListResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: QueryInnerGroupRecentListRequest
        @param headers: QueryInnerGroupRecentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryInnerGroupRecentListResponse
        """
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
            action='QueryInnerGroupRecentList',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/innerGroups/recentLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryInnerGroupRecentListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_inner_group_recent_list(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupRecentListRequest,
    ) -> dingtalkim__1__0_models.QueryInnerGroupRecentListResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: QueryInnerGroupRecentListRequest
        @return: QueryInnerGroupRecentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryInnerGroupRecentListHeaders()
        return self.query_inner_group_recent_list_with_options(request, headers, runtime)

    async def query_inner_group_recent_list_async(
        self,
        request: dingtalkim__1__0_models.QueryInnerGroupRecentListRequest,
    ) -> dingtalkim__1__0_models.QueryInnerGroupRecentListResponse:
        """
        @summary 查询最近活跃的企业内部群列表
        
        @param request: QueryInnerGroupRecentListRequest
        @return: QueryInnerGroupRecentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryInnerGroupRecentListHeaders()
        return await self.query_inner_group_recent_list_with_options_async(request, headers, runtime)

    def query_members_of_group_role_with_options(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
        headers: dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        """
        @summary 查询群内具有指定群角色的所有群成员
        
        @param request: QueryMembersOfGroupRoleRequest
        @param headers: QueryMembersOfGroupRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMembersOfGroupRoleResponse
        """
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
        """
        @summary 查询群内具有指定群角色的所有群成员
        
        @param request: QueryMembersOfGroupRoleRequest
        @param headers: QueryMembersOfGroupRoleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMembersOfGroupRoleResponse
        """
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
        """
        @summary 查询群内具有指定群角色的所有群成员
        
        @param request: QueryMembersOfGroupRoleRequest
        @return: QueryMembersOfGroupRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders()
        return self.query_members_of_group_role_with_options(request, headers, runtime)

    async def query_members_of_group_role_async(
        self,
        request: dingtalkim__1__0_models.QueryMembersOfGroupRoleRequest,
    ) -> dingtalkim__1__0_models.QueryMembersOfGroupRoleResponse:
        """
        @summary 查询群内具有指定群角色的所有群成员
        
        @param request: QueryMembersOfGroupRoleRequest
        @return: QueryMembersOfGroupRoleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMembersOfGroupRoleHeaders()
        return await self.query_members_of_group_role_with_options_async(request, headers, runtime)

    def query_message_send_result_with_options(
        self,
        request: dingtalkim__1__0_models.QueryMessageSendResultRequest,
        headers: dingtalkim__1__0_models.QueryMessageSendResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryMessageSendResultResponse:
        """
        @summary 根据openTaskId查询消息发送结果
        
        @param request: QueryMessageSendResultRequest
        @param headers: QueryMessageSendResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMessageSendResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_task_id):
            body['openTaskId'] = request.open_task_id
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
            action='QueryMessageSendResult',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/messages/sendResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMessageSendResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_message_send_result_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryMessageSendResultRequest,
        headers: dingtalkim__1__0_models.QueryMessageSendResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryMessageSendResultResponse:
        """
        @summary 根据openTaskId查询消息发送结果
        
        @param request: QueryMessageSendResultRequest
        @param headers: QueryMessageSendResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMessageSendResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_task_id):
            body['openTaskId'] = request.open_task_id
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
            action='QueryMessageSendResult',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/messages/sendResults/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryMessageSendResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_message_send_result(
        self,
        request: dingtalkim__1__0_models.QueryMessageSendResultRequest,
    ) -> dingtalkim__1__0_models.QueryMessageSendResultResponse:
        """
        @summary 根据openTaskId查询消息发送结果
        
        @param request: QueryMessageSendResultRequest
        @return: QueryMessageSendResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMessageSendResultHeaders()
        return self.query_message_send_result_with_options(request, headers, runtime)

    async def query_message_send_result_async(
        self,
        request: dingtalkim__1__0_models.QueryMessageSendResultRequest,
    ) -> dingtalkim__1__0_models.QueryMessageSendResultResponse:
        """
        @summary 根据openTaskId查询消息发送结果
        
        @param request: QueryMessageSendResultRequest
        @return: QueryMessageSendResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryMessageSendResultHeaders()
        return await self.query_message_send_result_with_options_async(request, headers, runtime)

    def query_open_conversation_receive_user_with_options(
        self,
        request: dingtalkim__1__0_models.QueryOpenConversationReceiveUserRequest,
        headers: dingtalkim__1__0_models.QueryOpenConversationReceiveUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse:
        """
        @summary  根据单聊会话及发送方获取接收方用户信息
        
        @param request: QueryOpenConversationReceiveUserRequest
        @param headers: QueryOpenConversationReceiveUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOpenConversationReceiveUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.send_user_id):
            body['sendUserId'] = request.send_user_id
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
            action='QueryOpenConversationReceiveUser',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/otoChat/receiveUsers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse(),
            self.execute(params, req, runtime)
        )

    async def query_open_conversation_receive_user_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryOpenConversationReceiveUserRequest,
        headers: dingtalkim__1__0_models.QueryOpenConversationReceiveUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse:
        """
        @summary  根据单聊会话及发送方获取接收方用户信息
        
        @param request: QueryOpenConversationReceiveUserRequest
        @param headers: QueryOpenConversationReceiveUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOpenConversationReceiveUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.send_user_id):
            body['sendUserId'] = request.send_user_id
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
            action='QueryOpenConversationReceiveUser',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/otoChat/receiveUsers/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_open_conversation_receive_user(
        self,
        request: dingtalkim__1__0_models.QueryOpenConversationReceiveUserRequest,
    ) -> dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse:
        """
        @summary  根据单聊会话及发送方获取接收方用户信息
        
        @param request: QueryOpenConversationReceiveUserRequest
        @return: QueryOpenConversationReceiveUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryOpenConversationReceiveUserHeaders()
        return self.query_open_conversation_receive_user_with_options(request, headers, runtime)

    async def query_open_conversation_receive_user_async(
        self,
        request: dingtalkim__1__0_models.QueryOpenConversationReceiveUserRequest,
    ) -> dingtalkim__1__0_models.QueryOpenConversationReceiveUserResponse:
        """
        @summary  根据单聊会话及发送方获取接收方用户信息
        
        @param request: QueryOpenConversationReceiveUserRequest
        @return: QueryOpenConversationReceiveUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryOpenConversationReceiveUserHeaders()
        return await self.query_open_conversation_receive_user_with_options_async(request, headers, runtime)

    def query_open_group_base_info_with_options(
        self,
        request: dingtalkim__1__0_models.QueryOpenGroupBaseInfoRequest,
        headers: dingtalkim__1__0_models.QueryOpenGroupBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse:
        """
        @summary 获取群基础信息
        
        @param request: QueryOpenGroupBaseInfoRequest
        @param headers: QueryOpenGroupBaseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOpenGroupBaseInfoResponse
        """
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
            action='QueryOpenGroupBaseInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/baseInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_open_group_base_info_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryOpenGroupBaseInfoRequest,
        headers: dingtalkim__1__0_models.QueryOpenGroupBaseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse:
        """
        @summary 获取群基础信息
        
        @param request: QueryOpenGroupBaseInfoRequest
        @param headers: QueryOpenGroupBaseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryOpenGroupBaseInfoResponse
        """
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
            action='QueryOpenGroupBaseInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/groups/baseInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_open_group_base_info(
        self,
        request: dingtalkim__1__0_models.QueryOpenGroupBaseInfoRequest,
    ) -> dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse:
        """
        @summary 获取群基础信息
        
        @param request: QueryOpenGroupBaseInfoRequest
        @return: QueryOpenGroupBaseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryOpenGroupBaseInfoHeaders()
        return self.query_open_group_base_info_with_options(request, headers, runtime)

    async def query_open_group_base_info_async(
        self,
        request: dingtalkim__1__0_models.QueryOpenGroupBaseInfoRequest,
    ) -> dingtalkim__1__0_models.QueryOpenGroupBaseInfoResponse:
        """
        @summary 获取群基础信息
        
        @param request: QueryOpenGroupBaseInfoRequest
        @return: QueryOpenGroupBaseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryOpenGroupBaseInfoHeaders()
        return await self.query_open_group_base_info_with_options_async(request, headers, runtime)

    def query_personal_message_read_status_with_options(
        self,
        request: dingtalkim__1__0_models.QueryPersonalMessageReadStatusRequest,
        headers: dingtalkim__1__0_models.QueryPersonalMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse:
        """
        @summary 用户身份查询消息已读未读状态
        
        @param request: QueryPersonalMessageReadStatusRequest
        @param headers: QueryPersonalMessageReadStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPersonalMessageReadStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_message_id):
            body['openMessageId'] = request.open_message_id
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
            action='QueryPersonalMessageReadStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/readStatuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_personal_message_read_status_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryPersonalMessageReadStatusRequest,
        headers: dingtalkim__1__0_models.QueryPersonalMessageReadStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse:
        """
        @summary 用户身份查询消息已读未读状态
        
        @param request: QueryPersonalMessageReadStatusRequest
        @param headers: QueryPersonalMessageReadStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPersonalMessageReadStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_message_id):
            body['openMessageId'] = request.open_message_id
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
            action='QueryPersonalMessageReadStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/readStatuses/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_personal_message_read_status(
        self,
        request: dingtalkim__1__0_models.QueryPersonalMessageReadStatusRequest,
    ) -> dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse:
        """
        @summary 用户身份查询消息已读未读状态
        
        @param request: QueryPersonalMessageReadStatusRequest
        @return: QueryPersonalMessageReadStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryPersonalMessageReadStatusHeaders()
        return self.query_personal_message_read_status_with_options(request, headers, runtime)

    async def query_personal_message_read_status_async(
        self,
        request: dingtalkim__1__0_models.QueryPersonalMessageReadStatusRequest,
    ) -> dingtalkim__1__0_models.QueryPersonalMessageReadStatusResponse:
        """
        @summary 用户身份查询消息已读未读状态
        
        @param request: QueryPersonalMessageReadStatusRequest
        @return: QueryPersonalMessageReadStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryPersonalMessageReadStatusHeaders()
        return await self.query_personal_message_read_status_with_options_async(request, headers, runtime)

    def query_recent_conversations_with_options(
        self,
        request: dingtalkim__1__0_models.QueryRecentConversationsRequest,
        headers: dingtalkim__1__0_models.QueryRecentConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryRecentConversationsResponse:
        """
        @summary 获取最近联系人及群组
        
        @param request: QueryRecentConversationsRequest
        @param headers: QueryRecentConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecentConversationsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.only_human):
            body['onlyHuman'] = request.only_human
        if not UtilClient.is_unset(request.only_inner_group):
            body['onlyInnerGroup'] = request.only_inner_group
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
            action='QueryRecentConversations',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/recentLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryRecentConversationsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_recent_conversations_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryRecentConversationsRequest,
        headers: dingtalkim__1__0_models.QueryRecentConversationsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryRecentConversationsResponse:
        """
        @summary 获取最近联系人及群组
        
        @param request: QueryRecentConversationsRequest
        @param headers: QueryRecentConversationsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecentConversationsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.only_human):
            body['onlyHuman'] = request.only_human
        if not UtilClient.is_unset(request.only_inner_group):
            body['onlyInnerGroup'] = request.only_inner_group
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
            action='QueryRecentConversations',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/conversations/recentLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryRecentConversationsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_recent_conversations(
        self,
        request: dingtalkim__1__0_models.QueryRecentConversationsRequest,
    ) -> dingtalkim__1__0_models.QueryRecentConversationsResponse:
        """
        @summary 获取最近联系人及群组
        
        @param request: QueryRecentConversationsRequest
        @return: QueryRecentConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryRecentConversationsHeaders()
        return self.query_recent_conversations_with_options(request, headers, runtime)

    async def query_recent_conversations_async(
        self,
        request: dingtalkim__1__0_models.QueryRecentConversationsRequest,
    ) -> dingtalkim__1__0_models.QueryRecentConversationsResponse:
        """
        @summary 获取最近联系人及群组
        
        @param request: QueryRecentConversationsRequest
        @return: QueryRecentConversationsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryRecentConversationsHeaders()
        return await self.query_recent_conversations_with_options_async(request, headers, runtime)

    def query_scene_group_template_robot_with_options(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
        headers: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        """
        @summary 查询群内群模板机器人
        
        @param request: QuerySceneGroupTemplateRobotRequest
        @param headers: QuerySceneGroupTemplateRobotHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySceneGroupTemplateRobotResponse
        """
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
        """
        @summary 查询群内群模板机器人
        
        @param request: QuerySceneGroupTemplateRobotRequest
        @param headers: QuerySceneGroupTemplateRobotHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySceneGroupTemplateRobotResponse
        """
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
        """
        @summary 查询群内群模板机器人
        
        @param request: QuerySceneGroupTemplateRobotRequest
        @return: QuerySceneGroupTemplateRobotResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders()
        return self.query_scene_group_template_robot_with_options(request, headers, runtime)

    async def query_scene_group_template_robot_async(
        self,
        request: dingtalkim__1__0_models.QuerySceneGroupTemplateRobotRequest,
    ) -> dingtalkim__1__0_models.QuerySceneGroupTemplateRobotResponse:
        """
        @summary 查询群内群模板机器人
        
        @param request: QuerySceneGroupTemplateRobotRequest
        @return: QuerySceneGroupTemplateRobotResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySceneGroupTemplateRobotHeaders()
        return await self.query_scene_group_template_robot_with_options_async(request, headers, runtime)

    def query_single_group_with_options(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
        headers: dingtalkim__1__0_models.QuerySingleGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        """
        @summary 批量查询群信息
        
        @param request: QuerySingleGroupRequest
        @param headers: QuerySingleGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySingleGroupResponse
        """
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
        """
        @summary 批量查询群信息
        
        @param request: QuerySingleGroupRequest
        @param headers: QuerySingleGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySingleGroupResponse
        """
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
        """
        @summary 批量查询群信息
        
        @param request: QuerySingleGroupRequest
        @return: QuerySingleGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySingleGroupHeaders()
        return self.query_single_group_with_options(request, headers, runtime)

    async def query_single_group_async(
        self,
        request: dingtalkim__1__0_models.QuerySingleGroupRequest,
    ) -> dingtalkim__1__0_models.QuerySingleGroupResponse:
        """
        @summary 批量查询群信息
        
        @param request: QuerySingleGroupRequest
        @return: QuerySingleGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QuerySingleGroupHeaders()
        return await self.query_single_group_with_options_async(request, headers, runtime)

    def query_un_read_message_with_options(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
        headers: dingtalkim__1__0_models.QueryUnReadMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        """
        @summary 批量查询未读消息数
        
        @param request: QueryUnReadMessageRequest
        @param headers: QueryUnReadMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnReadMessageResponse
        """
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
        """
        @summary 批量查询未读消息数
        
        @param request: QueryUnReadMessageRequest
        @param headers: QueryUnReadMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnReadMessageResponse
        """
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
        """
        @summary 批量查询未读消息数
        
        @param request: QueryUnReadMessageRequest
        @return: QueryUnReadMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnReadMessageHeaders()
        return self.query_un_read_message_with_options(request, headers, runtime)

    async def query_un_read_message_async(
        self,
        request: dingtalkim__1__0_models.QueryUnReadMessageRequest,
    ) -> dingtalkim__1__0_models.QueryUnReadMessageResponse:
        """
        @summary 批量查询未读消息数
        
        @param request: QueryUnReadMessageRequest
        @return: QueryUnReadMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnReadMessageHeaders()
        return await self.query_un_read_message_with_options_async(request, headers, runtime)

    def query_unfurling_register_creator_with_options(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorRequest,
        headers: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse:
        """
        @summary 查询链接查询链接增强注册信息创建者
        
        @param request: QueryUnfurlingRegisterCreatorRequest
        @param headers: QueryUnfurlingRegisterCreatorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnfurlingRegisterCreatorResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
        if not UtilClient.is_unset(request.path):
            query['path'] = request.path
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
            action='QueryUnfurlingRegisterCreator',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/creators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse(),
            self.execute(params, req, runtime)
        )

    async def query_unfurling_register_creator_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorRequest,
        headers: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse:
        """
        @summary 查询链接查询链接增强注册信息创建者
        
        @param request: QueryUnfurlingRegisterCreatorRequest
        @param headers: QueryUnfurlingRegisterCreatorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnfurlingRegisterCreatorResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
        if not UtilClient.is_unset(request.path):
            query['path'] = request.path
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
            action='QueryUnfurlingRegisterCreator',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/creators',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_unfurling_register_creator(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorRequest,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse:
        """
        @summary 查询链接查询链接增强注册信息创建者
        
        @param request: QueryUnfurlingRegisterCreatorRequest
        @return: QueryUnfurlingRegisterCreatorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorHeaders()
        return self.query_unfurling_register_creator_with_options(request, headers, runtime)

    async def query_unfurling_register_creator_async(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorRequest,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorResponse:
        """
        @summary 查询链接查询链接增强注册信息创建者
        
        @param request: QueryUnfurlingRegisterCreatorRequest
        @return: QueryUnfurlingRegisterCreatorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnfurlingRegisterCreatorHeaders()
        return await self.query_unfurling_register_creator_with_options_async(request, headers, runtime)

    def query_unfurling_register_info_with_options(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoRequest,
        headers: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse:
        """
        @summary 查询链接增强注册信息列表
        
        @param request: QueryUnfurlingRegisterInfoRequest
        @param headers: QueryUnfurlingRegisterInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnfurlingRegisterInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryUnfurlingRegisterInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_unfurling_register_info_with_options_async(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoRequest,
        headers: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse:
        """
        @summary 查询链接增强注册信息列表
        
        @param request: QueryUnfurlingRegisterInfoRequest
        @param headers: QueryUnfurlingRegisterInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUnfurlingRegisterInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='QueryUnfurlingRegisterInfo',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_unfurling_register_info(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoRequest,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse:
        """
        @summary 查询链接增强注册信息列表
        
        @param request: QueryUnfurlingRegisterInfoRequest
        @return: QueryUnfurlingRegisterInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnfurlingRegisterInfoHeaders()
        return self.query_unfurling_register_info_with_options(request, headers, runtime)

    async def query_unfurling_register_info_async(
        self,
        request: dingtalkim__1__0_models.QueryUnfurlingRegisterInfoRequest,
    ) -> dingtalkim__1__0_models.QueryUnfurlingRegisterInfoResponse:
        """
        @summary 查询链接增强注册信息列表
        
        @param request: QueryUnfurlingRegisterInfoRequest
        @return: QueryUnfurlingRegisterInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.QueryUnfurlingRegisterInfoHeaders()
        return await self.query_unfurling_register_info_with_options_async(request, headers, runtime)

    def release_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.ReleaseUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.ReleaseUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse:
        """
        @summary 链接增强规则发布
        
        @param request: ReleaseUnfurlingRegisterRequest
        @param headers: ReleaseUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReleaseUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='ReleaseUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def release_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.ReleaseUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.ReleaseUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse:
        """
        @summary 链接增强规则发布
        
        @param request: ReleaseUnfurlingRegisterRequest
        @param headers: ReleaseUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ReleaseUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
            action='ReleaseUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def release_unfurling_register(
        self,
        request: dingtalkim__1__0_models.ReleaseUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse:
        """
        @summary 链接增强规则发布
        
        @param request: ReleaseUnfurlingRegisterRequest
        @return: ReleaseUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ReleaseUnfurlingRegisterHeaders()
        return self.release_unfurling_register_with_options(request, headers, runtime)

    async def release_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.ReleaseUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.ReleaseUnfurlingRegisterResponse:
        """
        @summary 链接增强规则发布
        
        @param request: ReleaseUnfurlingRegisterRequest
        @return: ReleaseUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.ReleaseUnfurlingRegisterHeaders()
        return await self.release_unfurling_register_with_options_async(request, headers, runtime)

    def remove_robot_from_conversation_with_options(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
        headers: dingtalkim__1__0_models.RemoveRobotFromConversationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        """
        @summary 移除会话机器人
        
        @param request: RemoveRobotFromConversationRequest
        @param headers: RemoveRobotFromConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveRobotFromConversationResponse
        """
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
        """
        @summary 移除会话机器人
        
        @param request: RemoveRobotFromConversationRequest
        @param headers: RemoveRobotFromConversationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveRobotFromConversationResponse
        """
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
        """
        @summary 移除会话机器人
        
        @param request: RemoveRobotFromConversationRequest
        @return: RemoveRobotFromConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveRobotFromConversationHeaders()
        return self.remove_robot_from_conversation_with_options(request, headers, runtime)

    async def remove_robot_from_conversation_async(
        self,
        request: dingtalkim__1__0_models.RemoveRobotFromConversationRequest,
    ) -> dingtalkim__1__0_models.RemoveRobotFromConversationResponse:
        """
        @summary 移除会话机器人
        
        @param request: RemoveRobotFromConversationRequest
        @return: RemoveRobotFromConversationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveRobotFromConversationHeaders()
        return await self.remove_robot_from_conversation_with_options_async(request, headers, runtime)

    def search_inner_groups_with_options(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
        headers: dingtalkim__1__0_models.SearchInnerGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        """
        @summary 根据关键词搜索企业内部群
        
        @param request: SearchInnerGroupsRequest
        @param headers: SearchInnerGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchInnerGroupsResponse
        """
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
        """
        @summary 根据关键词搜索企业内部群
        
        @param request: SearchInnerGroupsRequest
        @param headers: SearchInnerGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchInnerGroupsResponse
        """
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
        """
        @summary 根据关键词搜索企业内部群
        
        @param request: SearchInnerGroupsRequest
        @return: SearchInnerGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SearchInnerGroupsHeaders()
        return self.search_inner_groups_with_options(request, headers, runtime)

    async def search_inner_groups_async(
        self,
        request: dingtalkim__1__0_models.SearchInnerGroupsRequest,
    ) -> dingtalkim__1__0_models.SearchInnerGroupsResponse:
        """
        @summary 根据关键词搜索企业内部群
        
        @param request: SearchInnerGroupsRequest
        @return: SearchInnerGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SearchInnerGroupsHeaders()
        return await self.search_inner_groups_with_options_async(request, headers, runtime)

    def send_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        """
        @summary 发送可交互式动态卡片
        
        @param request: SendInteractiveCardRequest
        @param headers: SendInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInteractiveCardResponse
        """
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
        """
        @summary 发送可交互式动态卡片
        
        @param request: SendInteractiveCardRequest
        @param headers: SendInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInteractiveCardResponse
        """
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
        """
        @summary 发送可交互式动态卡片
        
        @param request: SendInteractiveCardRequest
        @return: SendInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return self.send_interactive_card_with_options(request, headers, runtime)

    async def send_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendInteractiveCardResponse:
        """
        @summary 发送可交互式动态卡片
        
        @param request: SendInteractiveCardRequest
        @return: SendInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendInteractiveCardHeaders()
        return await self.send_interactive_card_with_options_async(request, headers, runtime)

    def send_otointeractive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendOTOInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
        """
        @summary 人与人单聊发送可交互式动态卡片
        
        @param request: SendOTOInteractiveCardRequest
        @param headers: SendOTOInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOTOInteractiveCardResponse
        """
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
        """
        @summary 人与人单聊发送可交互式动态卡片
        
        @param request: SendOTOInteractiveCardRequest
        @param headers: SendOTOInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendOTOInteractiveCardResponse
        """
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
        """
        @summary 人与人单聊发送可交互式动态卡片
        
        @param request: SendOTOInteractiveCardRequest
        @return: SendOTOInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendOTOInteractiveCardHeaders()
        return self.send_otointeractive_card_with_options(request, headers, runtime)

    async def send_otointeractive_card_async(
        self,
        request: dingtalkim__1__0_models.SendOTOInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendOTOInteractiveCardResponse:
        """
        @summary 人与人单聊发送可交互式动态卡片
        
        @param request: SendOTOInteractiveCardRequest
        @return: SendOTOInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendOTOInteractiveCardHeaders()
        return await self.send_otointeractive_card_with_options_async(request, headers, runtime)

    def send_personal_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendPersonalMessageRequest,
        headers: dingtalkim__1__0_models.SendPersonalMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendPersonalMessageResponse:
        """
        @summary 委托权限发消息
        
        @param request: SendPersonalMessageRequest
        @param headers: SendPersonalMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendPersonalMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.msg_type):
            body['msgType'] = request.msg_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
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
            action='SendPersonalMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendPersonalMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def send_personal_message_with_options_async(
        self,
        request: dingtalkim__1__0_models.SendPersonalMessageRequest,
        headers: dingtalkim__1__0_models.SendPersonalMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendPersonalMessageResponse:
        """
        @summary 委托权限发消息
        
        @param request: SendPersonalMessageRequest
        @param headers: SendPersonalMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendPersonalMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.msg_type):
            body['msgType'] = request.msg_type
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.receiver_uid):
            body['receiverUid'] = request.receiver_uid
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
            action='SendPersonalMessage',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/me/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.SendPersonalMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_personal_message(
        self,
        request: dingtalkim__1__0_models.SendPersonalMessageRequest,
    ) -> dingtalkim__1__0_models.SendPersonalMessageResponse:
        """
        @summary 委托权限发消息
        
        @param request: SendPersonalMessageRequest
        @return: SendPersonalMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendPersonalMessageHeaders()
        return self.send_personal_message_with_options(request, headers, runtime)

    async def send_personal_message_async(
        self,
        request: dingtalkim__1__0_models.SendPersonalMessageRequest,
    ) -> dingtalkim__1__0_models.SendPersonalMessageResponse:
        """
        @summary 委托权限发消息
        
        @param request: SendPersonalMessageRequest
        @return: SendPersonalMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendPersonalMessageHeaders()
        return await self.send_personal_message_with_options_async(request, headers, runtime)

    def send_robot_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        """
        @summary 机器人发送互动卡片（普通版）
        
        @param request: SendRobotInteractiveCardRequest
        @param headers: SendRobotInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendRobotInteractiveCardResponse
        """
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
        """
        @summary 机器人发送互动卡片（普通版）
        
        @param request: SendRobotInteractiveCardRequest
        @param headers: SendRobotInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendRobotInteractiveCardResponse
        """
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
        """
        @summary 机器人发送互动卡片（普通版）
        
        @param request: SendRobotInteractiveCardRequest
        @return: SendRobotInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotInteractiveCardHeaders()
        return self.send_robot_interactive_card_with_options(request, headers, runtime)

    async def send_robot_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendRobotInteractiveCardResponse:
        """
        @summary 机器人发送互动卡片（普通版）
        
        @param request: SendRobotInteractiveCardRequest
        @return: SendRobotInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotInteractiveCardHeaders()
        return await self.send_robot_interactive_card_with_options_async(request, headers, runtime)

    def send_robot_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
        headers: dingtalkim__1__0_models.SendRobotMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        """
        @summary 机器人发送消息
        
        @param request: SendRobotMessageRequest
        @param headers: SendRobotMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendRobotMessageResponse
        """
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
        """
        @summary 机器人发送消息
        
        @param request: SendRobotMessageRequest
        @param headers: SendRobotMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendRobotMessageResponse
        """
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
        """
        @summary 机器人发送消息
        
        @param request: SendRobotMessageRequest
        @return: SendRobotMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotMessageHeaders()
        return self.send_robot_message_with_options(request, headers, runtime)

    async def send_robot_message_async(
        self,
        request: dingtalkim__1__0_models.SendRobotMessageRequest,
    ) -> dingtalkim__1__0_models.SendRobotMessageResponse:
        """
        @summary 机器人发送消息
        
        @param request: SendRobotMessageRequest
        @return: SendRobotMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendRobotMessageHeaders()
        return await self.send_robot_message_with_options_async(request, headers, runtime)

    def send_template_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        """
        @summary 发送模板响应式可交互式卡片
        
        @param request: SendTemplateInteractiveCardRequest
        @param headers: SendTemplateInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendTemplateInteractiveCardResponse
        """
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
        """
        @summary 发送模板响应式可交互式卡片
        
        @param request: SendTemplateInteractiveCardRequest
        @param headers: SendTemplateInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendTemplateInteractiveCardResponse
        """
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
        """
        @summary 发送模板响应式可交互式卡片
        
        @param request: SendTemplateInteractiveCardRequest
        @return: SendTemplateInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders()
        return self.send_template_interactive_card_with_options(request, headers, runtime)

    async def send_template_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.SendTemplateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.SendTemplateInteractiveCardResponse:
        """
        @summary 发送模板响应式可交互式卡片
        
        @param request: SendTemplateInteractiveCardRequest
        @return: SendTemplateInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendTemplateInteractiveCardHeaders()
        return await self.send_template_interactive_card_with_options_async(request, headers, runtime)

    def set_right_panel_with_options(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
        headers: dingtalkim__1__0_models.SetRightPanelHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        """
        @summary 设置侧边栏
        
        @param request: SetRightPanelRequest
        @param headers: SetRightPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRightPanelResponse
        """
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
        """
        @summary 设置侧边栏
        
        @param request: SetRightPanelRequest
        @param headers: SetRightPanelHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetRightPanelResponse
        """
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
        """
        @summary 设置侧边栏
        
        @param request: SetRightPanelRequest
        @return: SetRightPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SetRightPanelHeaders()
        return self.set_right_panel_with_options(request, headers, runtime)

    async def set_right_panel_async(
        self,
        request: dingtalkim__1__0_models.SetRightPanelRequest,
    ) -> dingtalkim__1__0_models.SetRightPanelResponse:
        """
        @summary 设置侧边栏
        
        @param request: SetRightPanelRequest
        @return: SetRightPanelResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SetRightPanelHeaders()
        return await self.set_right_panel_with_options_async(request, headers, runtime)

    def topbox_close_with_options(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
        headers: dingtalkim__1__0_models.TopboxCloseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        """
        @summary 钉钉吊顶卡片关闭
        
        @param request: TopboxCloseRequest
        @param headers: TopboxCloseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopboxCloseResponse
        """
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
        """
        @summary 钉钉吊顶卡片关闭
        
        @param request: TopboxCloseRequest
        @param headers: TopboxCloseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopboxCloseResponse
        """
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
        """
        @summary 钉钉吊顶卡片关闭
        
        @param request: TopboxCloseRequest
        @return: TopboxCloseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxCloseHeaders()
        return self.topbox_close_with_options(request, headers, runtime)

    async def topbox_close_async(
        self,
        request: dingtalkim__1__0_models.TopboxCloseRequest,
    ) -> dingtalkim__1__0_models.TopboxCloseResponse:
        """
        @summary 钉钉吊顶卡片关闭
        
        @param request: TopboxCloseRequest
        @return: TopboxCloseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxCloseHeaders()
        return await self.topbox_close_with_options_async(request, headers, runtime)

    def topbox_open_with_options(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
        headers: dingtalkim__1__0_models.TopboxOpenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        """
        @summary 钉钉吊顶卡片开启
        
        @param request: TopboxOpenRequest
        @param headers: TopboxOpenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopboxOpenResponse
        """
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
        """
        @summary 钉钉吊顶卡片开启
        
        @param request: TopboxOpenRequest
        @param headers: TopboxOpenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TopboxOpenResponse
        """
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
        """
        @summary 钉钉吊顶卡片开启
        
        @param request: TopboxOpenRequest
        @return: TopboxOpenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxOpenHeaders()
        return self.topbox_open_with_options(request, headers, runtime)

    async def topbox_open_async(
        self,
        request: dingtalkim__1__0_models.TopboxOpenRequest,
    ) -> dingtalkim__1__0_models.TopboxOpenResponse:
        """
        @summary 钉钉吊顶卡片开启
        
        @param request: TopboxOpenRequest
        @return: TopboxOpenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.TopboxOpenHeaders()
        return await self.topbox_open_with_options_async(request, headers, runtime)

    def update_group_avatar_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
        headers: dingtalkim__1__0_models.UpdateGroupAvatarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        """
        @summary 修改群头像
        
        @param request: UpdateGroupAvatarRequest
        @param headers: UpdateGroupAvatarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupAvatarResponse
        """
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
        """
        @summary 修改群头像
        
        @param request: UpdateGroupAvatarRequest
        @param headers: UpdateGroupAvatarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupAvatarResponse
        """
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
        """
        @summary 修改群头像
        
        @param request: UpdateGroupAvatarRequest
        @return: UpdateGroupAvatarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupAvatarHeaders()
        return self.update_group_avatar_with_options(request, headers, runtime)

    async def update_group_avatar_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupAvatarRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupAvatarResponse:
        """
        @summary 修改群头像
        
        @param request: UpdateGroupAvatarRequest
        @return: UpdateGroupAvatarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupAvatarHeaders()
        return await self.update_group_avatar_with_options_async(request, headers, runtime)

    def update_group_name_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
        headers: dingtalkim__1__0_models.UpdateGroupNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        """
        @summary 修改群名称
        
        @param request: UpdateGroupNameRequest
        @param headers: UpdateGroupNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupNameResponse
        """
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
        """
        @summary 修改群名称
        
        @param request: UpdateGroupNameRequest
        @param headers: UpdateGroupNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupNameResponse
        """
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
        """
        @summary 修改群名称
        
        @param request: UpdateGroupNameRequest
        @return: UpdateGroupNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupNameHeaders()
        return self.update_group_name_with_options(request, headers, runtime)

    async def update_group_name_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupNameRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupNameResponse:
        """
        @summary 修改群名称
        
        @param request: UpdateGroupNameRequest
        @return: UpdateGroupNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupNameHeaders()
        return await self.update_group_name_with_options_async(request, headers, runtime)

    def update_group_permission_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
        headers: dingtalkim__1__0_models.UpdateGroupPermissionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        """
        @summary 设置场景群权限项
        
        @param request: UpdateGroupPermissionRequest
        @param headers: UpdateGroupPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupPermissionResponse
        """
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
        """
        @summary 设置场景群权限项
        
        @param request: UpdateGroupPermissionRequest
        @param headers: UpdateGroupPermissionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupPermissionResponse
        """
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
        """
        @summary 设置场景群权限项
        
        @param request: UpdateGroupPermissionRequest
        @return: UpdateGroupPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupPermissionHeaders()
        return self.update_group_permission_with_options(request, headers, runtime)

    async def update_group_permission_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupPermissionRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupPermissionResponse:
        """
        @summary 设置场景群权限项
        
        @param request: UpdateGroupPermissionRequest
        @return: UpdateGroupPermissionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupPermissionHeaders()
        return await self.update_group_permission_with_options_async(request, headers, runtime)

    def update_group_sub_admin_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
        headers: dingtalkim__1__0_models.UpdateGroupSubAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        """
        @summary 更新群管理员
        
        @param request: UpdateGroupSubAdminRequest
        @param headers: UpdateGroupSubAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSubAdminResponse
        """
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
        """
        @summary 更新群管理员
        
        @param request: UpdateGroupSubAdminRequest
        @param headers: UpdateGroupSubAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateGroupSubAdminResponse
        """
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
        """
        @summary 更新群管理员
        
        @param request: UpdateGroupSubAdminRequest
        @return: UpdateGroupSubAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupSubAdminHeaders()
        return self.update_group_sub_admin_with_options(request, headers, runtime)

    async def update_group_sub_admin_async(
        self,
        request: dingtalkim__1__0_models.UpdateGroupSubAdminRequest,
    ) -> dingtalkim__1__0_models.UpdateGroupSubAdminResponse:
        """
        @summary 更新群管理员
        
        @param request: UpdateGroupSubAdminRequest
        @return: UpdateGroupSubAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateGroupSubAdminHeaders()
        return await self.update_group_sub_admin_with_options_async(request, headers, runtime)

    def update_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        """
        @summary 更新可交互式动态卡片
        
        @param request: UpdateInteractiveCardRequest
        @param headers: UpdateInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInteractiveCardResponse
        """
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
        """
        @summary 更新可交互式动态卡片
        
        @param request: UpdateInteractiveCardRequest
        @param headers: UpdateInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateInteractiveCardResponse
        """
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
        """
        @summary 更新可交互式动态卡片
        
        @param request: UpdateInteractiveCardRequest
        @return: UpdateInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return self.update_interactive_card_with_options(request, headers, runtime)

    async def update_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.UpdateInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateInteractiveCardResponse:
        """
        @summary 更新可交互式动态卡片
        
        @param request: UpdateInteractiveCardRequest
        @return: UpdateInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateInteractiveCardHeaders()
        return await self.update_interactive_card_with_options_async(request, headers, runtime)

    def update_member_ban_words_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
        headers: dingtalkim__1__0_models.UpdateMemberBanWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        """
        @summary 设置群成员禁言状态
        
        @param request: UpdateMemberBanWordsRequest
        @param headers: UpdateMemberBanWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMemberBanWordsResponse
        """
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
        """
        @summary 设置群成员禁言状态
        
        @param request: UpdateMemberBanWordsRequest
        @param headers: UpdateMemberBanWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMemberBanWordsResponse
        """
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
        """
        @summary 设置群成员禁言状态
        
        @param request: UpdateMemberBanWordsRequest
        @return: UpdateMemberBanWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberBanWordsHeaders()
        return self.update_member_ban_words_with_options(request, headers, runtime)

    async def update_member_ban_words_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberBanWordsRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberBanWordsResponse:
        """
        @summary 设置群成员禁言状态
        
        @param request: UpdateMemberBanWordsRequest
        @return: UpdateMemberBanWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberBanWordsHeaders()
        return await self.update_member_ban_words_with_options_async(request, headers, runtime)

    def update_member_group_nick_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
        headers: dingtalkim__1__0_models.UpdateMemberGroupNickHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        """
        @summary 更新群成员的群昵称
        
        @param request: UpdateMemberGroupNickRequest
        @param headers: UpdateMemberGroupNickHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMemberGroupNickResponse
        """
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
        """
        @summary 更新群成员的群昵称
        
        @param request: UpdateMemberGroupNickRequest
        @param headers: UpdateMemberGroupNickHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMemberGroupNickResponse
        """
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
        """
        @summary 更新群成员的群昵称
        
        @param request: UpdateMemberGroupNickRequest
        @return: UpdateMemberGroupNickResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberGroupNickHeaders()
        return self.update_member_group_nick_with_options(request, headers, runtime)

    async def update_member_group_nick_async(
        self,
        request: dingtalkim__1__0_models.UpdateMemberGroupNickRequest,
    ) -> dingtalkim__1__0_models.UpdateMemberGroupNickResponse:
        """
        @summary 更新群成员的群昵称
        
        @param request: UpdateMemberGroupNickRequest
        @return: UpdateMemberGroupNickResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateMemberGroupNickHeaders()
        return await self.update_member_group_nick_with_options_async(request, headers, runtime)

    def update_robot_in_org_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        """
        @summary 修改组织里的机器人
        
        @param request: UpdateRobotInOrgRequest
        @param headers: UpdateRobotInOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRobotInOrgResponse
        """
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
        """
        @summary 修改组织里的机器人
        
        @param request: UpdateRobotInOrgRequest
        @param headers: UpdateRobotInOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRobotInOrgResponse
        """
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
        """
        @summary 修改组织里的机器人
        
        @param request: UpdateRobotInOrgRequest
        @return: UpdateRobotInOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInOrgHeaders()
        return self.update_robot_in_org_with_options(request, headers, runtime)

    async def update_robot_in_org_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInOrgRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInOrgResponse:
        """
        @summary 修改组织里的机器人
        
        @param request: UpdateRobotInOrgRequest
        @return: UpdateRobotInOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInOrgHeaders()
        return await self.update_robot_in_org_with_options_async(request, headers, runtime)

    def update_robot_interactive_card_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
        headers: dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        """
        @summary 机器人更新可交互式卡片(个人、企业)
        
        @param request: UpdateRobotInteractiveCardRequest
        @param headers: UpdateRobotInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRobotInteractiveCardResponse
        """
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
        """
        @summary 机器人更新可交互式卡片(个人、企业)
        
        @param request: UpdateRobotInteractiveCardRequest
        @param headers: UpdateRobotInteractiveCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRobotInteractiveCardResponse
        """
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
        """
        @summary 机器人更新可交互式卡片(个人、企业)
        
        @param request: UpdateRobotInteractiveCardRequest
        @return: UpdateRobotInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders()
        return self.update_robot_interactive_card_with_options(request, headers, runtime)

    async def update_robot_interactive_card_async(
        self,
        request: dingtalkim__1__0_models.UpdateRobotInteractiveCardRequest,
    ) -> dingtalkim__1__0_models.UpdateRobotInteractiveCardResponse:
        """
        @summary 机器人更新可交互式卡片(个人、企业)
        
        @param request: UpdateRobotInteractiveCardRequest
        @return: UpdateRobotInteractiveCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateRobotInteractiveCardHeaders()
        return await self.update_robot_interactive_card_with_options_async(request, headers, runtime)

    def update_scene_group_template_message_open_status_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusRequest,
        headers: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 修改场景群模板消息存档能力开启状态
        
        @param request: UpdateSceneGroupTemplateMessageOpenStatusRequest
        @param headers: UpdateSceneGroupTemplateMessageOpenStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSceneGroupTemplateMessageOpenStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.template_id_list):
            body['templateIdList'] = request.template_id_list
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
            action='UpdateSceneGroupTemplateMessageOpenStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/messageOpenStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_scene_group_template_message_open_status_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusRequest,
        headers: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 修改场景群模板消息存档能力开启状态
        
        @param request: UpdateSceneGroupTemplateMessageOpenStatusRequest
        @param headers: UpdateSceneGroupTemplateMessageOpenStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSceneGroupTemplateMessageOpenStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.template_id_list):
            body['templateIdList'] = request.template_id_list
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
            action='UpdateSceneGroupTemplateMessageOpenStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/chats/sceneGroups/templates/messageOpenStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_scene_group_template_message_open_status(
        self,
        request: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusRequest,
    ) -> dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 修改场景群模板消息存档能力开启状态
        
        @param request: UpdateSceneGroupTemplateMessageOpenStatusRequest
        @return: UpdateSceneGroupTemplateMessageOpenStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusHeaders()
        return self.update_scene_group_template_message_open_status_with_options(request, headers, runtime)

    async def update_scene_group_template_message_open_status_async(
        self,
        request: dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusRequest,
    ) -> dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusResponse:
        """
        @summary 修改场景群模板消息存档能力开启状态
        
        @param request: UpdateSceneGroupTemplateMessageOpenStatusRequest
        @return: UpdateSceneGroupTemplateMessageOpenStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateSceneGroupTemplateMessageOpenStatusHeaders()
        return await self.update_scene_group_template_message_open_status_with_options_async(request, headers, runtime)

    def update_the_group_roles_of_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
        headers: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        """
        @summary 设置群成员的群角色
        
        @param request: UpdateTheGroupRolesOfGroupMemberRequest
        @param headers: UpdateTheGroupRolesOfGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTheGroupRolesOfGroupMemberResponse
        """
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
        """
        @summary 设置群成员的群角色
        
        @param request: UpdateTheGroupRolesOfGroupMemberRequest
        @param headers: UpdateTheGroupRolesOfGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTheGroupRolesOfGroupMemberResponse
        """
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
        """
        @summary 设置群成员的群角色
        
        @param request: UpdateTheGroupRolesOfGroupMemberRequest
        @return: UpdateTheGroupRolesOfGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders()
        return self.update_the_group_roles_of_group_member_with_options(request, headers, runtime)

    async def update_the_group_roles_of_group_member_async(
        self,
        request: dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberRequest,
    ) -> dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberResponse:
        """
        @summary 设置群成员的群角色
        
        @param request: UpdateTheGroupRolesOfGroupMemberRequest
        @return: UpdateTheGroupRolesOfGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateTheGroupRolesOfGroupMemberHeaders()
        return await self.update_the_group_roles_of_group_member_with_options_async(request, headers, runtime)

    def update_unfurling_register_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.UpdateUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse:
        """
        @summary 编辑链接增强注册规则
        
        @param request: UpdateUnfurlingRegisterRequest
        @param headers: UpdateUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
        if not UtilClient.is_unset(request.rule_desc):
            body['ruleDesc'] = request.rule_desc
        if not UtilClient.is_unset(request.rule_match_type):
            body['ruleMatchType'] = request.rule_match_type
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
            action='UpdateUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse(),
            self.execute(params, req, runtime)
        )

    async def update_unfurling_register_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterRequest,
        headers: dingtalkim__1__0_models.UpdateUnfurlingRegisterHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse:
        """
        @summary 编辑链接增强注册规则
        
        @param request: UpdateUnfurlingRegisterRequest
        @param headers: UpdateUnfurlingRegisterHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUnfurlingRegisterResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.api_secret):
            body['apiSecret'] = request.api_secret
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.callback_url):
            body['callbackUrl'] = request.callback_url
        if not UtilClient.is_unset(request.card_template_id):
            body['cardTemplateId'] = request.card_template_id
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.path):
            body['path'] = request.path
        if not UtilClient.is_unset(request.rule_desc):
            body['ruleDesc'] = request.rule_desc
        if not UtilClient.is_unset(request.rule_match_type):
            body['ruleMatchType'] = request.rule_match_type
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
            action='UpdateUnfurlingRegister',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_unfurling_register(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse:
        """
        @summary 编辑链接增强注册规则
        
        @param request: UpdateUnfurlingRegisterRequest
        @return: UpdateUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateUnfurlingRegisterHeaders()
        return self.update_unfurling_register_with_options(request, headers, runtime)

    async def update_unfurling_register_async(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterRequest,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterResponse:
        """
        @summary 编辑链接增强注册规则
        
        @param request: UpdateUnfurlingRegisterRequest
        @return: UpdateUnfurlingRegisterResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateUnfurlingRegisterHeaders()
        return await self.update_unfurling_register_with_options_async(request, headers, runtime)

    def update_unfurling_register_status_with_options(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusRequest,
        headers: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse:
        """
        @summary 链接增强规则状态更新
        
        @param request: UpdateUnfurlingRegisterStatusRequest
        @param headers: UpdateUnfurlingRegisterStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUnfurlingRegisterStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='UpdateUnfurlingRegisterStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_unfurling_register_status_with_options_async(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusRequest,
        headers: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse:
        """
        @summary 链接增强规则状态更新
        
        @param request: UpdateUnfurlingRegisterStatusRequest
        @param headers: UpdateUnfurlingRegisterStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUnfurlingRegisterStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
            action='UpdateUnfurlingRegisterStatus',
            version='im_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/im/unfurling/rules/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_unfurling_register_status(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusRequest,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse:
        """
        @summary 链接增强规则状态更新
        
        @param request: UpdateUnfurlingRegisterStatusRequest
        @return: UpdateUnfurlingRegisterStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusHeaders()
        return self.update_unfurling_register_status_with_options(request, headers, runtime)

    async def update_unfurling_register_status_async(
        self,
        request: dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusRequest,
    ) -> dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusResponse:
        """
        @summary 链接增强规则状态更新
        
        @param request: UpdateUnfurlingRegisterStatusRequest
        @return: UpdateUnfurlingRegisterStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.UpdateUnfurlingRegisterStatusHeaders()
        return await self.update_unfurling_register_status_with_options_async(request, headers, runtime)

    def add_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
        headers: dingtalkim__1__0_models.AddGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        """
        @summary 添加群成员
        
        @param request: AddGroupMemberRequest
        @param headers: AddGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddGroupMemberResponse
        """
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
        """
        @summary 添加群成员
        
        @param request: AddGroupMemberRequest
        @param headers: AddGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddGroupMemberResponse
        """
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
        """
        @summary 添加群成员
        
        @param request: AddGroupMemberRequest
        @return: AddGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddGroupMemberHeaders()
        return self.add_group_member_with_options(request, headers, runtime)

    async def add_group_member_async(
        self,
        request: dingtalkim__1__0_models.AddGroupMemberRequest,
    ) -> dingtalkim__1__0_models.AddGroupMemberResponse:
        """
        @summary 添加群成员
        
        @param request: AddGroupMemberRequest
        @return: AddGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.AddGroupMemberHeaders()
        return await self.add_group_member_with_options_async(request, headers, runtime)

    def remove_group_member_with_options(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
        headers: dingtalkim__1__0_models.RemoveGroupMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        """
        @summary 移除群成员
        
        @param request: RemoveGroupMemberRequest
        @param headers: RemoveGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveGroupMemberResponse
        """
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
        """
        @summary 移除群成员
        
        @param request: RemoveGroupMemberRequest
        @param headers: RemoveGroupMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveGroupMemberResponse
        """
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
        """
        @summary 移除群成员
        
        @param request: RemoveGroupMemberRequest
        @return: RemoveGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveGroupMemberHeaders()
        return self.remove_group_member_with_options(request, headers, runtime)

    async def remove_group_member_async(
        self,
        request: dingtalkim__1__0_models.RemoveGroupMemberRequest,
    ) -> dingtalkim__1__0_models.RemoveGroupMemberResponse:
        """
        @summary 移除群成员
        
        @param request: RemoveGroupMemberRequest
        @return: RemoveGroupMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.RemoveGroupMemberHeaders()
        return await self.remove_group_member_with_options_async(request, headers, runtime)

    def send_ding_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
        headers: dingtalkim__1__0_models.SendDingMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        """
        @summary 发送ToC消息
        
        @param request: SendDingMessageRequest
        @param headers: SendDingMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendDingMessageResponse
        """
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
        """
        @summary 发送ToC消息
        
        @param request: SendDingMessageRequest
        @param headers: SendDingMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendDingMessageResponse
        """
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
        """
        @summary 发送ToC消息
        
        @param request: SendDingMessageRequest
        @return: SendDingMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendDingMessageHeaders()
        return self.send_ding_message_with_options(request, headers, runtime)

    async def send_ding_message_async(
        self,
        request: dingtalkim__1__0_models.SendDingMessageRequest,
    ) -> dingtalkim__1__0_models.SendDingMessageResponse:
        """
        @summary 发送ToC消息
        
        @param request: SendDingMessageRequest
        @return: SendDingMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendDingMessageHeaders()
        return await self.send_ding_message_with_options_async(request, headers, runtime)

    def send_message_with_options(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
        headers: dingtalkim__1__0_models.SendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        """
        @summary 发送ToB消息
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
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
        """
        @summary 发送ToB消息
        
        @param request: SendMessageRequest
        @param headers: SendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendMessageResponse
        """
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
        """
        @summary 发送ToB消息
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendMessageHeaders()
        return self.send_message_with_options(request, headers, runtime)

    async def send_message_async(
        self,
        request: dingtalkim__1__0_models.SendMessageRequest,
    ) -> dingtalkim__1__0_models.SendMessageResponse:
        """
        @summary 发送ToB消息
        
        @param request: SendMessageRequest
        @return: SendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkim__1__0_models.SendMessageHeaders()
        return await self.send_message_with_options_async(request, headers, runtime)
