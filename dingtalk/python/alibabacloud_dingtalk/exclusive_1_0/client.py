# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.exclusive_1_0 import models as dingtalkexclusive__1__0_models
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

    def add_org_with_options(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
        headers: dingtalkexclusive__1__0_models.AddOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOrg',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/orgnizations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.AddOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def add_org_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
        headers: dingtalkexclusive__1__0_models.AddOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOrg',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/orgnizations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.AddOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_org(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.AddOrgHeaders()
        return self.add_org_with_options(request, headers, runtime)

    async def add_org_async(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.AddOrgHeaders()
        return await self.add_org_with_options_async(request, headers, runtime)

    def approve_process_callback_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
        headers: dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='ApproveProcessCallback',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/approvalResults/callback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse(),
            self.execute(params, req, runtime)
        )

    async def approve_process_callback_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
        headers: dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.request):
            body['request'] = request.request
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
            action='ApproveProcessCallback',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/approvalResults/callback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse(),
            await self.execute_async(params, req, runtime)
        )

    def approve_process_callback(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders()
        return self.approve_process_callback_with_options(request, headers, runtime)

    async def approve_process_callback_async(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders()
        return await self.approve_process_callback_with_options_async(request, headers, runtime)

    def ban_or_open_group_words_with_options(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
        headers: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ban_words_type):
            body['banWordsType'] = request.ban_words_type
        if not UtilClient.is_unset(request.open_converation_id):
            body['openConverationId'] = request.open_converation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BanOrOpenGroupWords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse(),
            self.execute(params, req, runtime)
        )

    async def ban_or_open_group_words_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
        headers: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ban_words_type):
            body['banWordsType'] = request.ban_words_type
        if not UtilClient.is_unset(request.open_converation_id):
            body['openConverationId'] = request.open_converation_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BanOrOpenGroupWords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/banOrOpenGroupWords',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def ban_or_open_group_words(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders()
        return self.ban_or_open_group_words_with_options(request, headers, runtime)

    async def ban_or_open_group_words_async(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders()
        return await self.ban_or_open_group_words_with_options_async(request, headers, runtime)

    def create_category_and_binding_groups_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
        headers: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCategoryAndBindingGroups',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/createAndBind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def create_category_and_binding_groups_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
        headers: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCategoryAndBindingGroups',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/createAndBind',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_category_and_binding_groups(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders()
        return self.create_category_and_binding_groups_with_options(request, headers, runtime)

    async def create_category_and_binding_groups_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders()
        return await self.create_category_and_binding_groups_with_options_async(request, headers, runtime)

    def create_message_category_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
        headers: dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateMessageCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateMessageCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def create_message_category_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
        headers: dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.group_ids):
            body['groupIds'] = request.group_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateMessageCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/create',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateMessageCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_message_category(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders()
        return self.create_message_category_with_options(request, headers, runtime)

    async def create_message_category_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders()
        return await self.create_message_category_with_options_async(request, headers, runtime)

    def create_rule_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
        headers: dingtalkexclusive__1__0_models.CreateRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_plan):
            body['customPlan'] = request.custom_plan
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateRule',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def create_rule_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
        headers: dingtalkexclusive__1__0_models.CreateRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.custom_plan):
            body['customPlan'] = request.custom_plan
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateRule',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_rule(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateRuleHeaders()
        return self.create_rule_with_options(request, headers, runtime)

    async def create_rule_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateRuleHeaders()
        return await self.create_rule_with_options_async(request, headers, runtime)

    def create_trusted_device_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.did):
            body['did'] = request.did
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
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
            action='CreateTrustedDevice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_trusted_device_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.did):
            body['did'] = request.did
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
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
            action='CreateTrustedDevice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_trusted_device(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return self.create_trusted_device_with_options(request, headers, runtime)

    async def create_trusted_device_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return await self.create_trusted_device_with_options_async(request, headers, runtime)

    def create_trusted_device_batch_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mac_address_list):
            body['macAddressList'] = request.mac_address_list
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
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
            action='CreateTrustedDeviceBatch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trusts/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse(),
            self.execute(params, req, runtime)
        )

    async def create_trusted_device_batch_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mac_address_list):
            body['macAddressList'] = request.mac_address_list
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
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
            action='CreateTrustedDeviceBatch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trusts/devices',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_trusted_device_batch(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders()
        return self.create_trusted_device_batch_with_options(request, headers, runtime)

    async def create_trusted_device_batch_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders()
        return await self.create_trusted_device_batch_with_options_async(request, headers, runtime)

    def delete_across_cloud_stroage_configs_with_options(
        self,
        target_corp_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations/{target_corp_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_across_cloud_stroage_configs_with_options_async(
        self,
        target_corp_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations/{target_corp_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_across_cloud_stroage_configs(
        self,
        target_corp_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders()
        return self.delete_across_cloud_stroage_configs_with_options(target_corp_id, headers, runtime)

    async def delete_across_cloud_stroage_configs_async(
        self,
        target_corp_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders()
        return await self.delete_across_cloud_stroage_configs_with_options_async(target_corp_id, headers, runtime)

    def delete_comment_with_options(
        self,
        publisher_id: str,
        comment_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteComment',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/publishers/{publisher_id}/comments/{comment_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteCommentResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_comment_with_options_async(
        self,
        publisher_id: str,
        comment_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteCommentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='DeleteComment',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/publishers/{publisher_id}/comments/{comment_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteCommentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_comment(
        self,
        publisher_id: str,
        comment_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return self.delete_comment_with_options(publisher_id, comment_id, headers, runtime)

    async def delete_comment_async(
        self,
        publisher_id: str,
        comment_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return await self.delete_comment_with_options_async(publisher_id, comment_id, headers, runtime)

    def delete_trusted_device_with_options(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kick_off):
            body['kickOff'] = request.kick_off
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
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
            action='DeleteTrustedDevice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_trusted_device_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.kick_off):
            body['kickOff'] = request.kick_off
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
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
            action='DeleteTrustedDevice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices/remove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_trusted_device(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders()
        return self.delete_trusted_device_with_options(request, headers, runtime)

    async def delete_trusted_device_async(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders()
        return await self.delete_trusted_device_with_options_async(request, headers, runtime)

    def distribute_partner_app_with_options(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
        headers: dingtalkexclusive__1__0_models.DistributePartnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.sub_corp_id):
            body['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DistributePartnerApp',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/applications/distribute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DistributePartnerAppResponse(),
            self.execute(params, req, runtime)
        )

    async def distribute_partner_app_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
        headers: dingtalkexclusive__1__0_models.DistributePartnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.sub_corp_id):
            body['subCorpId'] = request.sub_corp_id
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DistributePartnerApp',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/applications/distribute',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DistributePartnerAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def distribute_partner_app(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DistributePartnerAppHeaders()
        return self.distribute_partner_app_with_options(request, headers, runtime)

    async def distribute_partner_app_async(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DistributePartnerAppHeaders()
        return await self.distribute_partner_app_with_options_async(request, headers, runtime)

    def exclusive_create_ding_portal_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
        headers: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_portal_name):
            body['dingPortalName'] = request.ding_portal_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.template_app_uuid):
            body['templateAppUuid'] = request.template_app_uuid
        if not UtilClient.is_unset(request.template_corp_id):
            body['templateCorpId'] = request.template_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExclusiveCreateDingPortal',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/workbenches/templates/spread',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse(),
            self.execute(params, req, runtime)
        )

    async def exclusive_create_ding_portal_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
        headers: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_portal_name):
            body['dingPortalName'] = request.ding_portal_name
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.template_app_uuid):
            body['templateAppUuid'] = request.template_app_uuid
        if not UtilClient.is_unset(request.template_corp_id):
            body['templateCorpId'] = request.template_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExclusiveCreateDingPortal',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/workbenches/templates/spread',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse(),
            await self.execute_async(params, req, runtime)
        )

    def exclusive_create_ding_portal(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders()
        return self.exclusive_create_ding_portal_with_options(request, headers, runtime)

    async def exclusive_create_ding_portal_async(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders()
        return await self.exclusive_create_ding_portal_with_options_async(request, headers, runtime)

    def file_storage_active_storage_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.oss):
            body['oss'] = request.oss
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
            action='FileStorageActiveStorage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/active',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse(),
            self.execute(params, req, runtime)
        )

    async def file_storage_active_storage_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.oss):
            body['oss'] = request.oss
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
            action='FileStorageActiveStorage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/active',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def file_storage_active_storage(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders()
        return self.file_storage_active_storage_with_options(request, headers, runtime)

    async def file_storage_active_storage_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders()
        return await self.file_storage_active_storage_with_options_async(request, headers, runtime)

    def file_storage_check_connection_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.oss):
            body['oss'] = request.oss
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
            action='FileStorageCheckConnection',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/connections/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse(),
            self.execute(params, req, runtime)
        )

    async def file_storage_check_connection_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.oss):
            body['oss'] = request.oss
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
            action='FileStorageCheckConnection',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/connections/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def file_storage_check_connection(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders()
        return self.file_storage_check_connection_with_options(request, headers, runtime)

    async def file_storage_check_connection_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders()
        return await self.file_storage_check_connection_with_options_async(request, headers, runtime)

    def file_storage_get_quota_data_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='FileStorageGetQuotaData',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/quotaDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse(),
            self.execute(params, req, runtime)
        )

    async def file_storage_get_quota_data_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.type):
            query['type'] = request.type
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
            action='FileStorageGetQuotaData',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/quotaDatas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def file_storage_get_quota_data(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders()
        return self.file_storage_get_quota_data_with_options(request, headers, runtime)

    async def file_storage_get_quota_data_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders()
        return await self.file_storage_get_quota_data_with_options_async(request, headers, runtime)

    def file_storage_get_storage_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='FileStorageGetStorageState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/states',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse(),
            self.execute(params, req, runtime)
        )

    async def file_storage_get_storage_state_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='FileStorageGetStorageState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/states',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def file_storage_get_storage_state(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders()
        return self.file_storage_get_storage_state_with_options(request, headers, runtime)

    async def file_storage_get_storage_state_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders()
        return await self.file_storage_get_storage_state_with_options_async(request, headers, runtime)

    def file_storage_update_storage_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
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
            action='FileStorageUpdateStorage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/configurations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse(),
            self.execute(params, req, runtime)
        )

    async def file_storage_update_storage_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
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
            action='FileStorageUpdateStorage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/configurations',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def file_storage_update_storage(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders()
        return self.file_storage_update_storage_with_options(request, headers, runtime)

    async def file_storage_update_storage_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders()
        return await self.file_storage_update_storage_with_options_async(request, headers, runtime)

    def generate_dark_water_mark_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
        headers: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GenerateDarkWaterMark',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse(),
            self.execute(params, req, runtime)
        )

    async def generate_dark_water_mark_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
        headers: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GenerateDarkWaterMark',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/darkWatermarks/generate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def generate_dark_water_mark(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders()
        return self.generate_dark_water_mark_with_options(request, headers, runtime)

    async def generate_dark_water_mark_async(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders()
        return await self.generate_dark_water_mark_with_options_async(request, headers, runtime)

    def get_account_transfer_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
        headers: dingtalkexclusive__1__0_models.GetAccountTransferListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
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
            action='GetAccountTransferList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dataTransfer/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAccountTransferListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_account_transfer_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
        headers: dingtalkexclusive__1__0_models.GetAccountTransferListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.status):
            query['status'] = request.status
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
            action='GetAccountTransferList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dataTransfer/accounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAccountTransferListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_account_transfer_list(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAccountTransferListHeaders()
        return self.get_account_transfer_list_with_options(request, headers, runtime)

    async def get_account_transfer_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAccountTransferListHeaders()
        return await self.get_account_transfer_list_with_options_async(request, headers, runtime)

    def get_active_user_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetActiveUserSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/dau/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_active_user_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetActiveUserSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/dau/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_active_user_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return self.get_active_user_summary_with_options(data_id, headers, runtime)

    async def get_active_user_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return await self.get_active_user_summary_with_options_async(data_id, headers, runtime)

    def get_agent_id_by_related_app_id_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
        headers: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='GetAgentIdByRelatedAppId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveDesigns/agentId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_agent_id_by_related_app_id_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
        headers: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='GetAgentIdByRelatedAppId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveDesigns/agentId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_agent_id_by_related_app_id(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders()
        return self.get_agent_id_by_related_app_id_with_options(request, headers, runtime)

    async def get_agent_id_by_related_app_id_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders()
        return await self.get_agent_id_by_related_app_id_with_options_async(request, headers, runtime)

    def get_all_labelable_depts_with_options(
        self,
        headers: dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllLabelableDepts',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_all_labelable_depts_with_options_async(
        self,
        headers: dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetAllLabelableDepts',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_all_labelable_depts(self) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return self.get_all_labelable_depts_with_options(headers, runtime)

    async def get_all_labelable_depts_async(self) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return await self.get_all_labelable_depts_with_options_async(headers, runtime)

    def get_app_dispatch_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetAppDispatchInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/apps/distributionInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_app_dispatch_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
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
            action='GetAppDispatchInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/apps/distributionInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_app_dispatch_info(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders()
        return self.get_app_dispatch_info_with_options(request, headers, runtime)

    async def get_app_dispatch_info_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders()
        return await self.get_app_dispatch_info_with_options_async(request, headers, runtime)

    def get_calender_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetCalenderSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/calendar/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCalenderSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_calender_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetCalenderSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/calendar/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCalenderSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_calender_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders()
        return self.get_calender_summary_with_options(data_id, headers, runtime)

    async def get_calender_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders()
        return await self.get_calender_summary_with_options_async(data_id, headers, runtime)

    def get_comment_list_with_options(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
        headers: dingtalkexclusive__1__0_models.GetCommentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
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
            action='GetCommentList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/publishers/{publisher_id}/comments/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCommentListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_comment_list_with_options_async(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
        headers: dingtalkexclusive__1__0_models.GetCommentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
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
            action='GetCommentList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/publishers/{publisher_id}/comments/list',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetCommentListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_comment_list(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return self.get_comment_list_with_options(publisher_id, request, headers, runtime)

    async def get_comment_list_async(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return await self.get_comment_list_with_options_async(publisher_id, request, headers, runtime)

    def get_conf_base_info_by_logical_id_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
        headers: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.logical_conference_id):
            query['logicalConferenceId'] = request.logical_conference_id
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
            action='GetConfBaseInfoByLogicalId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/conferences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conf_base_info_by_logical_id_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
        headers: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.logical_conference_id):
            query['logicalConferenceId'] = request.logical_conference_id
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
            action='GetConfBaseInfoByLogicalId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/conferences',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conf_base_info_by_logical_id(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders()
        return self.get_conf_base_info_by_logical_id_with_options(request, headers, runtime)

    async def get_conf_base_info_by_logical_id_async(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders()
        return await self.get_conf_base_info_by_logical_id_with_options_async(request, headers, runtime)

    def get_conference_detail_with_options(
        self,
        conference_id: str,
        headers: dingtalkexclusive__1__0_models.GetConferenceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetConferenceDetail',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/conferences/{conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConferenceDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conference_detail_with_options_async(
        self,
        conference_id: str,
        headers: dingtalkexclusive__1__0_models.GetConferenceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetConferenceDetail',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/conferences/{conference_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConferenceDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conference_detail(
        self,
        conference_id: str,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return self.get_conference_detail_with_options(conference_id, headers, runtime)

    async def get_conference_detail_async(
        self,
        conference_id: str,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return await self.get_conference_detail_with_options_async(conference_id, headers, runtime)

    def get_ding_report_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetDingReportDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/report/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ding_report_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetDingReportDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/report/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ding_report_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return self.get_ding_report_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_ding_report_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return await self.get_ding_report_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_ding_report_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDingReportSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/datas/{data_id}/reports/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDingReportSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ding_report_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDingReportSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/datas/{data_id}/reports/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDingReportSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ding_report_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders()
        return self.get_ding_report_summary_with_options(data_id, headers, runtime)

    async def get_ding_report_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders()
        return await self.get_ding_report_summary_with_options_async(data_id, headers, runtime)

    def get_doc_created_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetDocCreatedDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/doc/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_doc_created_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetDocCreatedDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/doc/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_doc_created_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return self.get_doc_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_doc_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return await self.get_doc_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_doc_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDocCreatedSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/doc/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_doc_created_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetDocCreatedSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/doc/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_doc_created_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return self.get_doc_created_summary_with_options(data_id, headers, runtime)

    async def get_doc_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return await self.get_doc_created_summary_with_options_async(data_id, headers, runtime)

    def get_exclusive_account_all_org_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
        headers: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetExclusiveAccountAllOrgList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveAccounts/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_exclusive_account_all_org_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
        headers: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.union_id):
            query['unionId'] = request.union_id
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
            action='GetExclusiveAccountAllOrgList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveAccounts/organizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_exclusive_account_all_org_list(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders()
        return self.get_exclusive_account_all_org_list_with_options(request, headers, runtime)

    async def get_exclusive_account_all_org_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders()
        return await self.get_exclusive_account_all_org_list_with_options_async(request, headers, runtime)

    def get_general_form_created_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetGeneralFormCreatedDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/generalForm/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_general_form_created_dept_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetGeneralFormCreatedDeptSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/generalForm/dept/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_general_form_created_dept_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return self.get_general_form_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_general_form_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return await self.get_general_form_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_general_form_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetGeneralFormCreatedSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/generalForm/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_general_form_created_summary_with_options_async(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetGeneralFormCreatedSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/generalForm/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_general_form_created_summary(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return self.get_general_form_created_summary_with_options(data_id, headers, runtime)

    async def get_general_form_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return await self.get_general_form_created_summary_with_options_async(data_id, headers, runtime)

    def get_group_active_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_group_id):
            query['dingGroupId'] = request.ding_group_id
        if not UtilClient.is_unset(request.group_type):
            query['groupType'] = request.group_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='GetGroupActiveInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/activeGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_group_active_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_group_id):
            query['dingGroupId'] = request.ding_group_id
        if not UtilClient.is_unset(request.group_type):
            query['groupType'] = request.group_type
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='GetGroupActiveInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/activeGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_group_active_info(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return self.get_group_active_info_with_options(request, headers, runtime)

    async def get_group_active_info_async(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return await self.get_group_active_info_with_options_async(request, headers, runtime)

    def get_in_active_user_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
        headers: dingtalkexclusive__1__0_models.GetInActiveUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            body['statDate'] = request.stat_date
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetInActiveUserList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/inactives/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetInActiveUserListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_in_active_user_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
        headers: dingtalkexclusive__1__0_models.GetInActiveUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            body['statDate'] = request.stat_date
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetInActiveUserList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/inactives/users/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetInActiveUserListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_in_active_user_list(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetInActiveUserListHeaders()
        return self.get_in_active_user_list_with_options(request, headers, runtime)

    async def get_in_active_user_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetInActiveUserListHeaders()
        return await self.get_in_active_user_list_with_options_async(request, headers, runtime)

    def get_last_org_auth_data_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
        headers: dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='GetLastOrgAuthData',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/organizations/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_last_org_auth_data_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
        headers: dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='GetLastOrgAuthData',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/organizations/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_last_org_auth_data(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders()
        return self.get_last_org_auth_data_with_options(request, headers, runtime)

    async def get_last_org_auth_data_async(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders()
        return await self.get_last_org_auth_data_with_options_async(request, headers, runtime)

    def get_oa_operator_log_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
        headers: dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_list):
            body['categoryList'] = request.category_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetOaOperatorLogList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/oaOperatorLogs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_oa_operator_log_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
        headers: dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_list):
            body['categoryList'] = request.category_list
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.op_user_id):
            body['opUserId'] = request.op_user_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetOaOperatorLogList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/oaOperatorLogs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_oa_operator_log_list(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return self.get_oa_operator_log_list_with_options(request, headers, runtime)

    async def get_oa_operator_log_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return await self.get_oa_operator_log_list_with_options_async(request, headers, runtime)

    def get_out_groups_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetOutGroupsByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/outsideGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def get_out_groups_by_page_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetOutGroupsByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/outsideGroups/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_out_groups_by_page(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders()
        return self.get_out_groups_by_page_with_options(request, headers, runtime)

    async def get_out_groups_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders()
        return await self.get_out_groups_by_page_with_options_async(request, headers, runtime)

    def get_outside_audit_group_message_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetOutsideAuditGroupMessageByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/outsideGroups/messages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def get_outside_audit_group_message_by_page_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetOutsideAuditGroupMessageByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/outsideGroups/messages/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_outside_audit_group_message_by_page(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders()
        return self.get_outside_audit_group_message_by_page_with_options(request, headers, runtime)

    async def get_outside_audit_group_message_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders()
        return await self.get_outside_audit_group_message_by_page_with_options_async(request, headers, runtime)

    def get_partner_type_by_parent_id_with_options(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetPartnerTypeByParentId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerLabels/{parent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_partner_type_by_parent_id_with_options_async(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='GetPartnerTypeByParentId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerLabels/{parent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_partner_type_by_parent_id(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return self.get_partner_type_by_parent_id_with_options(parent_id, headers, runtime)

    async def get_partner_type_by_parent_id_async(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return await self.get_partner_type_by_parent_id_with_options_async(parent_id, headers, runtime)

    def get_public_devices_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
        headers: dingtalkexclusive__1__0_models.GetPublicDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.mac_address):
            query['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            query['platform'] = request.platform
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='GetPublicDevices',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trusts/publicDevices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPublicDevicesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_public_devices_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
        headers: dingtalkexclusive__1__0_models.GetPublicDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.mac_address):
            query['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            query['platform'] = request.platform
        if not UtilClient.is_unset(request.start_time):
            query['startTime'] = request.start_time
        if not UtilClient.is_unset(request.title):
            query['title'] = request.title
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
            action='GetPublicDevices',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trusts/publicDevices',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPublicDevicesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_public_devices(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublicDevicesHeaders()
        return self.get_public_devices_with_options(request, headers, runtime)

    async def get_public_devices_async(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublicDevicesHeaders()
        return await self.get_public_devices_with_options_async(request, headers, runtime)

    def get_publisher_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetPublisherSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/publisher/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPublisherSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_publisher_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetPublisherSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/publisher/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetPublisherSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_publisher_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return self.get_publisher_summary_with_options(data_id, request, headers, runtime)

    async def get_publisher_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return await self.get_publisher_summary_with_options_async(data_id, request, headers, runtime)

    def get_real_people_records_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.person_identification):
            body['personIdentification'] = request.person_identification
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='GetRealPeopleRecords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/persons/identificationRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_real_people_records_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.person_identification):
            body['personIdentification'] = request.person_identification
        if not UtilClient.is_unset(request.scene):
            body['scene'] = request.scene
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='GetRealPeopleRecords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/persons/identificationRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_real_people_records(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders()
        return self.get_real_people_records_with_options(request, headers, runtime)

    async def get_real_people_records_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders()
        return await self.get_real_people_records_with_options_async(request, headers, runtime)

    def get_recognize_records_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.face_compare_result):
            body['faceCompareResult'] = request.face_compare_result
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='GetRecognizeRecords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/faces/recognizeRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def get_recognize_records_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.face_compare_result):
            body['faceCompareResult'] = request.face_compare_result
        if not UtilClient.is_unset(request.from_time):
            body['fromTime'] = request.from_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.to_time):
            body['toTime'] = request.to_time
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
            action='GetRecognizeRecords',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/faces/recognizeRecords/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_recognize_records(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders()
        return self.get_recognize_records_with_options(request, headers, runtime)

    async def get_recognize_records_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders()
        return await self.get_recognize_records_with_options_async(request, headers, runtime)

    def get_signed_detail_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sign_status):
            query['signStatus'] = request.sign_status
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
            action='GetSignedDetailByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def get_signed_detail_by_page_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.sign_status):
            query['signStatus'] = request.sign_status
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
            action='GetSignedDetailByPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/audits/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_signed_detail_by_page(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders()
        return self.get_signed_detail_by_page_with_options(request, headers, runtime)

    async def get_signed_detail_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders()
        return await self.get_signed_detail_by_page_with_options_async(request, headers, runtime)

    def get_trust_device_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
        headers: dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetTrustDeviceList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetTrustDeviceListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_trust_device_list_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
        headers: dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetTrustDeviceList',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/trustedDevices/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetTrustDeviceListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_trust_device_list(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders()
        return self.get_trust_device_list_with_options(request, headers, runtime)

    async def get_trust_device_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders()
        return await self.get_trust_device_list_with_options_async(request, headers, runtime)

    def get_user_app_version_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetUserAppVersionSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/appVersion/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_app_version_summary_with_options_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        UtilClient.validate_model(request)
        query = {}
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
            action='GetUserAppVersionSummary',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/appVersion/org/{data_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_app_version_summary(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return self.get_user_app_version_summary_with_options(data_id, request, headers, runtime)

    async def get_user_app_version_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return await self.get_user_app_version_summary_with_options_async(data_id, request, headers, runtime)

    def get_user_face_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserFaceStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetUserFaceState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/faces/recognizeStates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserFaceStateResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_face_state_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserFaceStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetUserFaceState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/faces/recognizeStates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserFaceStateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_face_state(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserFaceStateHeaders()
        return self.get_user_face_state_with_options(request, headers, runtime)

    async def get_user_face_state_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserFaceStateHeaders()
        return await self.get_user_face_state_with_options_async(request, headers, runtime)

    def get_user_real_people_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetUserRealPeopleState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/persons/identificationStates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_real_people_state_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='GetUserRealPeopleState',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/persons/identificationStates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_real_people_state(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders()
        return self.get_user_real_people_state_with_options(request, headers, runtime)

    async def get_user_real_people_state_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders()
        return await self.get_user_real_people_state_with_options_async(request, headers, runtime)

    def get_user_stay_length_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
        headers: dingtalkexclusive__1__0_models.GetUserStayLengthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='GetUserStayLength',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/users/stayTimes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserStayLengthResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_stay_length_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
        headers: dingtalkexclusive__1__0_models.GetUserStayLengthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.page_number):
            query['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.stat_date):
            query['statDate'] = request.stat_date
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
            action='GetUserStayLength',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/data/users/stayTimes',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetUserStayLengthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_stay_length(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserStayLengthHeaders()
        return self.get_user_stay_length_with_options(request, headers, runtime)

    async def get_user_stay_length_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserStayLengthHeaders()
        return await self.get_user_stay_length_with_options_async(request, headers, runtime)

    def list_audit_log_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
        headers: dingtalkexclusive__1__0_models.ListAuditLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.next_biz_id):
            query['nextBizId'] = request.next_biz_id
        if not UtilClient.is_unset(request.next_gmt_create):
            query['nextGmtCreate'] = request.next_gmt_create
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            action='ListAuditLog',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileAuditLogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListAuditLogResponse(),
            self.execute(params, req, runtime)
        )

    async def list_audit_log_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
        headers: dingtalkexclusive__1__0_models.ListAuditLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_date):
            query['endDate'] = request.end_date
        if not UtilClient.is_unset(request.next_biz_id):
            query['nextBizId'] = request.next_biz_id
        if not UtilClient.is_unset(request.next_gmt_create):
            query['nextGmtCreate'] = request.next_gmt_create
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.start_date):
            query['startDate'] = request.start_date
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
            action='ListAuditLog',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileAuditLogs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListAuditLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_audit_log(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListAuditLogHeaders()
        return self.list_audit_log_with_options(request, headers, runtime)

    async def list_audit_log_async(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListAuditLogHeaders()
        return await self.list_audit_log_with_options_async(request, headers, runtime)

    def list_categorys_with_options(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListCategorysRequest,
        headers: dingtalkexclusive__1__0_models.ListCategorysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkexclusive__1__0_models.ListCategorysShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='ListCategorys',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/listCategories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListCategorysResponse(),
            self.execute(params, req, runtime)
        )

    async def list_categorys_with_options_async(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListCategorysRequest,
        headers: dingtalkexclusive__1__0_models.ListCategorysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkexclusive__1__0_models.ListCategorysShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='ListCategorys',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/listCategories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListCategorysResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_categorys(
        self,
        request: dingtalkexclusive__1__0_models.ListCategorysRequest,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListCategorysHeaders()
        return self.list_categorys_with_options(request, headers, runtime)

    async def list_categorys_async(
        self,
        request: dingtalkexclusive__1__0_models.ListCategorysRequest,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListCategorysHeaders()
        return await self.list_categorys_with_options_async(request, headers, runtime)

    def list_join_org_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
        headers: dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
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
            action='ListJoinOrgInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveAccounts/organizations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def list_join_org_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
        headers: dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
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
            action='ListJoinOrgInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveAccounts/organizations/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_join_org_info(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders()
        return self.list_join_org_info_with_options(request, headers, runtime)

    async def list_join_org_info_async(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders()
        return await self.list_join_org_info_with_options_async(request, headers, runtime)

    def list_mini_app_available_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.version_type_set):
            body['versionTypeSet'] = request.version_type_set
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListMiniAppAvailableVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/availableLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def list_mini_app_available_version_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.version_type_set):
            body['versionTypeSet'] = request.version_type_set
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListMiniAppAvailableVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/availableLists',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_mini_app_available_version(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders()
        return self.list_mini_app_available_version_with_options(request, headers, runtime)

    async def list_mini_app_available_version_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders()
        return await self.list_mini_app_available_version_with_options_async(request, headers, runtime)

    def list_mini_app_history_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            action='ListMiniAppHistoryVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/historyLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def list_mini_app_history_version_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mini_app_id):
            query['miniAppId'] = request.mini_app_id
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
            action='ListMiniAppHistoryVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/historyLists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_mini_app_history_version(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders()
        return self.list_mini_app_history_version_with_options(request, headers, runtime)

    async def list_mini_app_history_version_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders()
        return await self.list_mini_app_history_version_with_options_async(request, headers, runtime)

    def list_partner_roles_with_options(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.ListPartnerRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListPartnerRoles',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/roles/{parent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListPartnerRolesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_partner_roles_with_options_async(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.ListPartnerRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='ListPartnerRoles',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/roles/{parent_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListPartnerRolesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_partner_roles(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPartnerRolesHeaders()
        return self.list_partner_roles_with_options(parent_id, headers, runtime)

    async def list_partner_roles_async(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPartnerRolesHeaders()
        return await self.list_partner_roles_with_options_async(parent_id, headers, runtime)

    def list_punch_schedule_by_condition_with_paging_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
        headers: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_instance_id):
            body['bizInstanceId'] = request.biz_instance_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.schedule_date_end):
            body['scheduleDateEnd'] = request.schedule_date_end
        if not UtilClient.is_unset(request.schedule_date_start):
            body['scheduleDateStart'] = request.schedule_date_start
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
            action='ListPunchScheduleByConditionWithPaging',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/punchSchedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse(),
            self.execute(params, req, runtime)
        )

    async def list_punch_schedule_by_condition_with_paging_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
        headers: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_instance_id):
            body['bizInstanceId'] = request.biz_instance_id
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.schedule_date_end):
            body['scheduleDateEnd'] = request.schedule_date_end
        if not UtilClient.is_unset(request.schedule_date_start):
            body['scheduleDateStart'] = request.schedule_date_start
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
            action='ListPunchScheduleByConditionWithPaging',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/punchSchedules/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_punch_schedule_by_condition_with_paging(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders()
        return self.list_punch_schedule_by_condition_with_paging_with_options(request, headers, runtime)

    async def list_punch_schedule_by_condition_with_paging_async(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders()
        return await self.list_punch_schedule_by_condition_with_paging_with_options_async(request, headers, runtime)

    def list_rules_with_options(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListRulesRequest,
        headers: dingtalkexclusive__1__0_models.ListRulesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkexclusive__1__0_models.ListRulesShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='ListRules',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules/listRules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListRulesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_rules_with_options_async(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListRulesRequest,
        headers: dingtalkexclusive__1__0_models.ListRulesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        UtilClient.validate_model(tmp_req)
        request = dingtalkexclusive__1__0_models.ListRulesShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.body):
            request.body_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.body, 'body', 'json')
        query = {}
        if not UtilClient.is_unset(request.body_shrink):
            query['body'] = request.body_shrink
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
            action='ListRules',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules/listRules',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListRulesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_rules(
        self,
        request: dingtalkexclusive__1__0_models.ListRulesRequest,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListRulesHeaders()
        return self.list_rules_with_options(request, headers, runtime)

    async def list_rules_async(
        self,
        request: dingtalkexclusive__1__0_models.ListRulesRequest,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListRulesHeaders()
        return await self.list_rules_with_options_async(request, headers, runtime)

    def logout_with_options(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
        headers: dingtalkexclusive__1__0_models.LogoutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
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
            action='Logout',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/users/logout',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.LogoutResponse(),
            self.execute(params, req, runtime)
        )

    async def logout_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
        headers: dingtalkexclusive__1__0_models.LogoutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.device_type):
            body['deviceType'] = request.device_type
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
            action='Logout',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/users/logout',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.LogoutResponse(),
            await self.execute_async(params, req, runtime)
        )

    def logout(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.LogoutHeaders()
        return self.logout_with_options(request, headers, runtime)

    async def logout_async(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.LogoutHeaders()
        return await self.logout_with_options_async(request, headers, runtime)

    def publish_file_change_notice_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
        headers: dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PublishFileChangeNotice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/comments/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse(),
            self.execute(params, req, runtime)
        )

    async def publish_file_change_notice_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
        headers: dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_id):
            body['fileId'] = request.file_id
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_union_id):
            body['operatorUnionId'] = request.operator_union_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PublishFileChangeNotice',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/comments/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def publish_file_change_notice(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders()
        return self.publish_file_change_notice_with_options(request, headers, runtime)

    async def publish_file_change_notice_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders()
        return await self.publish_file_change_notice_with_options_async(request, headers, runtime)

    def publish_rule_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
        headers: dingtalkexclusive__1__0_models.PublishRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='PublishRule',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PublishRuleResponse(),
            self.execute(params, req, runtime)
        )

    async def publish_rule_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
        headers: dingtalkexclusive__1__0_models.PublishRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        UtilClient.validate_model(request)
        body = {}
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
            action='PublishRule',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/rules/publish',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PublishRuleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def publish_rule(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishRuleHeaders()
        return self.publish_rule_with_options(request, headers, runtime)

    async def publish_rule_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishRuleHeaders()
        return await self.publish_rule_with_options_async(request, headers, runtime)

    def push_badge_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
        headers: dingtalkexclusive__1__0_models.PushBadgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.badge_items):
            body['badgeItems'] = request.badge_items
        if not UtilClient.is_unset(request.push_type):
            body['pushType'] = request.push_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PushBadge',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveDesigns/redPoints/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PushBadgeResponse(),
            self.execute(params, req, runtime)
        )

    async def push_badge_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
        headers: dingtalkexclusive__1__0_models.PushBadgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id):
            body['agentId'] = request.agent_id
        if not UtilClient.is_unset(request.badge_items):
            body['badgeItems'] = request.badge_items
        if not UtilClient.is_unset(request.push_type):
            body['pushType'] = request.push_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='PushBadge',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/exclusiveDesigns/redPoints/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PushBadgeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def push_badge(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PushBadgeHeaders()
        return self.push_badge_with_options(request, headers, runtime)

    async def push_badge_async(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PushBadgeHeaders()
        return await self.push_badge_with_options_async(request, headers, runtime)

    def query_across_cloud_stroage_configs_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_cloud_type):
            query['targetCloudType'] = request.target_cloud_type
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='QueryAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_across_cloud_stroage_configs_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_cloud_type):
            query['targetCloudType'] = request.target_cloud_type
        if not UtilClient.is_unset(request.target_corp_id):
            query['targetCorpId'] = request.target_corp_id
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
            action='QueryAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_across_cloud_stroage_configs(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders()
        return self.query_across_cloud_stroage_configs_with_options(request, headers, runtime)

    async def query_across_cloud_stroage_configs_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders()
        return await self.query_across_cloud_stroage_configs_with_options_async(request, headers, runtime)

    def query_partner_info_with_options(
        self,
        user_id: str,
        headers: dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryPartnerInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryPartnerInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_partner_info_with_options_async(
        self,
        user_id: str,
        headers: dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers
        )
        params = open_api_models.Params(
            action='QueryPartnerInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partners/users/{user_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryPartnerInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_partner_info(
        self,
        user_id: str,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders()
        return self.query_partner_info_with_options(user_id, headers, runtime)

    async def query_partner_info_async(
        self,
        user_id: str,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders()
        return await self.query_partner_info_with_options_async(user_id, headers, runtime)

    def query_user_behavior_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
        headers: dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='QueryUserBehavior',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryUserBehaviorResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_behavior_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
        headers: dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
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
            action='QueryUserBehavior',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/enterpriseSecurities/userBehaviors/screenshots/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryUserBehaviorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_behavior(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders()
        return self.query_user_behavior_with_options(request, headers, runtime)

    async def query_user_behavior_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders()
        return await self.query_user_behavior_with_options_async(request, headers, runtime)

    def rollback_mini_app_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
        headers: dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.rollback_version):
            body['rollbackVersion'] = request.rollback_version
        if not UtilClient.is_unset(request.target_version):
            body['targetVersion'] = request.target_version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollbackMiniAppVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse(),
            self.execute(params, req, runtime)
        )

    async def rollback_mini_app_version_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
        headers: dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.rollback_version):
            body['rollbackVersion'] = request.rollback_version
        if not UtilClient.is_unset(request.target_version):
            body['targetVersion'] = request.target_version
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RollbackMiniAppVersion',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/rollback',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rollback_mini_app_version(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders()
        return self.rollback_mini_app_version_with_options(request, headers, runtime)

    async def rollback_mini_app_version_async(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders()
        return await self.rollback_mini_app_version_with_options_async(request, headers, runtime)

    def save_across_cloud_stroage_configs_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.bucket_name):
            body['bucketName'] = request.bucket_name
        if not UtilClient.is_unset(request.cloud_type):
            body['cloudType'] = request.cloud_type
        if not UtilClient.is_unset(request.endpoint):
            body['endpoint'] = request.endpoint
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
            action='SaveAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse(),
            self.execute(params, req, runtime)
        )

    async def save_across_cloud_stroage_configs_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.access_key_id):
            body['accessKeyId'] = request.access_key_id
        if not UtilClient.is_unset(request.access_key_secret):
            body['accessKeySecret'] = request.access_key_secret
        if not UtilClient.is_unset(request.bucket_name):
            body['bucketName'] = request.bucket_name
        if not UtilClient.is_unset(request.cloud_type):
            body['cloudType'] = request.cloud_type
        if not UtilClient.is_unset(request.endpoint):
            body['endpoint'] = request.endpoint
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
            action='SaveAcrossCloudStroageConfigs',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/configurations',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_across_cloud_stroage_configs(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders()
        return self.save_across_cloud_stroage_configs_with_options(request, headers, runtime)

    async def save_across_cloud_stroage_configs_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders()
        return await self.save_across_cloud_stroage_configs_with_options_async(request, headers, runtime)

    def save_and_submit_auth_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.apply_remark):
            body['applyRemark'] = request.apply_remark
        if not UtilClient.is_unset(request.authorize_media_id):
            body['authorizeMediaId'] = request.authorize_media_id
        if not UtilClient.is_unset(request.industry):
            body['industry'] = request.industry
        if not UtilClient.is_unset(request.legal_person):
            body['legalPerson'] = request.legal_person
        if not UtilClient.is_unset(request.legal_person_id_card):
            body['legalPersonIdCard'] = request.legal_person_id_card
        if not UtilClient.is_unset(request.license_media_id):
            body['licenseMediaId'] = request.license_media_id
        if not UtilClient.is_unset(request.loc_city):
            body['locCity'] = request.loc_city
        if not UtilClient.is_unset(request.loc_city_name):
            body['locCityName'] = request.loc_city_name
        if not UtilClient.is_unset(request.loc_province):
            body['locProvince'] = request.loc_province
        if not UtilClient.is_unset(request.loc_province_name):
            body['locProvinceName'] = request.loc_province_name
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.organization_code):
            body['organizationCode'] = request.organization_code
        if not UtilClient.is_unset(request.organization_code_media_id):
            body['organizationCodeMediaId'] = request.organization_code_media_id
        if not UtilClient.is_unset(request.regist_location):
            body['registLocation'] = request.regist_location
        if not UtilClient.is_unset(request.regist_num):
            body['registNum'] = request.regist_num
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.unified_social_credit):
            body['unifiedSocialCredit'] = request.unified_social_credit
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveAndSubmitAuthInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/ognizations/authInfos/saveAndSubmit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def save_and_submit_auth_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.apply_remark):
            body['applyRemark'] = request.apply_remark
        if not UtilClient.is_unset(request.authorize_media_id):
            body['authorizeMediaId'] = request.authorize_media_id
        if not UtilClient.is_unset(request.industry):
            body['industry'] = request.industry
        if not UtilClient.is_unset(request.legal_person):
            body['legalPerson'] = request.legal_person
        if not UtilClient.is_unset(request.legal_person_id_card):
            body['legalPersonIdCard'] = request.legal_person_id_card
        if not UtilClient.is_unset(request.license_media_id):
            body['licenseMediaId'] = request.license_media_id
        if not UtilClient.is_unset(request.loc_city):
            body['locCity'] = request.loc_city
        if not UtilClient.is_unset(request.loc_city_name):
            body['locCityName'] = request.loc_city_name
        if not UtilClient.is_unset(request.loc_province):
            body['locProvince'] = request.loc_province
        if not UtilClient.is_unset(request.loc_province_name):
            body['locProvinceName'] = request.loc_province_name
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        if not UtilClient.is_unset(request.organization_code):
            body['organizationCode'] = request.organization_code
        if not UtilClient.is_unset(request.organization_code_media_id):
            body['organizationCodeMediaId'] = request.organization_code_media_id
        if not UtilClient.is_unset(request.regist_location):
            body['registLocation'] = request.regist_location
        if not UtilClient.is_unset(request.regist_num):
            body['registNum'] = request.regist_num
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
        if not UtilClient.is_unset(request.unified_social_credit):
            body['unifiedSocialCredit'] = request.unified_social_credit
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveAndSubmitAuthInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/ognizations/authInfos/saveAndSubmit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_and_submit_auth_info(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders()
        return self.save_and_submit_auth_info_with_options(request, headers, runtime)

    async def save_and_submit_auth_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders()
        return await self.save_and_submit_auth_info_with_options_async(request, headers, runtime)

    def save_open_terminal_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.log_source):
            body['logSource'] = request.log_source
        if not UtilClient.is_unset(request.log_type):
            body['logType'] = request.log_type
        if not UtilClient.is_unset(request.open_ext):
            body['openExt'] = request.open_ext
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveOpenTerminalInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/externalLogs/terminalInfos/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def save_open_terminal_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.log_source):
            body['logSource'] = request.log_source
        if not UtilClient.is_unset(request.log_type):
            body['logType'] = request.log_type
        if not UtilClient.is_unset(request.open_ext):
            body['openExt'] = request.open_ext
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveOpenTerminalInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/externalLogs/terminalInfos/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_open_terminal_info(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders()
        return self.save_open_terminal_info_with_options(request, headers, runtime)

    async def save_open_terminal_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders()
        return await self.save_open_terminal_info_with_options_async(request, headers, runtime)

    def save_white_app_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
        headers: dingtalkexclusive__1__0_models.SaveWhiteAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id_list):
            body['agentIdList'] = request.agent_id_list
        if not UtilClient.is_unset(request.agent_id_map):
            body['agentIdMap'] = request.agent_id_map
        if not UtilClient.is_unset(request.operation):
            body['operation'] = request.operation
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveWhiteApp',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/whiteLists/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveWhiteAppResponse(),
            self.execute(params, req, runtime)
        )

    async def save_white_app_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
        headers: dingtalkexclusive__1__0_models.SaveWhiteAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.agent_id_list):
            body['agentIdList'] = request.agent_id_list
        if not UtilClient.is_unset(request.agent_id_map):
            body['agentIdMap'] = request.agent_id_map
        if not UtilClient.is_unset(request.operation):
            body['operation'] = request.operation
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SaveWhiteApp',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/whiteLists/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveWhiteAppResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_white_app(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveWhiteAppHeaders()
        return self.save_white_app_with_options(request, headers, runtime)

    async def save_white_app_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveWhiteAppHeaders()
        return await self.save_white_app_with_options_async(request, headers, runtime)

    def search_org_inner_group_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
        headers: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.create_time_end):
            query['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            query['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.group_members_count_end):
            query['groupMembersCountEnd'] = request.group_members_count_end
        if not UtilClient.is_unset(request.group_members_count_start):
            query['groupMembersCountStart'] = request.group_members_count_start
        if not UtilClient.is_unset(request.group_name):
            query['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner):
            query['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.last_active_time_end):
            query['lastActiveTimeEnd'] = request.last_active_time_end
        if not UtilClient.is_unset(request.last_active_time_start):
            query['lastActiveTimeStart'] = request.last_active_time_start
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.page_start):
            query['pageStart'] = request.page_start
        if not UtilClient.is_unset(request.sync_to_dingpan):
            query['syncToDingpan'] = request.sync_to_dingpan
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='SearchOrgInnerGroupInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/orgGroupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def search_org_inner_group_info_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
        headers: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.create_time_end):
            query['createTimeEnd'] = request.create_time_end
        if not UtilClient.is_unset(request.create_time_start):
            query['createTimeStart'] = request.create_time_start
        if not UtilClient.is_unset(request.group_members_count_end):
            query['groupMembersCountEnd'] = request.group_members_count_end
        if not UtilClient.is_unset(request.group_members_count_start):
            query['groupMembersCountStart'] = request.group_members_count_start
        if not UtilClient.is_unset(request.group_name):
            query['groupName'] = request.group_name
        if not UtilClient.is_unset(request.group_owner):
            query['groupOwner'] = request.group_owner
        if not UtilClient.is_unset(request.last_active_time_end):
            query['lastActiveTimeEnd'] = request.last_active_time_end
        if not UtilClient.is_unset(request.last_active_time_start):
            query['lastActiveTimeStart'] = request.last_active_time_start
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.page_size):
            query['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.page_start):
            query['pageStart'] = request.page_start
        if not UtilClient.is_unset(request.sync_to_dingpan):
            query['syncToDingpan'] = request.sync_to_dingpan
        if not UtilClient.is_unset(request.uuid):
            query['uuid'] = request.uuid
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
            action='SearchOrgInnerGroupInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/orgGroupInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_org_inner_group_info(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return self.search_org_inner_group_info_with_options(request, headers, runtime)

    async def search_org_inner_group_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return await self.search_org_inner_group_info_with_options_async(request, headers, runtime)

    def send_app_ding_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
        headers: dingtalkexclusive__1__0_models.SendAppDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendAppDing',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/appDings/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendAppDingResponse(),
            self.execute(params, req, runtime)
        )

    async def send_app_ding_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
        headers: dingtalkexclusive__1__0_models.SendAppDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendAppDing',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/appDings/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendAppDingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_app_ding(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendAppDingHeaders()
        return self.send_app_ding_with_options(request, headers, runtime)

    async def send_app_ding_async(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendAppDingHeaders()
        return await self.send_app_ding_with_options_async(request, headers, runtime)

    def send_invitation_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
        headers: dingtalkexclusive__1__0_models.SendInvitationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.org_alias):
            body['orgAlias'] = request.org_alias
        if not UtilClient.is_unset(request.partner_label_id):
            body['partnerLabelId'] = request.partner_label_id
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        if not UtilClient.is_unset(request.phone):
            body['phone'] = request.phone
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendInvitation',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/invitations/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendInvitationResponse(),
            self.execute(params, req, runtime)
        )

    async def send_invitation_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
        headers: dingtalkexclusive__1__0_models.SendInvitationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.org_alias):
            body['orgAlias'] = request.org_alias
        if not UtilClient.is_unset(request.partner_label_id):
            body['partnerLabelId'] = request.partner_label_id
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        if not UtilClient.is_unset(request.phone):
            body['phone'] = request.phone
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendInvitation',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/invitations/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendInvitationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_invitation(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendInvitationHeaders()
        return self.send_invitation_with_options(request, headers, runtime)

    async def send_invitation_async(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendInvitationHeaders()
        return await self.send_invitation_with_options_async(request, headers, runtime)

    def send_phone_ding_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
        headers: dingtalkexclusive__1__0_models.SendPhoneDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendPhoneDing',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/phoneDings/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendPhoneDingResponse(),
            self.execute(params, req, runtime)
        )

    async def send_phone_ding_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
        headers: dingtalkexclusive__1__0_models.SendPhoneDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.content):
            body['content'] = request.content
        if not UtilClient.is_unset(request.userids):
            body['userids'] = request.userids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SendPhoneDing',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/phoneDings/send',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SendPhoneDingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def send_phone_ding(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendPhoneDingHeaders()
        return self.send_phone_ding_with_options(request, headers, runtime)

    async def send_phone_ding_async(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendPhoneDingHeaders()
        return await self.send_phone_ding_with_options_async(request, headers, runtime)

    def set_dept_partner_type_and_num_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
        headers: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.label_ids):
            body['labelIds'] = request.label_ids
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetDeptPartnerTypeAndNum',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse(),
            self.execute(params, req, runtime)
        )

    async def set_dept_partner_type_and_num_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
        headers: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_id):
            body['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.label_ids):
            body['labelIds'] = request.label_ids
        if not UtilClient.is_unset(request.partner_num):
            body['partnerNum'] = request.partner_num
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetDeptPartnerTypeAndNum',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_dept_partner_type_and_num(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return self.set_dept_partner_type_and_num_with_options(request, headers, runtime)

    async def set_dept_partner_type_and_num_async(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return await self.set_dept_partner_type_and_num_with_options_async(request, headers, runtime)

    def update_category_name_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
        headers: dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_category_name):
            body['currentCategoryName'] = request.current_category_name
        if not UtilClient.is_unset(request.target_category_name):
            body['targetCategoryName'] = request.target_category_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateCategoryName',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateCategoryNameResponse(),
            self.execute(params, req, runtime)
        )

    async def update_category_name_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
        headers: dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.current_category_name):
            body['currentCategoryName'] = request.current_category_name
        if not UtilClient.is_unset(request.target_category_name):
            body['targetCategoryName'] = request.target_category_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateCategoryName',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageCategories/categories/names',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateCategoryNameResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_category_name(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders()
        return self.update_category_name_with_options(request, headers, runtime)

    async def update_category_name_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders()
        return await self.update_category_name_with_options_async(request, headers, runtime)

    def update_file_status_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateFileStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_ids):
            body['requestIds'] = request.request_ids
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
            action='UpdateFileStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sending/files/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateFileStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_file_status_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateFileStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.request_ids):
            body['requestIds'] = request.request_ids
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
            action='UpdateFileStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sending/files/status',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateFileStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_file_status(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateFileStatusHeaders()
        return self.update_file_status_with_options(request, headers, runtime)

    async def update_file_status_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateFileStatusHeaders()
        return await self.update_file_status_with_options_async(request, headers, runtime)

    def update_mini_app_version_status_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        if not UtilClient.is_unset(request.version_type):
            body['versionType'] = request.version_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateMiniAppVersionStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/versionStatus',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_mini_app_version_status_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mini_app_id):
            body['miniAppId'] = request.mini_app_id
        if not UtilClient.is_unset(request.version):
            body['version'] = request.version
        if not UtilClient.is_unset(request.version_type):
            body['versionType'] = request.version_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateMiniAppVersionStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/miniApps/versions/versionStatus',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_mini_app_version_status(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders()
        return self.update_mini_app_version_status_with_options(request, headers, runtime)

    async def update_mini_app_version_status_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders()
        return await self.update_mini_app_version_status_with_options_async(request, headers, runtime)

    def update_partner_visibility_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.label_id):
            body['labelId'] = request.label_id
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
            action='UpdatePartnerVisibility',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/visibilityPartners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def update_partner_visibility_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.label_id):
            body['labelId'] = request.label_id
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
            action='UpdatePartnerVisibility',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/visibilityPartners',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_partner_visibility(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders()
        return self.update_partner_visibility_with_options(request, headers, runtime)

    async def update_partner_visibility_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders()
        return await self.update_partner_visibility_with_options_async(request, headers, runtime)

    def update_role_visibility_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.label_id):
            body['labelId'] = request.label_id
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
            action='UpdateRoleVisibility',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/visibilityRoles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def update_role_visibility_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dept_ids):
            body['deptIds'] = request.dept_ids
        if not UtilClient.is_unset(request.label_id):
            body['labelId'] = request.label_id
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
            action='UpdateRoleVisibility',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/partnerDepartments/visibilityRoles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='boolean'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_role_visibility(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders()
        return self.update_role_visibility_with_options(request, headers, runtime)

    async def update_role_visibility_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders()
        return await self.update_role_visibility_with_options_async(request, headers, runtime)

    def update_storage_mode_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
        headers: dingtalkexclusive__1__0_models.UpdateStorageModeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_storage_mode):
            body['fileStorageMode'] = request.file_storage_mode
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
            action='UpdateStorageMode',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/storageModes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateStorageModeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_storage_mode_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
        headers: dingtalkexclusive__1__0_models.UpdateStorageModeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.file_storage_mode):
            body['fileStorageMode'] = request.file_storage_mode
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
            action='UpdateStorageMode',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/fileStorages/acrossClouds/storageModes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateStorageModeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_storage_mode(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateStorageModeHeaders()
        return self.update_storage_mode_with_options(request, headers, runtime)

    async def update_storage_mode_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateStorageModeHeaders()
        return await self.update_storage_mode_with_options_async(request, headers, runtime)
