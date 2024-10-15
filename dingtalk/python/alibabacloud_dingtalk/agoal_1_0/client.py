# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.agoal_1_0 import models as dingtalkagoal__1__0_models
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

    def agoal_create_progress_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
        headers: dingtalkagoal__1__0_models.AgoalCreateProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @param headers: AgoalCreateProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalCreateProgressResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kr_id):
            body['krId'] = request.kr_id
        if not UtilClient.is_unset(request.merge_into_latest_progress):
            body['mergeIntoLatestProgress'] = request.merge_into_latest_progress
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.plain_text):
            body['plainText'] = request.plain_text
        if not UtilClient.is_unset(request.progress):
            body['progress'] = request.progress
        if not UtilClient.is_unset(request.progress_merge_period):
            body['progressMergePeriod'] = request.progress_merge_period
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AgoalCreateProgress',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalCreateProgressResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_create_progress_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
        headers: dingtalkagoal__1__0_models.AgoalCreateProgressHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @param headers: AgoalCreateProgressHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalCreateProgressResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kr_id):
            body['krId'] = request.kr_id
        if not UtilClient.is_unset(request.merge_into_latest_progress):
            body['mergeIntoLatestProgress'] = request.merge_into_latest_progress
        if not UtilClient.is_unset(request.objective_id):
            body['objectiveId'] = request.objective_id
        if not UtilClient.is_unset(request.plain_text):
            body['plainText'] = request.plain_text
        if not UtilClient.is_unset(request.progress):
            body['progress'] = request.progress
        if not UtilClient.is_unset(request.progress_merge_period):
            body['progressMergePeriod'] = request.progress_merge_period
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AgoalCreateProgress',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/progresses',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalCreateProgressResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_create_progress(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @return: AgoalCreateProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalCreateProgressHeaders()
        return self.agoal_create_progress_with_options(request, headers, runtime)

    async def agoal_create_progress_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalCreateProgressRequest,
    ) -> dingtalkagoal__1__0_models.AgoalCreateProgressResponse:
        """
        @summary 创建目标进展
        
        @param request: AgoalCreateProgressRequest
        @return: AgoalCreateProgressResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalCreateProgressHeaders()
        return await self.agoal_create_progress_with_options_async(request, headers, runtime)

    def agoal_objective_key_action_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @param headers: AgoalObjectiveKeyActionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveKeyActionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.key_result_id):
            query['keyResultId'] = request.key_result_id
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveKeyActionList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/keyActionLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_key_action_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @param headers: AgoalObjectiveKeyActionListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveKeyActionListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_user_id):
            query['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.key_result_id):
            query['keyResultId'] = request.key_result_id
        if not UtilClient.is_unset(request.objective_id):
            query['objectiveId'] = request.objective_id
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
            action='AgoalObjectiveKeyActionList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectives/keyActionLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_key_action_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @return: AgoalObjectiveKeyActionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders()
        return self.agoal_objective_key_action_list_with_options(request, headers, runtime)

    async def agoal_objective_key_action_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListResponse:
        """
        @summary 获取Agoal指定目标或者关键结果关联的关键行动
        
        @param request: AgoalObjectiveKeyActionListRequest
        @return: AgoalObjectiveKeyActionListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveKeyActionListHeaders()
        return await self.agoal_objective_key_action_list_with_options_async(request, headers, runtime)

    def agoal_objective_rule_period_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @param headers: AgoalObjectiveRulePeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRulePeriodListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='AgoalObjectiveRulePeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/periodLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_objective_rule_period_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
        headers: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @param headers: AgoalObjectiveRulePeriodListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalObjectiveRulePeriodListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.objective_rule_id):
            query['objectiveRuleId'] = request.objective_rule_id
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
            action='AgoalObjectiveRulePeriodList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/periodLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_objective_rule_period_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @return: AgoalObjectiveRulePeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders()
        return self.agoal_objective_rule_period_list_with_options(request, headers, runtime)

    async def agoal_objective_rule_period_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListResponse:
        """
        @summary 获取Agoal目标规则下的周期列表
        
        @param request: AgoalObjectiveRulePeriodListRequest
        @return: AgoalObjectiveRulePeriodListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalObjectiveRulePeriodListHeaders()
        return await self.agoal_objective_rule_period_list_with_options_async(request, headers, runtime)

    def agoal_org_objective_rule_list_with_options(
        self,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @param headers: AgoalOrgObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveRuleListResponse
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
            action='AgoalOrgObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_org_objective_rule_list_with_options_async(
        self,
        headers: dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @param headers: AgoalOrgObjectiveRuleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalOrgObjectiveRuleListResponse
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
            action='AgoalOrgObjectiveRuleList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/objectiveRules/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_org_objective_rule_list(self) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @return: AgoalOrgObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders()
        return self.agoal_org_objective_rule_list_with_options(headers, runtime)

    async def agoal_org_objective_rule_list_async(self) -> dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListResponse:
        """
        @summary 获取Agoal目标规则列表
        
        @return: AgoalOrgObjectiveRuleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalOrgObjectiveRuleListHeaders()
        return await self.agoal_org_objective_rule_list_with_options_async(headers, runtime)

    def agoal_send_message_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
        headers: dingtalkagoal__1__0_models.AgoalSendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @param headers: AgoalSendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalSendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.source_ding_user_id):
            body['sourceDingUserId'] = request.source_ding_user_id
        if not UtilClient.is_unset(request.target_ding_user_ids):
            body['targetDingUserIds'] = request.target_ding_user_ids
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
            action='AgoalSendMessage',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalSendMessageResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_send_message_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
        headers: dingtalkagoal__1__0_models.AgoalSendMessageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @param headers: AgoalSendMessageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalSendMessageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_url):
            body['mobileUrl'] = request.mobile_url
        if not UtilClient.is_unset(request.params):
            body['params'] = request.params
        if not UtilClient.is_unset(request.pc_url):
            body['pcUrl'] = request.pc_url
        if not UtilClient.is_unset(request.source_ding_user_id):
            body['sourceDingUserId'] = request.source_ding_user_id
        if not UtilClient.is_unset(request.target_ding_user_ids):
            body['targetDingUserIds'] = request.target_ding_user_ids
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
            action='AgoalSendMessage',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/messages/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalSendMessageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_send_message(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @return: AgoalSendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalSendMessageHeaders()
        return self.agoal_send_message_with_options(request, headers, runtime)

    async def agoal_send_message_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalSendMessageRequest,
    ) -> dingtalkagoal__1__0_models.AgoalSendMessageResponse:
        """
        @summary Agoal消息发送
        
        @param request: AgoalSendMessageRequest
        @return: AgoalSendMessageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalSendMessageHeaders()
        return await self.agoal_send_message_with_options_async(request, headers, runtime)

    def agoal_user_admin_list_with_options(
        self,
        headers: dingtalkagoal__1__0_models.AgoalUserAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @param headers: AgoalUserAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserAdminListResponse
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
            action='AgoalUserAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserAdminListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_admin_list_with_options_async(
        self,
        headers: dingtalkagoal__1__0_models.AgoalUserAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @param headers: AgoalUserAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserAdminListResponse
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
            action='AgoalUserAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserAdminListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_admin_list(self) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @return: AgoalUserAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserAdminListHeaders()
        return self.agoal_user_admin_list_with_options(headers, runtime)

    async def agoal_user_admin_list_async(self) -> dingtalkagoal__1__0_models.AgoalUserAdminListResponse:
        """
        @summary 获取Agoal管理员列表
        
        @return: AgoalUserAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserAdminListHeaders()
        return await self.agoal_user_admin_list_with_options_async(headers, runtime)

    def agoal_user_objective_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @param headers: AgoalUserObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserObjectiveListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.objective_rule_id):
            body['objectiveRuleId'] = request.objective_rule_id
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AgoalUserObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/users/objectiveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_objective_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @param headers: AgoalUserObjectiveListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserObjectiveListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_user_id):
            body['dingUserId'] = request.ding_user_id
        if not UtilClient.is_unset(request.objective_rule_id):
            body['objectiveRuleId'] = request.objective_rule_id
        if not UtilClient.is_unset(request.period_ids):
            body['periodIds'] = request.period_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AgoalUserObjectiveList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/users/objectiveLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_objective_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @return: AgoalUserObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders()
        return self.agoal_user_objective_list_with_options(request, headers, runtime)

    async def agoal_user_objective_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserObjectiveListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserObjectiveListResponse:
        """
        @summary Agoal用户目标列表
        
        @param request: AgoalUserObjectiveListRequest
        @return: AgoalUserObjectiveListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserObjectiveListHeaders()
        return await self.agoal_user_objective_list_with_options_async(request, headers, runtime)

    def agoal_user_sub_admin_list_with_options(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @param headers: AgoalUserSubAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserSubAdminListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.func_permission_group):
            query['funcPermissionGroup'] = request.func_permission_group
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
            action='AgoalUserSubAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/sub/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse(),
            self.execute(params, req, runtime)
        )

    async def agoal_user_sub_admin_list_with_options_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
        headers: dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @param headers: AgoalUserSubAdminListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AgoalUserSubAdminListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.func_permission_group):
            query['funcPermissionGroup'] = request.func_permission_group
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
            action='AgoalUserSubAdminList',
            version='agoal_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/agoal/administrators/sub/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def agoal_user_sub_admin_list(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @return: AgoalUserSubAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders()
        return self.agoal_user_sub_admin_list_with_options(request, headers, runtime)

    async def agoal_user_sub_admin_list_async(
        self,
        request: dingtalkagoal__1__0_models.AgoalUserSubAdminListRequest,
    ) -> dingtalkagoal__1__0_models.AgoalUserSubAdminListResponse:
        """
        @summary 获取Agoal子管理员列表
        
        @param request: AgoalUserSubAdminListRequest
        @return: AgoalUserSubAdminListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkagoal__1__0_models.AgoalUserSubAdminListHeaders()
        return await self.agoal_user_sub_admin_list_with_options_async(request, headers, runtime)
