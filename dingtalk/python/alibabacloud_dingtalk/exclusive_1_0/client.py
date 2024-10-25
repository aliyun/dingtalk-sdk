# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

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

    def add_org_with_options(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
        headers: dingtalkexclusive__1__0_models.AddOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        """
        @summary 新增企业
        
        @param request: AddOrgRequest
        @param headers: AddOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.industry):
            body['industry'] = request.industry
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        real_headers = {}
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
        """
        @summary 新增企业
        
        @param request: AddOrgRequest
        @param headers: AddOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.city):
            body['city'] = request.city
        if not UtilClient.is_unset(request.industry):
            body['industry'] = request.industry
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
        if not UtilClient.is_unset(request.mobile_num):
            body['mobileNum'] = request.mobile_num
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.province):
            body['province'] = request.province
        real_headers = {}
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
        """
        @summary 新增企业
        
        @param request: AddOrgRequest
        @return: AddOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.AddOrgHeaders()
        return self.add_org_with_options(request, headers, runtime)

    async def add_org_async(
        self,
        request: dingtalkexclusive__1__0_models.AddOrgRequest,
    ) -> dingtalkexclusive__1__0_models.AddOrgResponse:
        """
        @summary 新增企业
        
        @param request: AddOrgRequest
        @return: AddOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.AddOrgHeaders()
        return await self.add_org_with_options_async(request, headers, runtime)

    def approve_process_callback_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
        headers: dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        """
        @summary 专属审批结果回调
        
        @param request: ApproveProcessCallbackRequest
        @param headers: ApproveProcessCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApproveProcessCallbackResponse
        """
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
        """
        @summary 专属审批结果回调
        
        @param request: ApproveProcessCallbackRequest
        @param headers: ApproveProcessCallbackHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ApproveProcessCallbackResponse
        """
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
        """
        @summary 专属审批结果回调
        
        @param request: ApproveProcessCallbackRequest
        @return: ApproveProcessCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders()
        return self.approve_process_callback_with_options(request, headers, runtime)

    async def approve_process_callback_async(
        self,
        request: dingtalkexclusive__1__0_models.ApproveProcessCallbackRequest,
    ) -> dingtalkexclusive__1__0_models.ApproveProcessCallbackResponse:
        """
        @summary 专属审批结果回调
        
        @param request: ApproveProcessCallbackRequest
        @return: ApproveProcessCallbackResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ApproveProcessCallbackHeaders()
        return await self.approve_process_callback_with_options_async(request, headers, runtime)

    def ban_or_open_group_words_with_options(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
        headers: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        """
        @summary 群禁言或解禁
        
        @param request: BanOrOpenGroupWordsRequest
        @param headers: BanOrOpenGroupWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BanOrOpenGroupWordsResponse
        """
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
        """
        @summary 群禁言或解禁
        
        @param request: BanOrOpenGroupWordsRequest
        @param headers: BanOrOpenGroupWordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BanOrOpenGroupWordsResponse
        """
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
        """
        @summary 群禁言或解禁
        
        @param request: BanOrOpenGroupWordsRequest
        @return: BanOrOpenGroupWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders()
        return self.ban_or_open_group_words_with_options(request, headers, runtime)

    async def ban_or_open_group_words_async(
        self,
        request: dingtalkexclusive__1__0_models.BanOrOpenGroupWordsRequest,
    ) -> dingtalkexclusive__1__0_models.BanOrOpenGroupWordsResponse:
        """
        @summary 群禁言或解禁
        
        @param request: BanOrOpenGroupWordsRequest
        @return: BanOrOpenGroupWordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.BanOrOpenGroupWordsHeaders()
        return await self.ban_or_open_group_words_with_options_async(request, headers, runtime)

    def create_category_and_binding_groups_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
        headers: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateCategoryAndBindingGroupsRequest
        @param headers: CreateCategoryAndBindingGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCategoryAndBindingGroupsResponse
        """
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
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateCategoryAndBindingGroupsRequest
        @param headers: CreateCategoryAndBindingGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCategoryAndBindingGroupsResponse
        """
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
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateCategoryAndBindingGroupsRequest
        @return: CreateCategoryAndBindingGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders()
        return self.create_category_and_binding_groups_with_options(request, headers, runtime)

    async def create_category_and_binding_groups_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsRequest,
    ) -> dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsResponse:
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateCategoryAndBindingGroupsRequest
        @return: CreateCategoryAndBindingGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateCategoryAndBindingGroupsHeaders()
        return await self.create_category_and_binding_groups_with_options_async(request, headers, runtime)

    def create_dlp_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateDlpTaskRequest,
        headers: dingtalkexclusive__1__0_models.CreateDlpTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateDlpTaskResponse:
        """
        @summary 创建文件检测任务
        
        @param request: CreateDlpTaskRequest
        @param headers: CreateDlpTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDlpTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CreateDlpTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dlpTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateDlpTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_dlp_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateDlpTaskRequest,
        headers: dingtalkexclusive__1__0_models.CreateDlpTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateDlpTaskResponse:
        """
        @summary 创建文件检测任务
        
        @param request: CreateDlpTaskRequest
        @param headers: CreateDlpTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDlpTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CreateDlpTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dlpTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateDlpTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_dlp_task(
        self,
        request: dingtalkexclusive__1__0_models.CreateDlpTaskRequest,
    ) -> dingtalkexclusive__1__0_models.CreateDlpTaskResponse:
        """
        @summary 创建文件检测任务
        
        @param request: CreateDlpTaskRequest
        @return: CreateDlpTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateDlpTaskHeaders()
        return self.create_dlp_task_with_options(request, headers, runtime)

    async def create_dlp_task_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateDlpTaskRequest,
    ) -> dingtalkexclusive__1__0_models.CreateDlpTaskResponse:
        """
        @summary 创建文件检测任务
        
        @param request: CreateDlpTaskRequest
        @return: CreateDlpTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateDlpTaskHeaders()
        return await self.create_dlp_task_with_options_async(request, headers, runtime)

    def create_message_category_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
        headers: dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateMessageCategoryRequest
        @param headers: CreateMessageCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMessageCategoryResponse
        """
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
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateMessageCategoryRequest
        @param headers: CreateMessageCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateMessageCategoryResponse
        """
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
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateMessageCategoryRequest
        @return: CreateMessageCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders()
        return self.create_message_category_with_options(request, headers, runtime)

    async def create_message_category_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateMessageCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.CreateMessageCategoryResponse:
        """
        @summary 创建分组并绑定会话
        
        @param request: CreateMessageCategoryRequest
        @return: CreateMessageCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateMessageCategoryHeaders()
        return await self.create_message_category_with_options_async(request, headers, runtime)

    def create_rule_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
        headers: dingtalkexclusive__1__0_models.CreateRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        """
        @summary 创建规则
        
        @param request: CreateRuleRequest
        @param headers: CreateRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRuleResponse
        """
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
        """
        @summary 创建规则
        
        @param request: CreateRuleRequest
        @param headers: CreateRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateRuleResponse
        """
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
        """
        @summary 创建规则
        
        @param request: CreateRuleRequest
        @return: CreateRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateRuleHeaders()
        return self.create_rule_with_options(request, headers, runtime)

    async def create_rule_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateRuleRequest,
    ) -> dingtalkexclusive__1__0_models.CreateRuleResponse:
        """
        @summary 创建规则
        
        @param request: CreateRuleRequest
        @return: CreateRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateRuleHeaders()
        return await self.create_rule_with_options_async(request, headers, runtime)

    def create_trusted_device_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        """
        @summary 存入可信设备信息
        
        @param request: CreateTrustedDeviceRequest
        @param headers: CreateTrustedDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTrustedDeviceResponse
        """
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
        """
        @summary 存入可信设备信息
        
        @param request: CreateTrustedDeviceRequest
        @param headers: CreateTrustedDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTrustedDeviceResponse
        """
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
        """
        @summary 存入可信设备信息
        
        @param request: CreateTrustedDeviceRequest
        @return: CreateTrustedDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return self.create_trusted_device_with_options(request, headers, runtime)

    async def create_trusted_device_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceResponse:
        """
        @summary 存入可信设备信息
        
        @param request: CreateTrustedDeviceRequest
        @return: CreateTrustedDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceHeaders()
        return await self.create_trusted_device_with_options_async(request, headers, runtime)

    def create_trusted_device_batch_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
        headers: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        """
        @summary 批量新增可信设备
        
        @param request: CreateTrustedDeviceBatchRequest
        @param headers: CreateTrustedDeviceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTrustedDeviceBatchResponse
        """
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
        """
        @summary 批量新增可信设备
        
        @param request: CreateTrustedDeviceBatchRequest
        @param headers: CreateTrustedDeviceBatchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTrustedDeviceBatchResponse
        """
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
        """
        @summary 批量新增可信设备
        
        @param request: CreateTrustedDeviceBatchRequest
        @return: CreateTrustedDeviceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders()
        return self.create_trusted_device_batch_with_options(request, headers, runtime)

    async def create_trusted_device_batch_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchRequest,
    ) -> dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchResponse:
        """
        @summary 批量新增可信设备
        
        @param request: CreateTrustedDeviceBatchRequest
        @return: CreateTrustedDeviceBatchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateTrustedDeviceBatchHeaders()
        return await self.create_trusted_device_batch_with_options_async(request, headers, runtime)

    def create_virus_scan_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.CreateVirusScanTaskRequest,
        headers: dingtalkexclusive__1__0_models.CreateVirusScanTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse:
        """
        @summary 触发文件病毒扫描任务
        
        @param request: CreateVirusScanTaskRequest
        @param headers: CreateVirusScanTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVirusScanTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.download_url):
            body['downloadUrl'] = request.download_url
        if not UtilClient.is_unset(request.file_md_5):
            body['fileMd5'] = request.file_md_5
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CreateVirusScanTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/virusScanTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def create_virus_scan_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateVirusScanTaskRequest,
        headers: dingtalkexclusive__1__0_models.CreateVirusScanTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse:
        """
        @summary 触发文件病毒扫描任务
        
        @param request: CreateVirusScanTaskRequest
        @param headers: CreateVirusScanTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateVirusScanTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_id):
            body['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.download_url):
            body['downloadUrl'] = request.download_url
        if not UtilClient.is_unset(request.file_md_5):
            body['fileMd5'] = request.file_md_5
        if not UtilClient.is_unset(request.file_name):
            body['fileName'] = request.file_name
        if not UtilClient.is_unset(request.file_size):
            body['fileSize'] = request.file_size
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        if not UtilClient.is_unset(request.space_id):
            body['spaceId'] = request.space_id
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
            action='CreateVirusScanTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/virusScanTasks',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_virus_scan_task(
        self,
        request: dingtalkexclusive__1__0_models.CreateVirusScanTaskRequest,
    ) -> dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse:
        """
        @summary 触发文件病毒扫描任务
        
        @param request: CreateVirusScanTaskRequest
        @return: CreateVirusScanTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateVirusScanTaskHeaders()
        return self.create_virus_scan_task_with_options(request, headers, runtime)

    async def create_virus_scan_task_async(
        self,
        request: dingtalkexclusive__1__0_models.CreateVirusScanTaskRequest,
    ) -> dingtalkexclusive__1__0_models.CreateVirusScanTaskResponse:
        """
        @summary 触发文件病毒扫描任务
        
        @param request: CreateVirusScanTaskRequest
        @return: CreateVirusScanTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.CreateVirusScanTaskHeaders()
        return await self.create_virus_scan_task_with_options_async(request, headers, runtime)

    def data_sync_with_options(
        self,
        request: dingtalkexclusive__1__0_models.DataSyncRequest,
        headers: dingtalkexclusive__1__0_models.DataSyncHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DataSyncResponse:
        """
        @summary 为应用同步数据到专属存储
        
        @param request: DataSyncRequest
        @param headers: DataSyncHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DataSyncResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sql):
            body['sql'] = request.sql
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DataSync',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/datas/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DataSyncResponse(),
            self.execute(params, req, runtime)
        )

    async def data_sync_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.DataSyncRequest,
        headers: dingtalkexclusive__1__0_models.DataSyncHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DataSyncResponse:
        """
        @summary 为应用同步数据到专属存储
        
        @param request: DataSyncRequest
        @param headers: DataSyncHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DataSyncResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sql):
            body['sql'] = request.sql
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DataSync',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/datas/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.DataSyncResponse(),
            await self.execute_async(params, req, runtime)
        )

    def data_sync(
        self,
        request: dingtalkexclusive__1__0_models.DataSyncRequest,
    ) -> dingtalkexclusive__1__0_models.DataSyncResponse:
        """
        @summary 为应用同步数据到专属存储
        
        @param request: DataSyncRequest
        @return: DataSyncResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DataSyncHeaders()
        return self.data_sync_with_options(request, headers, runtime)

    async def data_sync_async(
        self,
        request: dingtalkexclusive__1__0_models.DataSyncRequest,
    ) -> dingtalkexclusive__1__0_models.DataSyncResponse:
        """
        @summary 为应用同步数据到专属存储
        
        @param request: DataSyncRequest
        @return: DataSyncResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DataSyncHeaders()
        return await self.data_sync_with_options_async(request, headers, runtime)

    def delete_across_cloud_stroage_configs_with_options(
        self,
        target_corp_id: str,
        headers: dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        """
        @summary 删除跨云存储配置
        
        @param headers: DeleteAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAcrossCloudStroageConfigsResponse
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
        """
        @summary 删除跨云存储配置
        
        @param headers: DeleteAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteAcrossCloudStroageConfigsResponse
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
        """
        @summary 删除跨云存储配置
        
        @return: DeleteAcrossCloudStroageConfigsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsHeaders()
        return self.delete_across_cloud_stroage_configs_with_options(target_corp_id, headers, runtime)

    async def delete_across_cloud_stroage_configs_async(
        self,
        target_corp_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteAcrossCloudStroageConfigsResponse:
        """
        @summary 删除跨云存储配置
        
        @return: DeleteAcrossCloudStroageConfigsResponse
        """
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
        """
        @summary 删除评论
        
        @param headers: DeleteCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCommentResponse
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
        """
        @summary 删除评论
        
        @param headers: DeleteCommentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteCommentResponse
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
        """
        @summary 删除评论
        
        @return: DeleteCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return self.delete_comment_with_options(publisher_id, comment_id, headers, runtime)

    async def delete_comment_async(
        self,
        publisher_id: str,
        comment_id: str,
    ) -> dingtalkexclusive__1__0_models.DeleteCommentResponse:
        """
        @summary 删除评论
        
        @return: DeleteCommentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteCommentHeaders()
        return await self.delete_comment_with_options_async(publisher_id, comment_id, headers, runtime)

    def delete_trusted_device_with_options(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
        headers: dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        """
        @summary 删除指定可信设备
        
        @param request: DeleteTrustedDeviceRequest
        @param headers: DeleteTrustedDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTrustedDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
        """
        @summary 删除指定可信设备
        
        @param request: DeleteTrustedDeviceRequest
        @param headers: DeleteTrustedDeviceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTrustedDeviceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
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
        """
        @summary 删除指定可信设备
        
        @param request: DeleteTrustedDeviceRequest
        @return: DeleteTrustedDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders()
        return self.delete_trusted_device_with_options(request, headers, runtime)

    async def delete_trusted_device_async(
        self,
        request: dingtalkexclusive__1__0_models.DeleteTrustedDeviceRequest,
    ) -> dingtalkexclusive__1__0_models.DeleteTrustedDeviceResponse:
        """
        @summary 删除指定可信设备
        
        @param request: DeleteTrustedDeviceRequest
        @return: DeleteTrustedDeviceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DeleteTrustedDeviceHeaders()
        return await self.delete_trusted_device_with_options_async(request, headers, runtime)

    def distribute_partner_app_with_options(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
        headers: dingtalkexclusive__1__0_models.DistributePartnerAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        """
        @summary 分发伙伴应用
        
        @param request: DistributePartnerAppRequest
        @param headers: DistributePartnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DistributePartnerAppResponse
        """
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
        """
        @summary 分发伙伴应用
        
        @param request: DistributePartnerAppRequest
        @param headers: DistributePartnerAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DistributePartnerAppResponse
        """
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
        """
        @summary 分发伙伴应用
        
        @param request: DistributePartnerAppRequest
        @return: DistributePartnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DistributePartnerAppHeaders()
        return self.distribute_partner_app_with_options(request, headers, runtime)

    async def distribute_partner_app_async(
        self,
        request: dingtalkexclusive__1__0_models.DistributePartnerAppRequest,
    ) -> dingtalkexclusive__1__0_models.DistributePartnerAppResponse:
        """
        @summary 分发伙伴应用
        
        @param request: DistributePartnerAppRequest
        @return: DistributePartnerAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.DistributePartnerAppHeaders()
        return await self.distribute_partner_app_with_options_async(request, headers, runtime)

    def edit_security_config_member_with_options(
        self,
        request: dingtalkexclusive__1__0_models.EditSecurityConfigMemberRequest,
        headers: dingtalkexclusive__1__0_models.EditSecurityConfigMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse:
        """
        @summary 编辑安全卡片管控成员
        
        @param request: EditSecurityConfigMemberRequest
        @param headers: EditSecurityConfigMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditSecurityConfigMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_key):
            body['configKey'] = request.config_key
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
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
            action='EditSecurityConfigMember',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/configs/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def edit_security_config_member_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.EditSecurityConfigMemberRequest,
        headers: dingtalkexclusive__1__0_models.EditSecurityConfigMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse:
        """
        @summary 编辑安全卡片管控成员
        
        @param request: EditSecurityConfigMemberRequest
        @param headers: EditSecurityConfigMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: EditSecurityConfigMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_key):
            body['configKey'] = request.config_key
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operate_user_id):
            body['operateUserId'] = request.operate_user_id
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
            action='EditSecurityConfigMember',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/configs/members',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def edit_security_config_member(
        self,
        request: dingtalkexclusive__1__0_models.EditSecurityConfigMemberRequest,
    ) -> dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse:
        """
        @summary 编辑安全卡片管控成员
        
        @param request: EditSecurityConfigMemberRequest
        @return: EditSecurityConfigMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.EditSecurityConfigMemberHeaders()
        return self.edit_security_config_member_with_options(request, headers, runtime)

    async def edit_security_config_member_async(
        self,
        request: dingtalkexclusive__1__0_models.EditSecurityConfigMemberRequest,
    ) -> dingtalkexclusive__1__0_models.EditSecurityConfigMemberResponse:
        """
        @summary 编辑安全卡片管控成员
        
        @param request: EditSecurityConfigMemberRequest
        @return: EditSecurityConfigMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.EditSecurityConfigMemberHeaders()
        return await self.edit_security_config_member_with_options_async(request, headers, runtime)

    def exchange_main_admin_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ExchangeMainAdminRequest,
        headers: dingtalkexclusive__1__0_models.ExchangeMainAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ExchangeMainAdminResponse:
        """
        @summary 更换组织主管理员
        
        @param request: ExchangeMainAdminRequest
        @param headers: ExchangeMainAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExchangeMainAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.new_admin_user_id):
            body['newAdminUserId'] = request.new_admin_user_id
        if not UtilClient.is_unset(request.old_admin_user_id):
            body['oldAdminUserId'] = request.old_admin_user_id
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
            action='ExchangeMainAdmin',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/orgnizations/mainAdministrators/exchange',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ExchangeMainAdminResponse(),
            self.execute(params, req, runtime)
        )

    async def exchange_main_admin_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ExchangeMainAdminRequest,
        headers: dingtalkexclusive__1__0_models.ExchangeMainAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ExchangeMainAdminResponse:
        """
        @summary 更换组织主管理员
        
        @param request: ExchangeMainAdminRequest
        @param headers: ExchangeMainAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExchangeMainAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.new_admin_user_id):
            body['newAdminUserId'] = request.new_admin_user_id
        if not UtilClient.is_unset(request.old_admin_user_id):
            body['oldAdminUserId'] = request.old_admin_user_id
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
            action='ExchangeMainAdmin',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/orgnizations/mainAdministrators/exchange',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ExchangeMainAdminResponse(),
            await self.execute_async(params, req, runtime)
        )

    def exchange_main_admin(
        self,
        request: dingtalkexclusive__1__0_models.ExchangeMainAdminRequest,
    ) -> dingtalkexclusive__1__0_models.ExchangeMainAdminResponse:
        """
        @summary 更换组织主管理员
        
        @param request: ExchangeMainAdminRequest
        @return: ExchangeMainAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExchangeMainAdminHeaders()
        return self.exchange_main_admin_with_options(request, headers, runtime)

    async def exchange_main_admin_async(
        self,
        request: dingtalkexclusive__1__0_models.ExchangeMainAdminRequest,
    ) -> dingtalkexclusive__1__0_models.ExchangeMainAdminResponse:
        """
        @summary 更换组织主管理员
        
        @param request: ExchangeMainAdminRequest
        @return: ExchangeMainAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExchangeMainAdminHeaders()
        return await self.exchange_main_admin_with_options_async(request, headers, runtime)

    def exclusive_create_ding_portal_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
        headers: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        """
        @summary 分发工作台模版
        
        @param request: ExclusiveCreateDingPortalRequest
        @param headers: ExclusiveCreateDingPortalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExclusiveCreateDingPortalResponse
        """
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
        """
        @summary 分发工作台模版
        
        @param request: ExclusiveCreateDingPortalRequest
        @param headers: ExclusiveCreateDingPortalHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExclusiveCreateDingPortalResponse
        """
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
        """
        @summary 分发工作台模版
        
        @param request: ExclusiveCreateDingPortalRequest
        @return: ExclusiveCreateDingPortalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders()
        return self.exclusive_create_ding_portal_with_options(request, headers, runtime)

    async def exclusive_create_ding_portal_async(
        self,
        request: dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalRequest,
    ) -> dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalResponse:
        """
        @summary 分发工作台模版
        
        @param request: ExclusiveCreateDingPortalRequest
        @return: ExclusiveCreateDingPortalResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ExclusiveCreateDingPortalHeaders()
        return await self.exclusive_create_ding_portal_with_options_async(request, headers, runtime)

    def file_storage_active_storage_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        """
        @summary 专属文件第一次设置，激活配置
        
        @param request: FileStorageActiveStorageRequest
        @param headers: FileStorageActiveStorageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageActiveStorageResponse
        """
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
        """
        @summary 专属文件第一次设置，激活配置
        
        @param request: FileStorageActiveStorageRequest
        @param headers: FileStorageActiveStorageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageActiveStorageResponse
        """
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
        """
        @summary 专属文件第一次设置，激活配置
        
        @param request: FileStorageActiveStorageRequest
        @return: FileStorageActiveStorageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders()
        return self.file_storage_active_storage_with_options(request, headers, runtime)

    async def file_storage_active_storage_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageActiveStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageActiveStorageResponse:
        """
        @summary 专属文件第一次设置，激活配置
        
        @param request: FileStorageActiveStorageRequest
        @return: FileStorageActiveStorageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageActiveStorageHeaders()
        return await self.file_storage_active_storage_with_options_async(request, headers, runtime)

    def file_storage_check_connection_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        """
        @summary 检查专属存储OSS连接
        
        @param request: FileStorageCheckConnectionRequest
        @param headers: FileStorageCheckConnectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageCheckConnectionResponse
        """
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
        """
        @summary 检查专属存储OSS连接
        
        @param request: FileStorageCheckConnectionRequest
        @param headers: FileStorageCheckConnectionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageCheckConnectionResponse
        """
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
        """
        @summary 检查专属存储OSS连接
        
        @param request: FileStorageCheckConnectionRequest
        @return: FileStorageCheckConnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders()
        return self.file_storage_check_connection_with_options(request, headers, runtime)

    async def file_storage_check_connection_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageCheckConnectionRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageCheckConnectionResponse:
        """
        @summary 检查专属存储OSS连接
        
        @param request: FileStorageCheckConnectionRequest
        @return: FileStorageCheckConnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageCheckConnectionHeaders()
        return await self.file_storage_check_connection_with_options_async(request, headers, runtime)

    def file_storage_get_quota_data_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        """
        @summary 专属文件存储获取存储情况(按时间区间)
        
        @param request: FileStorageGetQuotaDataRequest
        @param headers: FileStorageGetQuotaDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageGetQuotaDataResponse
        """
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
        """
        @summary 专属文件存储获取存储情况(按时间区间)
        
        @param request: FileStorageGetQuotaDataRequest
        @param headers: FileStorageGetQuotaDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageGetQuotaDataResponse
        """
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
        """
        @summary 专属文件存储获取存储情况(按时间区间)
        
        @param request: FileStorageGetQuotaDataRequest
        @return: FileStorageGetQuotaDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders()
        return self.file_storage_get_quota_data_with_options(request, headers, runtime)

    async def file_storage_get_quota_data_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetQuotaDataRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetQuotaDataResponse:
        """
        @summary 专属文件存储获取存储情况(按时间区间)
        
        @param request: FileStorageGetQuotaDataRequest
        @return: FileStorageGetQuotaDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetQuotaDataHeaders()
        return await self.file_storage_get_quota_data_with_options_async(request, headers, runtime)

    def file_storage_get_storage_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        """
        @summary 专属文件存储获取存储情况和配置
        
        @param request: FileStorageGetStorageStateRequest
        @param headers: FileStorageGetStorageStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageGetStorageStateResponse
        """
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
        """
        @summary 专属文件存储获取存储情况和配置
        
        @param request: FileStorageGetStorageStateRequest
        @param headers: FileStorageGetStorageStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageGetStorageStateResponse
        """
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
        """
        @summary 专属文件存储获取存储情况和配置
        
        @param request: FileStorageGetStorageStateRequest
        @return: FileStorageGetStorageStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders()
        return self.file_storage_get_storage_state_with_options(request, headers, runtime)

    async def file_storage_get_storage_state_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageGetStorageStateRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageGetStorageStateResponse:
        """
        @summary 专属文件存储获取存储情况和配置
        
        @param request: FileStorageGetStorageStateRequest
        @return: FileStorageGetStorageStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageGetStorageStateHeaders()
        return await self.file_storage_get_storage_state_with_options_async(request, headers, runtime)

    def file_storage_update_storage_with_options(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
        headers: dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        """
        @summary 更新文件专属存储配置
        
        @param request: FileStorageUpdateStorageRequest
        @param headers: FileStorageUpdateStorageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageUpdateStorageResponse
        """
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
        """
        @summary 更新文件专属存储配置
        
        @param request: FileStorageUpdateStorageRequest
        @param headers: FileStorageUpdateStorageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: FileStorageUpdateStorageResponse
        """
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
        """
        @summary 更新文件专属存储配置
        
        @param request: FileStorageUpdateStorageRequest
        @return: FileStorageUpdateStorageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders()
        return self.file_storage_update_storage_with_options(request, headers, runtime)

    async def file_storage_update_storage_async(
        self,
        request: dingtalkexclusive__1__0_models.FileStorageUpdateStorageRequest,
    ) -> dingtalkexclusive__1__0_models.FileStorageUpdateStorageResponse:
        """
        @summary 更新文件专属存储配置
        
        @param request: FileStorageUpdateStorageRequest
        @return: FileStorageUpdateStorageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.FileStorageUpdateStorageHeaders()
        return await self.file_storage_update_storage_with_options_async(request, headers, runtime)

    def generate_dark_water_mark_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
        headers: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        """
        @summary 生成暗水印
        
        @param request: GenerateDarkWaterMarkRequest
        @param headers: GenerateDarkWaterMarkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateDarkWaterMarkResponse
        """
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
        """
        @summary 生成暗水印
        
        @param request: GenerateDarkWaterMarkRequest
        @param headers: GenerateDarkWaterMarkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GenerateDarkWaterMarkResponse
        """
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
        """
        @summary 生成暗水印
        
        @param request: GenerateDarkWaterMarkRequest
        @return: GenerateDarkWaterMarkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders()
        return self.generate_dark_water_mark_with_options(request, headers, runtime)

    async def generate_dark_water_mark_async(
        self,
        request: dingtalkexclusive__1__0_models.GenerateDarkWaterMarkRequest,
    ) -> dingtalkexclusive__1__0_models.GenerateDarkWaterMarkResponse:
        """
        @summary 生成暗水印
        
        @param request: GenerateDarkWaterMarkRequest
        @return: GenerateDarkWaterMarkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GenerateDarkWaterMarkHeaders()
        return await self.generate_dark_water_mark_with_options_async(request, headers, runtime)

    def get_account_transfer_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
        headers: dingtalkexclusive__1__0_models.GetAccountTransferListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        """
        @summary 获取专属钉钉账号数据迁移结果
        
        @param request: GetAccountTransferListRequest
        @param headers: GetAccountTransferListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccountTransferListResponse
        """
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
        """
        @summary 获取专属钉钉账号数据迁移结果
        
        @param request: GetAccountTransferListRequest
        @param headers: GetAccountTransferListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccountTransferListResponse
        """
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
        """
        @summary 获取专属钉钉账号数据迁移结果
        
        @param request: GetAccountTransferListRequest
        @return: GetAccountTransferListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAccountTransferListHeaders()
        return self.get_account_transfer_list_with_options(request, headers, runtime)

    async def get_account_transfer_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAccountTransferListRequest,
    ) -> dingtalkexclusive__1__0_models.GetAccountTransferListResponse:
        """
        @summary 获取专属钉钉账号数据迁移结果
        
        @param request: GetAccountTransferListRequest
        @return: GetAccountTransferListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAccountTransferListHeaders()
        return await self.get_account_transfer_list_with_options_async(request, headers, runtime)

    def get_active_user_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        """
        @summary 获得组织维度的用户dau
        
        @param headers: GetActiveUserSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActiveUserSummaryResponse
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
        """
        @summary 获得组织维度的用户dau
        
        @param headers: GetActiveUserSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActiveUserSummaryResponse
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
        """
        @summary 获得组织维度的用户dau
        
        @return: GetActiveUserSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return self.get_active_user_summary_with_options(data_id, headers, runtime)

    async def get_active_user_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetActiveUserSummaryResponse:
        """
        @summary 获得组织维度的用户dau
        
        @return: GetActiveUserSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetActiveUserSummaryHeaders()
        return await self.get_active_user_summary_with_options_async(data_id, headers, runtime)

    def get_agent_id_by_related_app_id_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
        headers: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        """
        @summary 根据AppId获取微应用在该组织下的agentId
        
        @param request: GetAgentIdByRelatedAppIdRequest
        @param headers: GetAgentIdByRelatedAppIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAgentIdByRelatedAppIdResponse
        """
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
        """
        @summary 根据AppId获取微应用在该组织下的agentId
        
        @param request: GetAgentIdByRelatedAppIdRequest
        @param headers: GetAgentIdByRelatedAppIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAgentIdByRelatedAppIdResponse
        """
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
        """
        @summary 根据AppId获取微应用在该组织下的agentId
        
        @param request: GetAgentIdByRelatedAppIdRequest
        @return: GetAgentIdByRelatedAppIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders()
        return self.get_agent_id_by_related_app_id_with_options(request, headers, runtime)

    async def get_agent_id_by_related_app_id_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdResponse:
        """
        @summary 根据AppId获取微应用在该组织下的agentId
        
        @param request: GetAgentIdByRelatedAppIdRequest
        @return: GetAgentIdByRelatedAppIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAgentIdByRelatedAppIdHeaders()
        return await self.get_agent_id_by_related_app_id_with_options_async(request, headers, runtime)

    def get_all_labelable_depts_with_options(
        self,
        headers: dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        """
        @summary 伙伴钉可打标签部门查询
        
        @param headers: GetAllLabelableDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllLabelableDeptsResponse
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
        """
        @summary 伙伴钉可打标签部门查询
        
        @param headers: GetAllLabelableDeptsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAllLabelableDeptsResponse
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
        """
        @summary 伙伴钉可打标签部门查询
        
        @return: GetAllLabelableDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return self.get_all_labelable_depts_with_options(headers, runtime)

    async def get_all_labelable_depts_async(self) -> dingtalkexclusive__1__0_models.GetAllLabelableDeptsResponse:
        """
        @summary 伙伴钉可打标签部门查询
        
        @return: GetAllLabelableDeptsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAllLabelableDeptsHeaders()
        return await self.get_all_labelable_depts_with_options_async(headers, runtime)

    def get_app_dispatch_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        """
        @summary 获得app分发信息
        
        @param request: GetAppDispatchInfoRequest
        @param headers: GetAppDispatchInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppDispatchInfoResponse
        """
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
        """
        @summary 获得app分发信息
        
        @param request: GetAppDispatchInfoRequest
        @param headers: GetAppDispatchInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAppDispatchInfoResponse
        """
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
        """
        @summary 获得app分发信息
        
        @param request: GetAppDispatchInfoRequest
        @return: GetAppDispatchInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders()
        return self.get_app_dispatch_info_with_options(request, headers, runtime)

    async def get_app_dispatch_info_async(
        self,
        request: dingtalkexclusive__1__0_models.GetAppDispatchInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetAppDispatchInfoResponse:
        """
        @summary 获得app分发信息
        
        @param request: GetAppDispatchInfoRequest
        @return: GetAppDispatchInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetAppDispatchInfoHeaders()
        return await self.get_app_dispatch_info_with_options_async(request, headers, runtime)

    def get_calender_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        """
        @summary 获得组织维度日程相关信息
        
        @param headers: GetCalenderSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCalenderSummaryResponse
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
        """
        @summary 获得组织维度日程相关信息
        
        @param headers: GetCalenderSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCalenderSummaryResponse
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
        """
        @summary 获得组织维度日程相关信息
        
        @return: GetCalenderSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCalenderSummaryHeaders()
        return self.get_calender_summary_with_options(data_id, headers, runtime)

    async def get_calender_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetCalenderSummaryResponse:
        """
        @summary 获得组织维度日程相关信息
        
        @return: GetCalenderSummaryResponse
        """
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
        """
        @summary 获取发布号的评论列表
        
        @param request: GetCommentListRequest
        @param headers: GetCommentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCommentListResponse
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
        """
        @summary 获取发布号的评论列表
        
        @param request: GetCommentListRequest
        @param headers: GetCommentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCommentListResponse
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
        """
        @summary 获取发布号的评论列表
        
        @param request: GetCommentListRequest
        @return: GetCommentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return self.get_comment_list_with_options(publisher_id, request, headers, runtime)

    async def get_comment_list_async(
        self,
        publisher_id: str,
        request: dingtalkexclusive__1__0_models.GetCommentListRequest,
    ) -> dingtalkexclusive__1__0_models.GetCommentListResponse:
        """
        @summary 获取发布号的评论列表
        
        @param request: GetCommentListRequest
        @return: GetCommentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetCommentListHeaders()
        return await self.get_comment_list_with_options_async(publisher_id, request, headers, runtime)

    def get_conf_base_info_by_logical_id_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
        headers: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        """
        @summary 根据逻辑会议id获取会议基本信息
        
        @param request: GetConfBaseInfoByLogicalIdRequest
        @param headers: GetConfBaseInfoByLogicalIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfBaseInfoByLogicalIdResponse
        """
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
        """
        @summary 根据逻辑会议id获取会议基本信息
        
        @param request: GetConfBaseInfoByLogicalIdRequest
        @param headers: GetConfBaseInfoByLogicalIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConfBaseInfoByLogicalIdResponse
        """
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
        """
        @summary 根据逻辑会议id获取会议基本信息
        
        @param request: GetConfBaseInfoByLogicalIdRequest
        @return: GetConfBaseInfoByLogicalIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders()
        return self.get_conf_base_info_by_logical_id_with_options(request, headers, runtime)

    async def get_conf_base_info_by_logical_id_async(
        self,
        request: dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdRequest,
    ) -> dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdResponse:
        """
        @summary 根据逻辑会议id获取会议基本信息
        
        @param request: GetConfBaseInfoByLogicalIdRequest
        @return: GetConfBaseInfoByLogicalIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConfBaseInfoByLogicalIdHeaders()
        return await self.get_conf_base_info_by_logical_id_with_options_async(request, headers, runtime)

    def get_conference_detail_with_options(
        self,
        conference_id: str,
        headers: dingtalkexclusive__1__0_models.GetConferenceDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        """
        @summary 获取视频会议明细
        
        @param headers: GetConferenceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConferenceDetailResponse
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
        """
        @summary 获取视频会议明细
        
        @param headers: GetConferenceDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConferenceDetailResponse
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
        """
        @summary 获取视频会议明细
        
        @return: GetConferenceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return self.get_conference_detail_with_options(conference_id, headers, runtime)

    async def get_conference_detail_async(
        self,
        conference_id: str,
    ) -> dingtalkexclusive__1__0_models.GetConferenceDetailResponse:
        """
        @summary 获取视频会议明细
        
        @return: GetConferenceDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConferenceDetailHeaders()
        return await self.get_conference_detail_with_options_async(conference_id, headers, runtime)

    def get_conversation_category_with_options(
        self,
        headers: dingtalkexclusive__1__0_models.GetConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConversationCategoryResponse:
        """
        @summary 获取会话分组数据
        
        @param headers: GetConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationCategoryResponse
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
            action='GetConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationCategories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConversationCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conversation_category_with_options_async(
        self,
        headers: dingtalkexclusive__1__0_models.GetConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConversationCategoryResponse:
        """
        @summary 获取会话分组数据
        
        @param headers: GetConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationCategoryResponse
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
            action='GetConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationCategories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConversationCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conversation_category(self) -> dingtalkexclusive__1__0_models.GetConversationCategoryResponse:
        """
        @summary 获取会话分组数据
        
        @return: GetConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConversationCategoryHeaders()
        return self.get_conversation_category_with_options(headers, runtime)

    async def get_conversation_category_async(self) -> dingtalkexclusive__1__0_models.GetConversationCategoryResponse:
        """
        @summary 获取会话分组数据
        
        @return: GetConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConversationCategoryHeaders()
        return await self.get_conversation_category_with_options_async(headers, runtime)

    def get_conversation_detail_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetConversationDetailRequest,
        headers: dingtalkexclusive__1__0_models.GetConversationDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConversationDetailResponse:
        """
        @summary 获取会话分组详情
        
        @param request: GetConversationDetailRequest
        @param headers: GetConversationDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationDetailResponse
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
            action='GetConversationDetail',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/categories/conversations/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConversationDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_conversation_detail_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetConversationDetailRequest,
        headers: dingtalkexclusive__1__0_models.GetConversationDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetConversationDetailResponse:
        """
        @summary 获取会话分组详情
        
        @param request: GetConversationDetailRequest
        @param headers: GetConversationDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetConversationDetailResponse
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
            action='GetConversationDetail',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/categories/conversations/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetConversationDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_conversation_detail(
        self,
        request: dingtalkexclusive__1__0_models.GetConversationDetailRequest,
    ) -> dingtalkexclusive__1__0_models.GetConversationDetailResponse:
        """
        @summary 获取会话分组详情
        
        @param request: GetConversationDetailRequest
        @return: GetConversationDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConversationDetailHeaders()
        return self.get_conversation_detail_with_options(request, headers, runtime)

    async def get_conversation_detail_async(
        self,
        request: dingtalkexclusive__1__0_models.GetConversationDetailRequest,
    ) -> dingtalkexclusive__1__0_models.GetConversationDetailResponse:
        """
        @summary 获取会话分组详情
        
        @param request: GetConversationDetailRequest
        @return: GetConversationDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetConversationDetailHeaders()
        return await self.get_conversation_detail_with_options_async(request, headers, runtime)

    def get_ding_report_dept_summary_with_options(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
        headers: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        """
        @summary 获取部门维度发布日志信息
        
        @param request: GetDingReportDeptSummaryRequest
        @param headers: GetDingReportDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingReportDeptSummaryResponse
        """
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
        """
        @summary 获取部门维度发布日志信息
        
        @param request: GetDingReportDeptSummaryRequest
        @param headers: GetDingReportDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingReportDeptSummaryResponse
        """
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
        """
        @summary 获取部门维度发布日志信息
        
        @param request: GetDingReportDeptSummaryRequest
        @return: GetDingReportDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return self.get_ding_report_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_ding_report_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDingReportDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDingReportDeptSummaryResponse:
        """
        @summary 获取部门维度发布日志信息
        
        @param request: GetDingReportDeptSummaryRequest
        @return: GetDingReportDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportDeptSummaryHeaders()
        return await self.get_ding_report_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_ding_report_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        """
        @summary 获取组织维度发布日志信息
        
        @param headers: GetDingReportSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingReportSummaryResponse
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
        """
        @summary 获取组织维度发布日志信息
        
        @param headers: GetDingReportSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingReportSummaryResponse
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
        """
        @summary 获取组织维度发布日志信息
        
        @return: GetDingReportSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDingReportSummaryHeaders()
        return self.get_ding_report_summary_with_options(data_id, headers, runtime)

    async def get_ding_report_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDingReportSummaryResponse:
        """
        @summary 获取组织维度发布日志信息
        
        @return: GetDingReportSummaryResponse
        """
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
        """
        @summary 获得部门维度用户创建文档数和创建文档人数
        
        @param request: GetDocCreatedDeptSummaryRequest
        @param headers: GetDocCreatedDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocCreatedDeptSummaryResponse
        """
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
        """
        @summary 获得部门维度用户创建文档数和创建文档人数
        
        @param request: GetDocCreatedDeptSummaryRequest
        @param headers: GetDocCreatedDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocCreatedDeptSummaryResponse
        """
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
        """
        @summary 获得部门维度用户创建文档数和创建文档人数
        
        @param request: GetDocCreatedDeptSummaryRequest
        @return: GetDocCreatedDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return self.get_doc_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_doc_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryResponse:
        """
        @summary 获得部门维度用户创建文档数和创建文档人数
        
        @param request: GetDocCreatedDeptSummaryRequest
        @return: GetDocCreatedDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedDeptSummaryHeaders()
        return await self.get_doc_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_doc_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        """
        @summary 获取组织维度用户创建文档数和创建文档人数
        
        @param headers: GetDocCreatedSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocCreatedSummaryResponse
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
        """
        @summary 获取组织维度用户创建文档数和创建文档人数
        
        @param headers: GetDocCreatedSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocCreatedSummaryResponse
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
        """
        @summary 获取组织维度用户创建文档数和创建文档人数
        
        @return: GetDocCreatedSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return self.get_doc_created_summary_with_options(data_id, headers, runtime)

    async def get_doc_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetDocCreatedSummaryResponse:
        """
        @summary 获取组织维度用户创建文档数和创建文档人数
        
        @return: GetDocCreatedSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetDocCreatedSummaryHeaders()
        return await self.get_doc_created_summary_with_options_async(data_id, headers, runtime)

    def get_exclusive_account_all_org_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
        headers: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        """
        @summary 获取专属账号所有组织列表
        
        @param request: GetExclusiveAccountAllOrgListRequest
        @param headers: GetExclusiveAccountAllOrgListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetExclusiveAccountAllOrgListResponse
        """
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
        """
        @summary 获取专属账号所有组织列表
        
        @param request: GetExclusiveAccountAllOrgListRequest
        @param headers: GetExclusiveAccountAllOrgListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetExclusiveAccountAllOrgListResponse
        """
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
        """
        @summary 获取专属账号所有组织列表
        
        @param request: GetExclusiveAccountAllOrgListRequest
        @return: GetExclusiveAccountAllOrgListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListHeaders()
        return self.get_exclusive_account_all_org_list_with_options(request, headers, runtime)

    async def get_exclusive_account_all_org_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListRequest,
    ) -> dingtalkexclusive__1__0_models.GetExclusiveAccountAllOrgListResponse:
        """
        @summary 获取专属账号所有组织列表
        
        @param request: GetExclusiveAccountAllOrgListRequest
        @return: GetExclusiveAccountAllOrgListResponse
        """
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
        """
        @summary 获取部门维度发布智能填表数量和使用智能填表人数
        
        @param request: GetGeneralFormCreatedDeptSummaryRequest
        @param headers: GetGeneralFormCreatedDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGeneralFormCreatedDeptSummaryResponse
        """
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
        """
        @summary 获取部门维度发布智能填表数量和使用智能填表人数
        
        @param request: GetGeneralFormCreatedDeptSummaryRequest
        @param headers: GetGeneralFormCreatedDeptSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGeneralFormCreatedDeptSummaryResponse
        """
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
        """
        @summary 获取部门维度发布智能填表数量和使用智能填表人数
        
        @param request: GetGeneralFormCreatedDeptSummaryRequest
        @return: GetGeneralFormCreatedDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return self.get_general_form_created_dept_summary_with_options(data_id, request, headers, runtime)

    async def get_general_form_created_dept_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryResponse:
        """
        @summary 获取部门维度发布智能填表数量和使用智能填表人数
        
        @param request: GetGeneralFormCreatedDeptSummaryRequest
        @return: GetGeneralFormCreatedDeptSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedDeptSummaryHeaders()
        return await self.get_general_form_created_dept_summary_with_options_async(data_id, request, headers, runtime)

    def get_general_form_created_summary_with_options(
        self,
        data_id: str,
        headers: dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        """
        @summary 获取组织维度发布智能填表数量和使用智能填表人数
        
        @param headers: GetGeneralFormCreatedSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGeneralFormCreatedSummaryResponse
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
        """
        @summary 获取组织维度发布智能填表数量和使用智能填表人数
        
        @param headers: GetGeneralFormCreatedSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGeneralFormCreatedSummaryResponse
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
        """
        @summary 获取组织维度发布智能填表数量和使用智能填表人数
        
        @return: GetGeneralFormCreatedSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return self.get_general_form_created_summary_with_options(data_id, headers, runtime)

    async def get_general_form_created_summary_async(
        self,
        data_id: str,
    ) -> dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryResponse:
        """
        @summary 获取组织维度发布智能填表数量和使用智能填表人数
        
        @return: GetGeneralFormCreatedSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGeneralFormCreatedSummaryHeaders()
        return await self.get_general_form_created_summary_with_options_async(data_id, headers, runtime)

    def get_group_active_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
        headers: dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        """
        @summary 获取群活跃明细
        
        @param request: GetGroupActiveInfoRequest
        @param headers: GetGroupActiveInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupActiveInfoResponse
        """
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
        """
        @summary 获取群活跃明细
        
        @param request: GetGroupActiveInfoRequest
        @param headers: GetGroupActiveInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetGroupActiveInfoResponse
        """
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
        """
        @summary 获取群活跃明细
        
        @param request: GetGroupActiveInfoRequest
        @return: GetGroupActiveInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return self.get_group_active_info_with_options(request, headers, runtime)

    async def get_group_active_info_async(
        self,
        request: dingtalkexclusive__1__0_models.GetGroupActiveInfoRequest,
    ) -> dingtalkexclusive__1__0_models.GetGroupActiveInfoResponse:
        """
        @summary 获取群活跃明细
        
        @param request: GetGroupActiveInfoRequest
        @return: GetGroupActiveInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetGroupActiveInfoHeaders()
        return await self.get_group_active_info_with_options_async(request, headers, runtime)

    def get_in_active_user_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
        headers: dingtalkexclusive__1__0_models.GetInActiveUserListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        """
        @summary 获取未活跃用户登陆统计明细
        
        @param request: GetInActiveUserListRequest
        @param headers: GetInActiveUserListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInActiveUserListResponse
        """
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
        """
        @summary 获取未活跃用户登陆统计明细
        
        @param request: GetInActiveUserListRequest
        @param headers: GetInActiveUserListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetInActiveUserListResponse
        """
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
        """
        @summary 获取未活跃用户登陆统计明细
        
        @param request: GetInActiveUserListRequest
        @return: GetInActiveUserListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetInActiveUserListHeaders()
        return self.get_in_active_user_list_with_options(request, headers, runtime)

    async def get_in_active_user_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetInActiveUserListRequest,
    ) -> dingtalkexclusive__1__0_models.GetInActiveUserListResponse:
        """
        @summary 获取未活跃用户登陆统计明细
        
        @param request: GetInActiveUserListRequest
        @return: GetInActiveUserListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetInActiveUserListHeaders()
        return await self.get_in_active_user_list_with_options_async(request, headers, runtime)

    def get_last_org_auth_data_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
        headers: dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        """
        @summary 获取最后一次验证通过的企业认证信息
        
        @param request: GetLastOrgAuthDataRequest
        @param headers: GetLastOrgAuthDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLastOrgAuthDataResponse
        """
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
        """
        @summary 获取最后一次验证通过的企业认证信息
        
        @param request: GetLastOrgAuthDataRequest
        @param headers: GetLastOrgAuthDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLastOrgAuthDataResponse
        """
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
        """
        @summary 获取最后一次验证通过的企业认证信息
        
        @param request: GetLastOrgAuthDataRequest
        @return: GetLastOrgAuthDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders()
        return self.get_last_org_auth_data_with_options(request, headers, runtime)

    async def get_last_org_auth_data_async(
        self,
        request: dingtalkexclusive__1__0_models.GetLastOrgAuthDataRequest,
    ) -> dingtalkexclusive__1__0_models.GetLastOrgAuthDataResponse:
        """
        @summary 获取最后一次验证通过的企业认证信息
        
        @param request: GetLastOrgAuthDataRequest
        @return: GetLastOrgAuthDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetLastOrgAuthDataHeaders()
        return await self.get_last_org_auth_data_with_options_async(request, headers, runtime)

    def get_msg_config_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgConfigRequest,
        headers: dingtalkexclusive__1__0_models.GetMsgConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetMsgConfigResponse:
        """
        @summary 消息规则配置和群属性接口
        
        @param request: GetMsgConfigRequest
        @param headers: GetMsgConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMsgConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_topic):
            body['groupTopic'] = request.group_topic
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.list_dynamic_attr):
            body['listDynamicAttr'] = request.list_dynamic_attr
        if not UtilClient.is_unset(request.list_employee_code):
            body['listEmployeeCode'] = request.list_employee_code
        if not UtilClient.is_unset(request.list_unit_id):
            body['listUnitId'] = request.list_unit_id
        if not UtilClient.is_unset(request.owner_job_no):
            body['ownerJobNo'] = request.owner_job_no
        if not UtilClient.is_unset(request.rule_business_code):
            body['ruleBusinessCode'] = request.rule_business_code
        if not UtilClient.is_unset(request.rule_category):
            body['ruleCategory'] = request.rule_category
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.sys_code):
            body['sysCode'] = request.sys_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetMsgConfig',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/msgConfigs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetMsgConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def get_msg_config_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgConfigRequest,
        headers: dingtalkexclusive__1__0_models.GetMsgConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetMsgConfigResponse:
        """
        @summary 消息规则配置和群属性接口
        
        @param request: GetMsgConfigRequest
        @param headers: GetMsgConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMsgConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_topic):
            body['groupTopic'] = request.group_topic
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.list_dynamic_attr):
            body['listDynamicAttr'] = request.list_dynamic_attr
        if not UtilClient.is_unset(request.list_employee_code):
            body['listEmployeeCode'] = request.list_employee_code
        if not UtilClient.is_unset(request.list_unit_id):
            body['listUnitId'] = request.list_unit_id
        if not UtilClient.is_unset(request.owner_job_no):
            body['ownerJobNo'] = request.owner_job_no
        if not UtilClient.is_unset(request.rule_business_code):
            body['ruleBusinessCode'] = request.rule_business_code
        if not UtilClient.is_unset(request.rule_category):
            body['ruleCategory'] = request.rule_category
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.sys_code):
            body['sysCode'] = request.sys_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetMsgConfig',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/msgConfigs/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetMsgConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_msg_config(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgConfigRequest,
    ) -> dingtalkexclusive__1__0_models.GetMsgConfigResponse:
        """
        @summary 消息规则配置和群属性接口
        
        @param request: GetMsgConfigRequest
        @return: GetMsgConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetMsgConfigHeaders()
        return self.get_msg_config_with_options(request, headers, runtime)

    async def get_msg_config_async(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgConfigRequest,
    ) -> dingtalkexclusive__1__0_models.GetMsgConfigResponse:
        """
        @summary 消息规则配置和群属性接口
        
        @param request: GetMsgConfigRequest
        @return: GetMsgConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetMsgConfigHeaders()
        return await self.get_msg_config_with_options_async(request, headers, runtime)

    def get_msg_location_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgLocationRequest,
        headers: dingtalkexclusive__1__0_models.GetMsgLocationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetMsgLocationResponse:
        """
        @summary 获取消息定位链接
        
        @param request: GetMsgLocationRequest
        @param headers: GetMsgLocationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMsgLocationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_id):
            body['openMsgId'] = request.open_msg_id
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
            action='GetMsgLocation',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageLocations/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetMsgLocationResponse(),
            self.execute(params, req, runtime)
        )

    async def get_msg_location_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgLocationRequest,
        headers: dingtalkexclusive__1__0_models.GetMsgLocationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetMsgLocationResponse:
        """
        @summary 获取消息定位链接
        
        @param request: GetMsgLocationRequest
        @param headers: GetMsgLocationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMsgLocationResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.open_msg_id):
            body['openMsgId'] = request.open_msg_id
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
            action='GetMsgLocation',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/messageLocations/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetMsgLocationResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_msg_location(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgLocationRequest,
    ) -> dingtalkexclusive__1__0_models.GetMsgLocationResponse:
        """
        @summary 获取消息定位链接
        
        @param request: GetMsgLocationRequest
        @return: GetMsgLocationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetMsgLocationHeaders()
        return self.get_msg_location_with_options(request, headers, runtime)

    async def get_msg_location_async(
        self,
        request: dingtalkexclusive__1__0_models.GetMsgLocationRequest,
    ) -> dingtalkexclusive__1__0_models.GetMsgLocationResponse:
        """
        @summary 获取消息定位链接
        
        @param request: GetMsgLocationRequest
        @return: GetMsgLocationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetMsgLocationHeaders()
        return await self.get_msg_location_with_options_async(request, headers, runtime)

    def get_oa_operator_log_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
        headers: dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        """
        @summary 获取oa后台操作日志记录
        
        @param request: GetOaOperatorLogListRequest
        @param headers: GetOaOperatorLogListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOaOperatorLogListResponse
        """
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
        """
        @summary 获取oa后台操作日志记录
        
        @param request: GetOaOperatorLogListRequest
        @param headers: GetOaOperatorLogListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOaOperatorLogListResponse
        """
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
        """
        @summary 获取oa后台操作日志记录
        
        @param request: GetOaOperatorLogListRequest
        @return: GetOaOperatorLogListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return self.get_oa_operator_log_list_with_options(request, headers, runtime)

    async def get_oa_operator_log_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOaOperatorLogListRequest,
    ) -> dingtalkexclusive__1__0_models.GetOaOperatorLogListResponse:
        """
        @summary 获取oa后台操作日志记录
        
        @param request: GetOaOperatorLogListRequest
        @return: GetOaOperatorLogListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOaOperatorLogListHeaders()
        return await self.get_oa_operator_log_list_with_options_async(request, headers, runtime)

    def get_out_groups_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        """
        @summary 获取企业的外部审计群列表
        
        @param request: GetOutGroupsByPageRequest
        @param headers: GetOutGroupsByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOutGroupsByPageResponse
        """
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
        """
        @summary 获取企业的外部审计群列表
        
        @param request: GetOutGroupsByPageRequest
        @param headers: GetOutGroupsByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOutGroupsByPageResponse
        """
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
        """
        @summary 获取企业的外部审计群列表
        
        @param request: GetOutGroupsByPageRequest
        @return: GetOutGroupsByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders()
        return self.get_out_groups_by_page_with_options(request, headers, runtime)

    async def get_out_groups_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutGroupsByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutGroupsByPageResponse:
        """
        @summary 获取企业的外部审计群列表
        
        @param request: GetOutGroupsByPageRequest
        @return: GetOutGroupsByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutGroupsByPageHeaders()
        return await self.get_out_groups_by_page_with_options_async(request, headers, runtime)

    def get_outside_audit_group_message_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        """
        @summary 获取外部审计群消息记录
        
        @param request: GetOutsideAuditGroupMessageByPageRequest
        @param headers: GetOutsideAuditGroupMessageByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOutsideAuditGroupMessageByPageResponse
        """
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
        """
        @summary 获取外部审计群消息记录
        
        @param request: GetOutsideAuditGroupMessageByPageRequest
        @param headers: GetOutsideAuditGroupMessageByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOutsideAuditGroupMessageByPageResponse
        """
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
        """
        @summary 获取外部审计群消息记录
        
        @param request: GetOutsideAuditGroupMessageByPageRequest
        @return: GetOutsideAuditGroupMessageByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders()
        return self.get_outside_audit_group_message_by_page_with_options(request, headers, runtime)

    async def get_outside_audit_group_message_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageResponse:
        """
        @summary 获取外部审计群消息记录
        
        @param request: GetOutsideAuditGroupMessageByPageRequest
        @return: GetOutsideAuditGroupMessageByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetOutsideAuditGroupMessageByPageHeaders()
        return await self.get_outside_audit_group_message_by_page_with_options_async(request, headers, runtime)

    def get_partner_type_by_parent_id_with_options(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        """
        @summary 伙伴钉根据父标签查询子标签
        
        @param headers: GetPartnerTypeByParentIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPartnerTypeByParentIdResponse
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
        """
        @summary 伙伴钉根据父标签查询子标签
        
        @param headers: GetPartnerTypeByParentIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPartnerTypeByParentIdResponse
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
        """
        @summary 伙伴钉根据父标签查询子标签
        
        @return: GetPartnerTypeByParentIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return self.get_partner_type_by_parent_id_with_options(parent_id, headers, runtime)

    async def get_partner_type_by_parent_id_async(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdResponse:
        """
        @summary 伙伴钉根据父标签查询子标签
        
        @return: GetPartnerTypeByParentIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPartnerTypeByParentIdHeaders()
        return await self.get_partner_type_by_parent_id_with_options_async(parent_id, headers, runtime)

    def get_public_devices_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
        headers: dingtalkexclusive__1__0_models.GetPublicDevicesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        """
        @summary 获取公共设备列表。
        
        @param request: GetPublicDevicesRequest
        @param headers: GetPublicDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPublicDevicesResponse
        """
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
        """
        @summary 获取公共设备列表。
        
        @param request: GetPublicDevicesRequest
        @param headers: GetPublicDevicesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPublicDevicesResponse
        """
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
        """
        @summary 获取公共设备列表。
        
        @param request: GetPublicDevicesRequest
        @return: GetPublicDevicesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublicDevicesHeaders()
        return self.get_public_devices_with_options(request, headers, runtime)

    async def get_public_devices_async(
        self,
        request: dingtalkexclusive__1__0_models.GetPublicDevicesRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublicDevicesResponse:
        """
        @summary 获取公共设备列表。
        
        @param request: GetPublicDevicesRequest
        @return: GetPublicDevicesResponse
        """
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
        """
        @summary 获取互动服务窗相关数据
        
        @param request: GetPublisherSummaryRequest
        @param headers: GetPublisherSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPublisherSummaryResponse
        """
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
        """
        @summary 获取互动服务窗相关数据
        
        @param request: GetPublisherSummaryRequest
        @param headers: GetPublisherSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetPublisherSummaryResponse
        """
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
        """
        @summary 获取互动服务窗相关数据
        
        @param request: GetPublisherSummaryRequest
        @return: GetPublisherSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return self.get_publisher_summary_with_options(data_id, request, headers, runtime)

    async def get_publisher_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetPublisherSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetPublisherSummaryResponse:
        """
        @summary 获取互动服务窗相关数据
        
        @param request: GetPublisherSummaryRequest
        @return: GetPublisherSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetPublisherSummaryHeaders()
        return await self.get_publisher_summary_with_options_async(data_id, request, headers, runtime)

    def get_real_people_records_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        """
        @summary 获取实人认证接口调用记录
        
        @param request: GetRealPeopleRecordsRequest
        @param headers: GetRealPeopleRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRealPeopleRecordsResponse
        """
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
        """
        @summary 获取实人认证接口调用记录
        
        @param request: GetRealPeopleRecordsRequest
        @param headers: GetRealPeopleRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRealPeopleRecordsResponse
        """
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
        """
        @summary 获取实人认证接口调用记录
        
        @param request: GetRealPeopleRecordsRequest
        @return: GetRealPeopleRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders()
        return self.get_real_people_records_with_options(request, headers, runtime)

    async def get_real_people_records_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRealPeopleRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRealPeopleRecordsResponse:
        """
        @summary 获取实人认证接口调用记录
        
        @param request: GetRealPeopleRecordsRequest
        @return: GetRealPeopleRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRealPeopleRecordsHeaders()
        return await self.get_real_people_records_with_options_async(request, headers, runtime)

    def get_recognize_records_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
        headers: dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        """
        @summary 获取人脸对比接口调用记录
        
        @param request: GetRecognizeRecordsRequest
        @param headers: GetRecognizeRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecognizeRecordsResponse
        """
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
        """
        @summary 获取人脸对比接口调用记录
        
        @param request: GetRecognizeRecordsRequest
        @param headers: GetRecognizeRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRecognizeRecordsResponse
        """
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
        """
        @summary 获取人脸对比接口调用记录
        
        @param request: GetRecognizeRecordsRequest
        @return: GetRecognizeRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders()
        return self.get_recognize_records_with_options(request, headers, runtime)

    async def get_recognize_records_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRecognizeRecordsRequest,
    ) -> dingtalkexclusive__1__0_models.GetRecognizeRecordsResponse:
        """
        @summary 获取人脸对比接口调用记录
        
        @param request: GetRecognizeRecordsRequest
        @return: GetRecognizeRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRecognizeRecordsHeaders()
        return await self.get_recognize_records_with_options_async(request, headers, runtime)

    def get_robot_info_by_code_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetRobotInfoByCodeRequest,
        headers: dingtalkexclusive__1__0_models.GetRobotInfoByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse:
        """
        @summary 根据机器人标识查询机器人信息
        
        @param request: GetRobotInfoByCodeRequest
        @param headers: GetRobotInfoByCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRobotInfoByCodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='GetRobotInfoByCode',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/robots/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse(),
            self.execute(params, req, runtime)
        )

    async def get_robot_info_by_code_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRobotInfoByCodeRequest,
        headers: dingtalkexclusive__1__0_models.GetRobotInfoByCodeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse:
        """
        @summary 根据机器人标识查询机器人信息
        
        @param request: GetRobotInfoByCodeRequest
        @param headers: GetRobotInfoByCodeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetRobotInfoByCodeResponse
        """
        UtilClient.validate_model(request)
        query = {}
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
            action='GetRobotInfoByCode',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/robots/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_robot_info_by_code(
        self,
        request: dingtalkexclusive__1__0_models.GetRobotInfoByCodeRequest,
    ) -> dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse:
        """
        @summary 根据机器人标识查询机器人信息
        
        @param request: GetRobotInfoByCodeRequest
        @return: GetRobotInfoByCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRobotInfoByCodeHeaders()
        return self.get_robot_info_by_code_with_options(request, headers, runtime)

    async def get_robot_info_by_code_async(
        self,
        request: dingtalkexclusive__1__0_models.GetRobotInfoByCodeRequest,
    ) -> dingtalkexclusive__1__0_models.GetRobotInfoByCodeResponse:
        """
        @summary 根据机器人标识查询机器人信息
        
        @param request: GetRobotInfoByCodeRequest
        @return: GetRobotInfoByCodeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetRobotInfoByCodeHeaders()
        return await self.get_robot_info_by_code_with_options_async(request, headers, runtime)

    def get_security_config_member_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetSecurityConfigMemberRequest,
        headers: dingtalkexclusive__1__0_models.GetSecurityConfigMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse:
        """
        @summary 获取安全管控卡片成员
        
        @param request: GetSecurityConfigMemberRequest
        @param headers: GetSecurityConfigMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSecurityConfigMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_key):
            body['configKey'] = request.config_key
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSecurityConfigMember',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/configs/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse(),
            self.execute(params, req, runtime)
        )

    async def get_security_config_member_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetSecurityConfigMemberRequest,
        headers: dingtalkexclusive__1__0_models.GetSecurityConfigMemberHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse:
        """
        @summary 获取安全管控卡片成员
        
        @param request: GetSecurityConfigMemberRequest
        @param headers: GetSecurityConfigMemberHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSecurityConfigMemberResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.config_key):
            body['configKey'] = request.config_key
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetSecurityConfigMember',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/securities/configs/members/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_security_config_member(
        self,
        request: dingtalkexclusive__1__0_models.GetSecurityConfigMemberRequest,
    ) -> dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse:
        """
        @summary 获取安全管控卡片成员
        
        @param request: GetSecurityConfigMemberRequest
        @return: GetSecurityConfigMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSecurityConfigMemberHeaders()
        return self.get_security_config_member_with_options(request, headers, runtime)

    async def get_security_config_member_async(
        self,
        request: dingtalkexclusive__1__0_models.GetSecurityConfigMemberRequest,
    ) -> dingtalkexclusive__1__0_models.GetSecurityConfigMemberResponse:
        """
        @summary 获取安全管控卡片成员
        
        @param request: GetSecurityConfigMemberRequest
        @return: GetSecurityConfigMemberResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSecurityConfigMemberHeaders()
        return await self.get_security_config_member_with_options_async(request, headers, runtime)

    def get_signed_detail_by_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
        headers: dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        """
        @summary 获取审计协议签署人员信息
        
        @param request: GetSignedDetailByPageRequest
        @param headers: GetSignedDetailByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignedDetailByPageResponse
        """
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
        """
        @summary 获取审计协议签署人员信息
        
        @param request: GetSignedDetailByPageRequest
        @param headers: GetSignedDetailByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSignedDetailByPageResponse
        """
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
        """
        @summary 获取审计协议签署人员信息
        
        @param request: GetSignedDetailByPageRequest
        @return: GetSignedDetailByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders()
        return self.get_signed_detail_by_page_with_options(request, headers, runtime)

    async def get_signed_detail_by_page_async(
        self,
        request: dingtalkexclusive__1__0_models.GetSignedDetailByPageRequest,
    ) -> dingtalkexclusive__1__0_models.GetSignedDetailByPageResponse:
        """
        @summary 获取审计协议签署人员信息
        
        @param request: GetSignedDetailByPageRequest
        @return: GetSignedDetailByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetSignedDetailByPageHeaders()
        return await self.get_signed_detail_by_page_with_options_async(request, headers, runtime)

    def get_trust_device_list_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
        headers: dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        """
        @summary 获取多个可信设备信息，包括mac地址、staffId、platform
        
        @param request: GetTrustDeviceListRequest
        @param headers: GetTrustDeviceListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrustDeviceListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.gmt_modified_end):
            body['gmtModifiedEnd'] = request.gmt_modified_end
        if not UtilClient.is_unset(request.gmt_modified_start):
            body['gmtModifiedStart'] = request.gmt_modified_start
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
        """
        @summary 获取多个可信设备信息，包括mac地址、staffId、platform
        
        @param request: GetTrustDeviceListRequest
        @param headers: GetTrustDeviceListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTrustDeviceListResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.gmt_create_end):
            body['gmtCreateEnd'] = request.gmt_create_end
        if not UtilClient.is_unset(request.gmt_create_start):
            body['gmtCreateStart'] = request.gmt_create_start
        if not UtilClient.is_unset(request.gmt_modified_end):
            body['gmtModifiedEnd'] = request.gmt_modified_end
        if not UtilClient.is_unset(request.gmt_modified_start):
            body['gmtModifiedStart'] = request.gmt_modified_start
        if not UtilClient.is_unset(request.mac_address):
            body['macAddress'] = request.mac_address
        if not UtilClient.is_unset(request.page_number):
            body['pageNumber'] = request.page_number
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
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
        """
        @summary 获取多个可信设备信息，包括mac地址、staffId、platform
        
        @param request: GetTrustDeviceListRequest
        @return: GetTrustDeviceListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetTrustDeviceListHeaders()
        return self.get_trust_device_list_with_options(request, headers, runtime)

    async def get_trust_device_list_async(
        self,
        request: dingtalkexclusive__1__0_models.GetTrustDeviceListRequest,
    ) -> dingtalkexclusive__1__0_models.GetTrustDeviceListResponse:
        """
        @summary 获取多个可信设备信息，包括mac地址、staffId、platform
        
        @param request: GetTrustDeviceListRequest
        @return: GetTrustDeviceListResponse
        """
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
        """
        @summary 获得组织维度用户版本分布情况
        
        @param request: GetUserAppVersionSummaryRequest
        @param headers: GetUserAppVersionSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAppVersionSummaryResponse
        """
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
        """
        @summary 获得组织维度用户版本分布情况
        
        @param request: GetUserAppVersionSummaryRequest
        @param headers: GetUserAppVersionSummaryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserAppVersionSummaryResponse
        """
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
        """
        @summary 获得组织维度用户版本分布情况
        
        @param request: GetUserAppVersionSummaryRequest
        @return: GetUserAppVersionSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return self.get_user_app_version_summary_with_options(data_id, request, headers, runtime)

    async def get_user_app_version_summary_async(
        self,
        data_id: str,
        request: dingtalkexclusive__1__0_models.GetUserAppVersionSummaryRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserAppVersionSummaryResponse:
        """
        @summary 获得组织维度用户版本分布情况
        
        @param request: GetUserAppVersionSummaryRequest
        @return: GetUserAppVersionSummaryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserAppVersionSummaryHeaders()
        return await self.get_user_app_version_summary_with_options_async(data_id, request, headers, runtime)

    def get_user_face_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserFaceStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        """
        @summary 人脸录入状态查询
        
        @param request: GetUserFaceStateRequest
        @param headers: GetUserFaceStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserFaceStateResponse
        """
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
        """
        @summary 人脸录入状态查询
        
        @param request: GetUserFaceStateRequest
        @param headers: GetUserFaceStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserFaceStateResponse
        """
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
        """
        @summary 人脸录入状态查询
        
        @param request: GetUserFaceStateRequest
        @return: GetUserFaceStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserFaceStateHeaders()
        return self.get_user_face_state_with_options(request, headers, runtime)

    async def get_user_face_state_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserFaceStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserFaceStateResponse:
        """
        @summary 人脸录入状态查询
        
        @param request: GetUserFaceStateRequest
        @return: GetUserFaceStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserFaceStateHeaders()
        return await self.get_user_face_state_with_options_async(request, headers, runtime)

    def get_user_real_people_state_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
        headers: dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        """
        @summary 实人认证状态查询
        
        @param request: GetUserRealPeopleStateRequest
        @param headers: GetUserRealPeopleStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserRealPeopleStateResponse
        """
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
        """
        @summary 实人认证状态查询
        
        @param request: GetUserRealPeopleStateRequest
        @param headers: GetUserRealPeopleStateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserRealPeopleStateResponse
        """
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
        """
        @summary 实人认证状态查询
        
        @param request: GetUserRealPeopleStateRequest
        @return: GetUserRealPeopleStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders()
        return self.get_user_real_people_state_with_options(request, headers, runtime)

    async def get_user_real_people_state_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserRealPeopleStateRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserRealPeopleStateResponse:
        """
        @summary 实人认证状态查询
        
        @param request: GetUserRealPeopleStateRequest
        @return: GetUserRealPeopleStateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserRealPeopleStateHeaders()
        return await self.get_user_real_people_state_with_options_async(request, headers, runtime)

    def get_user_stay_length_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
        headers: dingtalkexclusive__1__0_models.GetUserStayLengthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        """
        @summary 获取用户停留时长
        
        @param request: GetUserStayLengthRequest
        @param headers: GetUserStayLengthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserStayLengthResponse
        """
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
        """
        @summary 获取用户停留时长
        
        @param request: GetUserStayLengthRequest
        @param headers: GetUserStayLengthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserStayLengthResponse
        """
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
        """
        @summary 获取用户停留时长
        
        @param request: GetUserStayLengthRequest
        @return: GetUserStayLengthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserStayLengthHeaders()
        return self.get_user_stay_length_with_options(request, headers, runtime)

    async def get_user_stay_length_async(
        self,
        request: dingtalkexclusive__1__0_models.GetUserStayLengthRequest,
    ) -> dingtalkexclusive__1__0_models.GetUserStayLengthResponse:
        """
        @summary 获取用户停留时长
        
        @param request: GetUserStayLengthRequest
        @return: GetUserStayLengthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetUserStayLengthHeaders()
        return await self.get_user_stay_length_with_options_async(request, headers, runtime)

    def get_virus_scan_result_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GetVirusScanResultRequest,
        headers: dingtalkexclusive__1__0_models.GetVirusScanResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetVirusScanResultResponse:
        """
        @summary 获取文件病毒扫描结果
        
        @param request: GetVirusScanResultRequest
        @param headers: GetVirusScanResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetVirusScanResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetVirusScanResult',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/virusScanTasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetVirusScanResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_virus_scan_result_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GetVirusScanResultRequest,
        headers: dingtalkexclusive__1__0_models.GetVirusScanResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GetVirusScanResultResponse:
        """
        @summary 获取文件病毒扫描结果
        
        @param request: GetVirusScanResultRequest
        @param headers: GetVirusScanResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetVirusScanResultResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.task_id):
            body['taskId'] = request.task_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetVirusScanResult',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/virusScanTasks/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GetVirusScanResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_virus_scan_result(
        self,
        request: dingtalkexclusive__1__0_models.GetVirusScanResultRequest,
    ) -> dingtalkexclusive__1__0_models.GetVirusScanResultResponse:
        """
        @summary 获取文件病毒扫描结果
        
        @param request: GetVirusScanResultRequest
        @return: GetVirusScanResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetVirusScanResultHeaders()
        return self.get_virus_scan_result_with_options(request, headers, runtime)

    async def get_virus_scan_result_async(
        self,
        request: dingtalkexclusive__1__0_models.GetVirusScanResultRequest,
    ) -> dingtalkexclusive__1__0_models.GetVirusScanResultResponse:
        """
        @summary 获取文件病毒扫描结果
        
        @param request: GetVirusScanResultRequest
        @return: GetVirusScanResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GetVirusScanResultHeaders()
        return await self.get_virus_scan_result_with_options_async(request, headers, runtime)

    def group_query_by_attr_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByAttrRequest,
        headers: dingtalkexclusive__1__0_models.GroupQueryByAttrHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByAttrResponse:
        """
        @summary 根据群属性查询群ID
        
        @param request: GroupQueryByAttrRequest
        @param headers: GroupQueryByAttrHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupQueryByAttrResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.group_topic):
            body['groupTopic'] = request.group_topic
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.list_dynamic_attr):
            body['listDynamicAttr'] = request.list_dynamic_attr
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GroupQueryByAttr',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/groups/queryGroup',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GroupQueryByAttrResponse(),
            self.execute(params, req, runtime)
        )

    async def group_query_by_attr_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByAttrRequest,
        headers: dingtalkexclusive__1__0_models.GroupQueryByAttrHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByAttrResponse:
        """
        @summary 根据群属性查询群ID
        
        @param request: GroupQueryByAttrRequest
        @param headers: GroupQueryByAttrHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupQueryByAttrResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.group_topic):
            body['groupTopic'] = request.group_topic
        if not UtilClient.is_unset(request.group_type):
            body['groupType'] = request.group_type
        if not UtilClient.is_unset(request.list_dynamic_attr):
            body['listDynamicAttr'] = request.list_dynamic_attr
        if not UtilClient.is_unset(request.page_index):
            body['pageIndex'] = request.page_index
        if not UtilClient.is_unset(request.page_size):
            body['pageSize'] = request.page_size
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GroupQueryByAttr',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/groups/queryGroup',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GroupQueryByAttrResponse(),
            await self.execute_async(params, req, runtime)
        )

    def group_query_by_attr(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByAttrRequest,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByAttrResponse:
        """
        @summary 根据群属性查询群ID
        
        @param request: GroupQueryByAttrRequest
        @return: GroupQueryByAttrResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GroupQueryByAttrHeaders()
        return self.group_query_by_attr_with_options(request, headers, runtime)

    async def group_query_by_attr_async(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByAttrRequest,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByAttrResponse:
        """
        @summary 根据群属性查询群ID
        
        @param request: GroupQueryByAttrRequest
        @return: GroupQueryByAttrResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GroupQueryByAttrHeaders()
        return await self.group_query_by_attr_with_options_async(request, headers, runtime)

    def group_query_by_open_id_with_options(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByOpenIdRequest,
        headers: dingtalkexclusive__1__0_models.GroupQueryByOpenIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse:
        """
        @summary 根据群ID查询群属性
        
        @param request: GroupQueryByOpenIdRequest
        @param headers: GroupQueryByOpenIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupQueryByOpenIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GroupQueryByOpenId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/groups/getGroupByOpenConversationId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse(),
            self.execute(params, req, runtime)
        )

    async def group_query_by_open_id_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByOpenIdRequest,
        headers: dingtalkexclusive__1__0_models.GroupQueryByOpenIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse:
        """
        @summary 根据群ID查询群属性
        
        @param request: GroupQueryByOpenIdRequest
        @param headers: GroupQueryByOpenIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GroupQueryByOpenIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GroupQueryByOpenId',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/portals/groups/getGroupByOpenConversationId',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def group_query_by_open_id(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByOpenIdRequest,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse:
        """
        @summary 根据群ID查询群属性
        
        @param request: GroupQueryByOpenIdRequest
        @return: GroupQueryByOpenIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GroupQueryByOpenIdHeaders()
        return self.group_query_by_open_id_with_options(request, headers, runtime)

    async def group_query_by_open_id_async(
        self,
        request: dingtalkexclusive__1__0_models.GroupQueryByOpenIdRequest,
    ) -> dingtalkexclusive__1__0_models.GroupQueryByOpenIdResponse:
        """
        @summary 根据群ID查询群属性
        
        @param request: GroupQueryByOpenIdRequest
        @return: GroupQueryByOpenIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.GroupQueryByOpenIdHeaders()
        return await self.group_query_by_open_id_with_options_async(request, headers, runtime)

    def list_audit_log_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
        headers: dingtalkexclusive__1__0_models.ListAuditLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        """
        @summary 获取企业文件审计日志
        
        @param request: ListAuditLogRequest
        @param headers: ListAuditLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAuditLogResponse
        """
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
        """
        @summary 获取企业文件审计日志
        
        @param request: ListAuditLogRequest
        @param headers: ListAuditLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListAuditLogResponse
        """
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
        """
        @summary 获取企业文件审计日志
        
        @param request: ListAuditLogRequest
        @return: ListAuditLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListAuditLogHeaders()
        return self.list_audit_log_with_options(request, headers, runtime)

    async def list_audit_log_async(
        self,
        request: dingtalkexclusive__1__0_models.ListAuditLogRequest,
    ) -> dingtalkexclusive__1__0_models.ListAuditLogResponse:
        """
        @summary 获取企业文件审计日志
        
        @param request: ListAuditLogRequest
        @return: ListAuditLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListAuditLogHeaders()
        return await self.list_audit_log_with_options_async(request, headers, runtime)

    def list_by_codes_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListByCodesRequest,
        headers: dingtalkexclusive__1__0_models.ListByCodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListByCodesResponse:
        """
        @summary 根据机器人code列表查询机器人信息
        
        @param request: ListByCodesRequest
        @param headers: ListByCodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListByCodesResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListByCodes',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/robotInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListByCodesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_by_codes_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListByCodesRequest,
        headers: dingtalkexclusive__1__0_models.ListByCodesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListByCodesResponse:
        """
        @summary 根据机器人code列表查询机器人信息
        
        @param request: ListByCodesRequest
        @param headers: ListByCodesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListByCodesResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListByCodes',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/robotInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListByCodesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_by_codes(
        self,
        request: dingtalkexclusive__1__0_models.ListByCodesRequest,
    ) -> dingtalkexclusive__1__0_models.ListByCodesResponse:
        """
        @summary 根据机器人code列表查询机器人信息
        
        @param request: ListByCodesRequest
        @return: ListByCodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListByCodesHeaders()
        return self.list_by_codes_with_options(request, headers, runtime)

    async def list_by_codes_async(
        self,
        request: dingtalkexclusive__1__0_models.ListByCodesRequest,
    ) -> dingtalkexclusive__1__0_models.ListByCodesResponse:
        """
        @summary 根据机器人code列表查询机器人信息
        
        @param request: ListByCodesRequest
        @return: ListByCodesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListByCodesHeaders()
        return await self.list_by_codes_with_options_async(request, headers, runtime)

    def list_by_plugin_ids_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListByPluginIdsRequest,
        headers: dingtalkexclusive__1__0_models.ListByPluginIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListByPluginIdsResponse:
        """
        @summary 根据插件id列表查询插件信息
        
        @param request: ListByPluginIdsRequest
        @param headers: ListByPluginIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListByPluginIdsResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListByPluginIds',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/pluginInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListByPluginIdsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_by_plugin_ids_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.ListByPluginIdsRequest,
        headers: dingtalkexclusive__1__0_models.ListByPluginIdsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListByPluginIdsResponse:
        """
        @summary 根据插件id列表查询插件信息
        
        @param request: ListByPluginIdsRequest
        @param headers: ListByPluginIdsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListByPluginIdsResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=request.body
        )
        params = open_api_models.Params(
            action='ListByPluginIds',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/pluginInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.ListByPluginIdsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_by_plugin_ids(
        self,
        request: dingtalkexclusive__1__0_models.ListByPluginIdsRequest,
    ) -> dingtalkexclusive__1__0_models.ListByPluginIdsResponse:
        """
        @summary 根据插件id列表查询插件信息
        
        @param request: ListByPluginIdsRequest
        @return: ListByPluginIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListByPluginIdsHeaders()
        return self.list_by_plugin_ids_with_options(request, headers, runtime)

    async def list_by_plugin_ids_async(
        self,
        request: dingtalkexclusive__1__0_models.ListByPluginIdsRequest,
    ) -> dingtalkexclusive__1__0_models.ListByPluginIdsResponse:
        """
        @summary 根据插件id列表查询插件信息
        
        @param request: ListByPluginIdsRequest
        @return: ListByPluginIdsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListByPluginIdsHeaders()
        return await self.list_by_plugin_ids_with_options_async(request, headers, runtime)

    def list_categorys_with_options(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListCategorysRequest,
        headers: dingtalkexclusive__1__0_models.ListCategorysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        """
        @summary 查询分组列表
        
        @param tmp_req: ListCategorysRequest
        @param headers: ListCategorysHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCategorysResponse
        """
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
        """
        @summary 查询分组列表
        
        @param tmp_req: ListCategorysRequest
        @param headers: ListCategorysHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListCategorysResponse
        """
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
        """
        @summary 查询分组列表
        
        @param request: ListCategorysRequest
        @return: ListCategorysResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListCategorysHeaders()
        return self.list_categorys_with_options(request, headers, runtime)

    async def list_categorys_async(
        self,
        request: dingtalkexclusive__1__0_models.ListCategorysRequest,
    ) -> dingtalkexclusive__1__0_models.ListCategorysResponse:
        """
        @summary 查询分组列表
        
        @param request: ListCategorysRequest
        @return: ListCategorysResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListCategorysHeaders()
        return await self.list_categorys_with_options_async(request, headers, runtime)

    def list_join_org_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
        headers: dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        """
        @summary 通过手机号获取已加入的属于渠道组织的列表信息
        
        @param request: ListJoinOrgInfoRequest
        @param headers: ListJoinOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListJoinOrgInfoResponse
        """
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
        """
        @summary 通过手机号获取已加入的属于渠道组织的列表信息
        
        @param request: ListJoinOrgInfoRequest
        @param headers: ListJoinOrgInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListJoinOrgInfoResponse
        """
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
        """
        @summary 通过手机号获取已加入的属于渠道组织的列表信息
        
        @param request: ListJoinOrgInfoRequest
        @return: ListJoinOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders()
        return self.list_join_org_info_with_options(request, headers, runtime)

    async def list_join_org_info_async(
        self,
        request: dingtalkexclusive__1__0_models.ListJoinOrgInfoRequest,
    ) -> dingtalkexclusive__1__0_models.ListJoinOrgInfoResponse:
        """
        @summary 通过手机号获取已加入的属于渠道组织的列表信息
        
        @param request: ListJoinOrgInfoRequest
        @return: ListJoinOrgInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListJoinOrgInfoHeaders()
        return await self.list_join_org_info_with_options_async(request, headers, runtime)

    def list_mini_app_available_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListMiniAppAvailableVersionRequest
        @param headers: ListMiniAppAvailableVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMiniAppAvailableVersionResponse
        """
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
        """
        @summary 获取小程序版本列表
        
        @param request: ListMiniAppAvailableVersionRequest
        @param headers: ListMiniAppAvailableVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMiniAppAvailableVersionResponse
        """
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
        """
        @summary 获取小程序版本列表
        
        @param request: ListMiniAppAvailableVersionRequest
        @return: ListMiniAppAvailableVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders()
        return self.list_mini_app_available_version_with_options(request, headers, runtime)

    async def list_mini_app_available_version_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionResponse:
        """
        @summary 获取小程序版本列表
        
        @param request: ListMiniAppAvailableVersionRequest
        @return: ListMiniAppAvailableVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppAvailableVersionHeaders()
        return await self.list_mini_app_available_version_with_options_async(request, headers, runtime)

    def list_mini_app_history_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
        headers: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        """
        @summary 获取小程序历史版本列表
        
        @param request: ListMiniAppHistoryVersionRequest
        @param headers: ListMiniAppHistoryVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMiniAppHistoryVersionResponse
        """
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
        """
        @summary 获取小程序历史版本列表
        
        @param request: ListMiniAppHistoryVersionRequest
        @param headers: ListMiniAppHistoryVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListMiniAppHistoryVersionResponse
        """
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
        """
        @summary 获取小程序历史版本列表
        
        @param request: ListMiniAppHistoryVersionRequest
        @return: ListMiniAppHistoryVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders()
        return self.list_mini_app_history_version_with_options(request, headers, runtime)

    async def list_mini_app_history_version_async(
        self,
        request: dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionRequest,
    ) -> dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionResponse:
        """
        @summary 获取小程序历史版本列表
        
        @param request: ListMiniAppHistoryVersionRequest
        @return: ListMiniAppHistoryVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListMiniAppHistoryVersionHeaders()
        return await self.list_mini_app_history_version_with_options_async(request, headers, runtime)

    def list_partner_roles_with_options(
        self,
        parent_id: str,
        headers: dingtalkexclusive__1__0_models.ListPartnerRolesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        """
        @summary 查询伙伴角色
        
        @param headers: ListPartnerRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPartnerRolesResponse
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
        """
        @summary 查询伙伴角色
        
        @param headers: ListPartnerRolesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPartnerRolesResponse
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
        """
        @summary 查询伙伴角色
        
        @return: ListPartnerRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPartnerRolesHeaders()
        return self.list_partner_roles_with_options(parent_id, headers, runtime)

    async def list_partner_roles_async(
        self,
        parent_id: str,
    ) -> dingtalkexclusive__1__0_models.ListPartnerRolesResponse:
        """
        @summary 查询伙伴角色
        
        @return: ListPartnerRolesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPartnerRolesHeaders()
        return await self.list_partner_roles_with_options_async(parent_id, headers, runtime)

    def list_punch_schedule_by_condition_with_paging_with_options(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
        headers: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        """
        @summary 获取巡点信息列表
        
        @param request: ListPunchScheduleByConditionWithPagingRequest
        @param headers: ListPunchScheduleByConditionWithPagingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPunchScheduleByConditionWithPagingResponse
        """
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
        """
        @summary 获取巡点信息列表
        
        @param request: ListPunchScheduleByConditionWithPagingRequest
        @param headers: ListPunchScheduleByConditionWithPagingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPunchScheduleByConditionWithPagingResponse
        """
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
        """
        @summary 获取巡点信息列表
        
        @param request: ListPunchScheduleByConditionWithPagingRequest
        @return: ListPunchScheduleByConditionWithPagingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders()
        return self.list_punch_schedule_by_condition_with_paging_with_options(request, headers, runtime)

    async def list_punch_schedule_by_condition_with_paging_async(
        self,
        request: dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingRequest,
    ) -> dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingResponse:
        """
        @summary 获取巡点信息列表
        
        @param request: ListPunchScheduleByConditionWithPagingRequest
        @return: ListPunchScheduleByConditionWithPagingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListPunchScheduleByConditionWithPagingHeaders()
        return await self.list_punch_schedule_by_condition_with_paging_with_options_async(request, headers, runtime)

    def list_rules_with_options(
        self,
        tmp_req: dingtalkexclusive__1__0_models.ListRulesRequest,
        headers: dingtalkexclusive__1__0_models.ListRulesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        """
        @summary 查询规则列表
        
        @param tmp_req: ListRulesRequest
        @param headers: ListRulesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRulesResponse
        """
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
        """
        @summary 查询规则列表
        
        @param tmp_req: ListRulesRequest
        @param headers: ListRulesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRulesResponse
        """
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
        """
        @summary 查询规则列表
        
        @param request: ListRulesRequest
        @return: ListRulesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListRulesHeaders()
        return self.list_rules_with_options(request, headers, runtime)

    async def list_rules_async(
        self,
        request: dingtalkexclusive__1__0_models.ListRulesRequest,
    ) -> dingtalkexclusive__1__0_models.ListRulesResponse:
        """
        @summary 查询规则列表
        
        @param request: ListRulesRequest
        @return: ListRulesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.ListRulesHeaders()
        return await self.list_rules_with_options_async(request, headers, runtime)

    def logout_with_options(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
        headers: dingtalkexclusive__1__0_models.LogoutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        """
        @summary 指定用户强制下线
        
        @param request: LogoutRequest
        @param headers: LogoutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LogoutResponse
        """
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
        """
        @summary 指定用户强制下线
        
        @param request: LogoutRequest
        @param headers: LogoutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: LogoutResponse
        """
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
        """
        @summary 指定用户强制下线
        
        @param request: LogoutRequest
        @return: LogoutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.LogoutHeaders()
        return self.logout_with_options(request, headers, runtime)

    async def logout_async(
        self,
        request: dingtalkexclusive__1__0_models.LogoutRequest,
    ) -> dingtalkexclusive__1__0_models.LogoutResponse:
        """
        @summary 指定用户强制下线
        
        @param request: LogoutRequest
        @return: LogoutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.LogoutHeaders()
        return await self.logout_with_options_async(request, headers, runtime)

    def open_benefit_package_with_options(
        self,
        request: dingtalkexclusive__1__0_models.OpenBenefitPackageRequest,
        headers: dingtalkexclusive__1__0_models.OpenBenefitPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.OpenBenefitPackageResponse:
        """
        @summary 购买权益包
        
        @param request: OpenBenefitPackageRequest
        @param headers: OpenBenefitPackageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenBenefitPackageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_package):
            body['benefitPackage'] = request.benefit_package
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='OpenBenefitPackage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/benefitPackages/purchase',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.OpenBenefitPackageResponse(),
            self.execute(params, req, runtime)
        )

    async def open_benefit_package_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.OpenBenefitPackageRequest,
        headers: dingtalkexclusive__1__0_models.OpenBenefitPackageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.OpenBenefitPackageResponse:
        """
        @summary 购买权益包
        
        @param request: OpenBenefitPackageRequest
        @param headers: OpenBenefitPackageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenBenefitPackageResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_package):
            body['benefitPackage'] = request.benefit_package
        if not UtilClient.is_unset(request.end_date):
            body['endDate'] = request.end_date
        if not UtilClient.is_unset(request.start_date):
            body['startDate'] = request.start_date
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
            action='OpenBenefitPackage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/benefitPackages/purchase',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.OpenBenefitPackageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def open_benefit_package(
        self,
        request: dingtalkexclusive__1__0_models.OpenBenefitPackageRequest,
    ) -> dingtalkexclusive__1__0_models.OpenBenefitPackageResponse:
        """
        @summary 购买权益包
        
        @param request: OpenBenefitPackageRequest
        @return: OpenBenefitPackageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.OpenBenefitPackageHeaders()
        return self.open_benefit_package_with_options(request, headers, runtime)

    async def open_benefit_package_async(
        self,
        request: dingtalkexclusive__1__0_models.OpenBenefitPackageRequest,
    ) -> dingtalkexclusive__1__0_models.OpenBenefitPackageResponse:
        """
        @summary 购买权益包
        
        @param request: OpenBenefitPackageRequest
        @return: OpenBenefitPackageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.OpenBenefitPackageHeaders()
        return await self.open_benefit_package_with_options_async(request, headers, runtime)

    def opportunity_search_with_options(
        self,
        request: dingtalkexclusive__1__0_models.OpportunitySearchRequest,
        headers: dingtalkexclusive__1__0_models.OpportunitySearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.OpportunitySearchResponse:
        """
        @summary 商机冲突检测
        
        @param request: OpportunitySearchRequest
        @param headers: OpportunitySearchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpportunitySearchResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='OpportunitySearch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/opportunities/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.OpportunitySearchResponse(),
            self.execute(params, req, runtime)
        )

    async def opportunity_search_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.OpportunitySearchRequest,
        headers: dingtalkexclusive__1__0_models.OpportunitySearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.OpportunitySearchResponse:
        """
        @summary 商机冲突检测
        
        @param request: OpportunitySearchRequest
        @param headers: OpportunitySearchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpportunitySearchResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='OpportunitySearch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/opportunities/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.OpportunitySearchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def opportunity_search(
        self,
        request: dingtalkexclusive__1__0_models.OpportunitySearchRequest,
    ) -> dingtalkexclusive__1__0_models.OpportunitySearchResponse:
        """
        @summary 商机冲突检测
        
        @param request: OpportunitySearchRequest
        @return: OpportunitySearchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.OpportunitySearchHeaders()
        return self.opportunity_search_with_options(request, headers, runtime)

    async def opportunity_search_async(
        self,
        request: dingtalkexclusive__1__0_models.OpportunitySearchRequest,
    ) -> dingtalkexclusive__1__0_models.OpportunitySearchResponse:
        """
        @summary 商机冲突检测
        
        @param request: OpportunitySearchRequest
        @return: OpportunitySearchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.OpportunitySearchHeaders()
        return await self.opportunity_search_with_options_async(request, headers, runtime)

    def prevent_cheating_check_risk_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskRequest,
        headers: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse:
        """
        @summary 防作弊风险检测
        
        @param request: PreventCheatingCheckRiskRequest
        @param headers: PreventCheatingCheckRiskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreventCheatingCheckRiskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_ver):
            body['clientVer'] = request.client_ver
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.platform_ver):
            body['platformVer'] = request.platform_ver
        if not UtilClient.is_unset(request.sec):
            body['sec'] = request.sec
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
            action='PreventCheatingCheckRisk',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/preventCheats/risks/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse(),
            self.execute(params, req, runtime)
        )

    async def prevent_cheating_check_risk_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskRequest,
        headers: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse:
        """
        @summary 防作弊风险检测
        
        @param request: PreventCheatingCheckRiskRequest
        @param headers: PreventCheatingCheckRiskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PreventCheatingCheckRiskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_ver):
            body['clientVer'] = request.client_ver
        if not UtilClient.is_unset(request.platform):
            body['platform'] = request.platform
        if not UtilClient.is_unset(request.platform_ver):
            body['platformVer'] = request.platform_ver
        if not UtilClient.is_unset(request.sec):
            body['sec'] = request.sec
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
            action='PreventCheatingCheckRisk',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/preventCheats/risks/check',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def prevent_cheating_check_risk(
        self,
        request: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskRequest,
    ) -> dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse:
        """
        @summary 防作弊风险检测
        
        @param request: PreventCheatingCheckRiskRequest
        @return: PreventCheatingCheckRiskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PreventCheatingCheckRiskHeaders()
        return self.prevent_cheating_check_risk_with_options(request, headers, runtime)

    async def prevent_cheating_check_risk_async(
        self,
        request: dingtalkexclusive__1__0_models.PreventCheatingCheckRiskRequest,
    ) -> dingtalkexclusive__1__0_models.PreventCheatingCheckRiskResponse:
        """
        @summary 防作弊风险检测
        
        @param request: PreventCheatingCheckRiskRequest
        @return: PreventCheatingCheckRiskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PreventCheatingCheckRiskHeaders()
        return await self.prevent_cheating_check_risk_with_options_async(request, headers, runtime)

    def publish_file_change_notice_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
        headers: dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        """
        @summary 发送文件更改的评论
        
        @param request: PublishFileChangeNoticeRequest
        @param headers: PublishFileChangeNoticeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishFileChangeNoticeResponse
        """
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
        """
        @summary 发送文件更改的评论
        
        @param request: PublishFileChangeNoticeRequest
        @param headers: PublishFileChangeNoticeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishFileChangeNoticeResponse
        """
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
        """
        @summary 发送文件更改的评论
        
        @param request: PublishFileChangeNoticeRequest
        @return: PublishFileChangeNoticeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders()
        return self.publish_file_change_notice_with_options(request, headers, runtime)

    async def publish_file_change_notice_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishFileChangeNoticeRequest,
    ) -> dingtalkexclusive__1__0_models.PublishFileChangeNoticeResponse:
        """
        @summary 发送文件更改的评论
        
        @param request: PublishFileChangeNoticeRequest
        @return: PublishFileChangeNoticeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishFileChangeNoticeHeaders()
        return await self.publish_file_change_notice_with_options_async(request, headers, runtime)

    def publish_rule_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
        headers: dingtalkexclusive__1__0_models.PublishRuleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        """
        @summary 发布规则
        
        @param request: PublishRuleRequest
        @param headers: PublishRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishRuleResponse
        """
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
        """
        @summary 发布规则
        
        @param request: PublishRuleRequest
        @param headers: PublishRuleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PublishRuleResponse
        """
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
        """
        @summary 发布规则
        
        @param request: PublishRuleRequest
        @return: PublishRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishRuleHeaders()
        return self.publish_rule_with_options(request, headers, runtime)

    async def publish_rule_async(
        self,
        request: dingtalkexclusive__1__0_models.PublishRuleRequest,
    ) -> dingtalkexclusive__1__0_models.PublishRuleResponse:
        """
        @summary 发布规则
        
        @param request: PublishRuleRequest
        @return: PublishRuleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PublishRuleHeaders()
        return await self.publish_rule_with_options_async(request, headers, runtime)

    def push_badge_with_options(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
        headers: dingtalkexclusive__1__0_models.PushBadgeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        """
        @summary 推送专属设计中自建/第三方应用的小红点
        
        @param request: PushBadgeRequest
        @param headers: PushBadgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushBadgeResponse
        """
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
        """
        @summary 推送专属设计中自建/第三方应用的小红点
        
        @param request: PushBadgeRequest
        @param headers: PushBadgeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushBadgeResponse
        """
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
        """
        @summary 推送专属设计中自建/第三方应用的小红点
        
        @param request: PushBadgeRequest
        @return: PushBadgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PushBadgeHeaders()
        return self.push_badge_with_options(request, headers, runtime)

    async def push_badge_async(
        self,
        request: dingtalkexclusive__1__0_models.PushBadgeRequest,
    ) -> dingtalkexclusive__1__0_models.PushBadgeResponse:
        """
        @summary 推送专属设计中自建/第三方应用的小红点
        
        @param request: PushBadgeRequest
        @return: PushBadgeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.PushBadgeHeaders()
        return await self.push_badge_with_options_async(request, headers, runtime)

    def query_across_cloud_stroage_configs_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        """
        @summary 查询跨云存储配置
        
        @param request: QueryAcrossCloudStroageConfigsRequest
        @param headers: QueryAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAcrossCloudStroageConfigsResponse
        """
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
        """
        @summary 查询跨云存储配置
        
        @param request: QueryAcrossCloudStroageConfigsRequest
        @param headers: QueryAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryAcrossCloudStroageConfigsResponse
        """
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
        """
        @summary 查询跨云存储配置
        
        @param request: QueryAcrossCloudStroageConfigsRequest
        @return: QueryAcrossCloudStroageConfigsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders()
        return self.query_across_cloud_stroage_configs_with_options(request, headers, runtime)

    async def query_across_cloud_stroage_configs_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsResponse:
        """
        @summary 查询跨云存储配置
        
        @param request: QueryAcrossCloudStroageConfigsRequest
        @return: QueryAcrossCloudStroageConfigsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryAcrossCloudStroageConfigsHeaders()
        return await self.query_across_cloud_stroage_configs_with_options_async(request, headers, runtime)

    def query_channel_staff_info_by_mobile_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileRequest,
        headers: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse:
        """
        @summary 根据手机号查询渠道组织中的员工信息
        
        @param request: QueryChannelStaffInfoByMobileRequest
        @param headers: QueryChannelStaffInfoByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChannelStaffInfoByMobileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
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
            action='QueryChannelStaffInfoByMobile',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/channelOrganizations/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse(),
            self.execute(params, req, runtime)
        )

    async def query_channel_staff_info_by_mobile_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileRequest,
        headers: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse:
        """
        @summary 根据手机号查询渠道组织中的员工信息
        
        @param request: QueryChannelStaffInfoByMobileRequest
        @param headers: QueryChannelStaffInfoByMobileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryChannelStaffInfoByMobileResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.mobile):
            query['mobile'] = request.mobile
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
            action='QueryChannelStaffInfoByMobile',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/channelOrganizations/users',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_channel_staff_info_by_mobile(
        self,
        request: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileRequest,
    ) -> dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse:
        """
        @summary 根据手机号查询渠道组织中的员工信息
        
        @param request: QueryChannelStaffInfoByMobileRequest
        @return: QueryChannelStaffInfoByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileHeaders()
        return self.query_channel_staff_info_by_mobile_with_options(request, headers, runtime)

    async def query_channel_staff_info_by_mobile_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileRequest,
    ) -> dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileResponse:
        """
        @summary 根据手机号查询渠道组织中的员工信息
        
        @param request: QueryChannelStaffInfoByMobileRequest
        @return: QueryChannelStaffInfoByMobileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryChannelStaffInfoByMobileHeaders()
        return await self.query_channel_staff_info_by_mobile_with_options_async(request, headers, runtime)

    def query_conversation_page_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryConversationPageRequest,
        headers: dingtalkexclusive__1__0_models.QueryConversationPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryConversationPageResponse:
        """
        @summary 获取分组下会话列表
        
        @param request: QueryConversationPageRequest
        @param headers: QueryConversationPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConversationPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category_id):
            query['categoryId'] = request.category_id
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
            action='QueryConversationPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/categories/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryConversationPageResponse(),
            self.execute(params, req, runtime)
        )

    async def query_conversation_page_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryConversationPageRequest,
        headers: dingtalkexclusive__1__0_models.QueryConversationPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryConversationPageResponse:
        """
        @summary 获取分组下会话列表
        
        @param request: QueryConversationPageRequest
        @param headers: QueryConversationPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryConversationPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.category_id):
            query['categoryId'] = request.category_id
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
            action='QueryConversationPage',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/categories/conversations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryConversationPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_conversation_page(
        self,
        request: dingtalkexclusive__1__0_models.QueryConversationPageRequest,
    ) -> dingtalkexclusive__1__0_models.QueryConversationPageResponse:
        """
        @summary 获取分组下会话列表
        
        @param request: QueryConversationPageRequest
        @return: QueryConversationPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryConversationPageHeaders()
        return self.query_conversation_page_with_options(request, headers, runtime)

    async def query_conversation_page_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryConversationPageRequest,
    ) -> dingtalkexclusive__1__0_models.QueryConversationPageResponse:
        """
        @summary 获取分组下会话列表
        
        @param request: QueryConversationPageRequest
        @return: QueryConversationPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryConversationPageHeaders()
        return await self.query_conversation_page_with_options_async(request, headers, runtime)

    def query_exclusive_benefits_with_options(
        self,
        headers: dingtalkexclusive__1__0_models.QueryExclusiveBenefitsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse:
        """
        @summary 查询专属版权益
        
        @param headers: QueryExclusiveBenefitsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryExclusiveBenefitsResponse
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
            action='QueryExclusiveBenefits',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/benefits',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse(),
            self.execute(params, req, runtime)
        )

    async def query_exclusive_benefits_with_options_async(
        self,
        headers: dingtalkexclusive__1__0_models.QueryExclusiveBenefitsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse:
        """
        @summary 查询专属版权益
        
        @param headers: QueryExclusiveBenefitsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryExclusiveBenefitsResponse
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
            action='QueryExclusiveBenefits',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/benefits',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_exclusive_benefits(self) -> dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse:
        """
        @summary 查询专属版权益
        
        @return: QueryExclusiveBenefitsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryExclusiveBenefitsHeaders()
        return self.query_exclusive_benefits_with_options(headers, runtime)

    async def query_exclusive_benefits_async(self) -> dingtalkexclusive__1__0_models.QueryExclusiveBenefitsResponse:
        """
        @summary 查询专属版权益
        
        @return: QueryExclusiveBenefitsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryExclusiveBenefitsHeaders()
        return await self.query_exclusive_benefits_with_options_async(headers, runtime)

    def query_partner_info_with_options(
        self,
        user_id: str,
        headers: dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        """
        @summary 伙伴钉根据uid查询人员的标签信息
        
        @param headers: QueryPartnerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPartnerInfoResponse
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
        """
        @summary 伙伴钉根据uid查询人员的标签信息
        
        @param headers: QueryPartnerInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryPartnerInfoResponse
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
        """
        @summary 伙伴钉根据uid查询人员的标签信息
        
        @return: QueryPartnerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders()
        return self.query_partner_info_with_options(user_id, headers, runtime)

    async def query_partner_info_async(
        self,
        user_id: str,
    ) -> dingtalkexclusive__1__0_models.QueryPartnerInfoResponse:
        """
        @summary 伙伴钉根据uid查询人员的标签信息
        
        @return: QueryPartnerInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryPartnerInfoHeaders()
        return await self.query_partner_info_with_options_async(user_id, headers, runtime)

    def query_template_info_with_options(
        self,
        template_id: str,
        headers: dingtalkexclusive__1__0_models.QueryTemplateInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryTemplateInfoResponse:
        """
        @summary 根据templateId查询模版信息
        
        @param headers: QueryTemplateInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTemplateInfoResponse
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
            action='QueryTemplateInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/templates/{template_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryTemplateInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def query_template_info_with_options_async(
        self,
        template_id: str,
        headers: dingtalkexclusive__1__0_models.QueryTemplateInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryTemplateInfoResponse:
        """
        @summary 根据templateId查询模版信息
        
        @param headers: QueryTemplateInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTemplateInfoResponse
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
            action='QueryTemplateInfo',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/sceneGroups/templates/{template_id}/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.QueryTemplateInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_template_info(
        self,
        template_id: str,
    ) -> dingtalkexclusive__1__0_models.QueryTemplateInfoResponse:
        """
        @summary 根据templateId查询模版信息
        
        @return: QueryTemplateInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryTemplateInfoHeaders()
        return self.query_template_info_with_options(template_id, headers, runtime)

    async def query_template_info_async(
        self,
        template_id: str,
    ) -> dingtalkexclusive__1__0_models.QueryTemplateInfoResponse:
        """
        @summary 根据templateId查询模版信息
        
        @return: QueryTemplateInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryTemplateInfoHeaders()
        return await self.query_template_info_with_options_async(template_id, headers, runtime)

    def query_user_behavior_with_options(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
        headers: dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        """
        @summary 获取用户截屏操作记录
        
        @param request: QueryUserBehaviorRequest
        @param headers: QueryUserBehaviorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserBehaviorResponse
        """
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
        """
        @summary 获取用户截屏操作记录
        
        @param request: QueryUserBehaviorRequest
        @param headers: QueryUserBehaviorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserBehaviorResponse
        """
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
        """
        @summary 获取用户截屏操作记录
        
        @param request: QueryUserBehaviorRequest
        @return: QueryUserBehaviorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders()
        return self.query_user_behavior_with_options(request, headers, runtime)

    async def query_user_behavior_async(
        self,
        request: dingtalkexclusive__1__0_models.QueryUserBehaviorRequest,
    ) -> dingtalkexclusive__1__0_models.QueryUserBehaviorResponse:
        """
        @summary 获取用户截屏操作记录
        
        @param request: QueryUserBehaviorRequest
        @return: QueryUserBehaviorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.QueryUserBehaviorHeaders()
        return await self.query_user_behavior_with_options_async(request, headers, runtime)

    def rollback_mini_app_version_with_options(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
        headers: dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        """
        @summary 小程序版本回滚
        
        @param request: RollbackMiniAppVersionRequest
        @param headers: RollbackMiniAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackMiniAppVersionResponse
        """
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
        """
        @summary 小程序版本回滚
        
        @param request: RollbackMiniAppVersionRequest
        @param headers: RollbackMiniAppVersionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RollbackMiniAppVersionResponse
        """
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
        """
        @summary 小程序版本回滚
        
        @param request: RollbackMiniAppVersionRequest
        @return: RollbackMiniAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders()
        return self.rollback_mini_app_version_with_options(request, headers, runtime)

    async def rollback_mini_app_version_async(
        self,
        request: dingtalkexclusive__1__0_models.RollbackMiniAppVersionRequest,
    ) -> dingtalkexclusive__1__0_models.RollbackMiniAppVersionResponse:
        """
        @summary 小程序版本回滚
        
        @param request: RollbackMiniAppVersionRequest
        @return: RollbackMiniAppVersionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RollbackMiniAppVersionHeaders()
        return await self.rollback_mini_app_version_with_options_async(request, headers, runtime)

    def rule_batch_receiver_with_options(
        self,
        request: dingtalkexclusive__1__0_models.RuleBatchReceiverRequest,
        headers: dingtalkexclusive__1__0_models.RuleBatchReceiverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.RuleBatchReceiverResponse:
        """
        @summary 按规则批量发消息
        
        @param request: RuleBatchReceiverRequest
        @param headers: RuleBatchReceiverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RuleBatchReceiverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.batch_no):
            body['batchNo'] = request.batch_no
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.special_strategy):
            body['specialStrategy'] = request.special_strategy
        if not UtilClient.is_unset(request.task_batch_no):
            body['taskBatchNo'] = request.task_batch_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RuleBatchReceiver',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dmc/rules/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.RuleBatchReceiverResponse(),
            self.execute(params, req, runtime)
        )

    async def rule_batch_receiver_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.RuleBatchReceiverRequest,
        headers: dingtalkexclusive__1__0_models.RuleBatchReceiverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.RuleBatchReceiverResponse:
        """
        @summary 按规则批量发消息
        
        @param request: RuleBatchReceiverRequest
        @param headers: RuleBatchReceiverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RuleBatchReceiverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.batch_no):
            body['batchNo'] = request.batch_no
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.special_strategy):
            body['specialStrategy'] = request.special_strategy
        if not UtilClient.is_unset(request.task_batch_no):
            body['taskBatchNo'] = request.task_batch_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RuleBatchReceiver',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dmc/rules/messages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.RuleBatchReceiverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rule_batch_receiver(
        self,
        request: dingtalkexclusive__1__0_models.RuleBatchReceiverRequest,
    ) -> dingtalkexclusive__1__0_models.RuleBatchReceiverResponse:
        """
        @summary 按规则批量发消息
        
        @param request: RuleBatchReceiverRequest
        @return: RuleBatchReceiverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RuleBatchReceiverHeaders()
        return self.rule_batch_receiver_with_options(request, headers, runtime)

    async def rule_batch_receiver_async(
        self,
        request: dingtalkexclusive__1__0_models.RuleBatchReceiverRequest,
    ) -> dingtalkexclusive__1__0_models.RuleBatchReceiverResponse:
        """
        @summary 按规则批量发消息
        
        @param request: RuleBatchReceiverRequest
        @return: RuleBatchReceiverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.RuleBatchReceiverHeaders()
        return await self.rule_batch_receiver_with_options_async(request, headers, runtime)

    def save_across_cloud_stroage_configs_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
        headers: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        """
        @summary 新增跨云存储配置
        
        @param request: SaveAcrossCloudStroageConfigsRequest
        @param headers: SaveAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveAcrossCloudStroageConfigsResponse
        """
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
        """
        @summary 新增跨云存储配置
        
        @param request: SaveAcrossCloudStroageConfigsRequest
        @param headers: SaveAcrossCloudStroageConfigsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveAcrossCloudStroageConfigsResponse
        """
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
        """
        @summary 新增跨云存储配置
        
        @param request: SaveAcrossCloudStroageConfigsRequest
        @return: SaveAcrossCloudStroageConfigsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders()
        return self.save_across_cloud_stroage_configs_with_options(request, headers, runtime)

    async def save_across_cloud_stroage_configs_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsResponse:
        """
        @summary 新增跨云存储配置
        
        @param request: SaveAcrossCloudStroageConfigsRequest
        @return: SaveAcrossCloudStroageConfigsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAcrossCloudStroageConfigsHeaders()
        return await self.save_across_cloud_stroage_configs_with_options_async(request, headers, runtime)

    def save_and_submit_auth_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        """
        @summary 保存并提交认证信息
        
        @param request: SaveAndSubmitAuthInfoRequest
        @param headers: SaveAndSubmitAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveAndSubmitAuthInfoResponse
        """
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
        """
        @summary 保存并提交认证信息
        
        @param request: SaveAndSubmitAuthInfoRequest
        @param headers: SaveAndSubmitAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveAndSubmitAuthInfoResponse
        """
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
        """
        @summary 保存并提交认证信息
        
        @param request: SaveAndSubmitAuthInfoRequest
        @return: SaveAndSubmitAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders()
        return self.save_and_submit_auth_info_with_options(request, headers, runtime)

    async def save_and_submit_auth_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoResponse:
        """
        @summary 保存并提交认证信息
        
        @param request: SaveAndSubmitAuthInfoRequest
        @return: SaveAndSubmitAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveAndSubmitAuthInfoHeaders()
        return await self.save_and_submit_auth_info_with_options_async(request, headers, runtime)

    def save_open_terminal_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
        headers: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        """
        @summary 亿格云能力结合
        
        @param request: SaveOpenTerminalInfoRequest
        @param headers: SaveOpenTerminalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveOpenTerminalInfoResponse
        """
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
        """
        @summary 亿格云能力结合
        
        @param request: SaveOpenTerminalInfoRequest
        @param headers: SaveOpenTerminalInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveOpenTerminalInfoResponse
        """
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
        """
        @summary 亿格云能力结合
        
        @param request: SaveOpenTerminalInfoRequest
        @return: SaveOpenTerminalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders()
        return self.save_open_terminal_info_with_options(request, headers, runtime)

    async def save_open_terminal_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveOpenTerminalInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SaveOpenTerminalInfoResponse:
        """
        @summary 亿格云能力结合
        
        @param request: SaveOpenTerminalInfoRequest
        @return: SaveOpenTerminalInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveOpenTerminalInfoHeaders()
        return await self.save_open_terminal_info_with_options_async(request, headers, runtime)

    def save_storage_function_switch_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchRequest,
        headers: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse:
        """
        @summary 保存专属文件存储的功能项
        
        @param request: SaveStorageFunctionSwitchRequest
        @param headers: SaveStorageFunctionSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStorageFunctionSwitchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.function_list):
            body['functionList'] = request.function_list
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
            action='SaveStorageFunctionSwitch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/storages/functions/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse(),
            self.execute(params, req, runtime)
        )

    async def save_storage_function_switch_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchRequest,
        headers: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse:
        """
        @summary 保存专属文件存储的功能项
        
        @param request: SaveStorageFunctionSwitchRequest
        @param headers: SaveStorageFunctionSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStorageFunctionSwitchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.function_list):
            body['functionList'] = request.function_list
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
            action='SaveStorageFunctionSwitch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/storages/functions/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_storage_function_switch(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchRequest,
    ) -> dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse:
        """
        @summary 保存专属文件存储的功能项
        
        @param request: SaveStorageFunctionSwitchRequest
        @return: SaveStorageFunctionSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchHeaders()
        return self.save_storage_function_switch_with_options(request, headers, runtime)

    async def save_storage_function_switch_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchRequest,
    ) -> dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchResponse:
        """
        @summary 保存专属文件存储的功能项
        
        @param request: SaveStorageFunctionSwitchRequest
        @return: SaveStorageFunctionSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveStorageFunctionSwitchHeaders()
        return await self.save_storage_function_switch_with_options_async(request, headers, runtime)

    def save_storage_switch_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageSwitchRequest,
        headers: dingtalkexclusive__1__0_models.SaveStorageSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveStorageSwitchResponse:
        """
        @summary 保存专属文件存储整体开关
        
        @param request: SaveStorageSwitchRequest
        @param headers: SaveStorageSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStorageSwitchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_storage):
            body['openStorage'] = request.open_storage
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
            action='SaveStorageSwitch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/storages/switches/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveStorageSwitchResponse(),
            self.execute(params, req, runtime)
        )

    async def save_storage_switch_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageSwitchRequest,
        headers: dingtalkexclusive__1__0_models.SaveStorageSwitchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveStorageSwitchResponse:
        """
        @summary 保存专属文件存储整体开关
        
        @param request: SaveStorageSwitchRequest
        @param headers: SaveStorageSwitchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveStorageSwitchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_storage):
            body['openStorage'] = request.open_storage
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
            action='SaveStorageSwitch',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/storages/switches/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SaveStorageSwitchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_storage_switch(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageSwitchRequest,
    ) -> dingtalkexclusive__1__0_models.SaveStorageSwitchResponse:
        """
        @summary 保存专属文件存储整体开关
        
        @param request: SaveStorageSwitchRequest
        @return: SaveStorageSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveStorageSwitchHeaders()
        return self.save_storage_switch_with_options(request, headers, runtime)

    async def save_storage_switch_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveStorageSwitchRequest,
    ) -> dingtalkexclusive__1__0_models.SaveStorageSwitchResponse:
        """
        @summary 保存专属文件存储整体开关
        
        @param request: SaveStorageSwitchRequest
        @return: SaveStorageSwitchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveStorageSwitchHeaders()
        return await self.save_storage_switch_with_options_async(request, headers, runtime)

    def save_white_app_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
        headers: dingtalkexclusive__1__0_models.SaveWhiteAppHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        """
        @summary 用于提供mdm微应用白名单配置能力
        
        @param request: SaveWhiteAppRequest
        @param headers: SaveWhiteAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveWhiteAppResponse
        """
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
        """
        @summary 用于提供mdm微应用白名单配置能力
        
        @param request: SaveWhiteAppRequest
        @param headers: SaveWhiteAppHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveWhiteAppResponse
        """
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
        """
        @summary 用于提供mdm微应用白名单配置能力
        
        @param request: SaveWhiteAppRequest
        @return: SaveWhiteAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveWhiteAppHeaders()
        return self.save_white_app_with_options(request, headers, runtime)

    async def save_white_app_async(
        self,
        request: dingtalkexclusive__1__0_models.SaveWhiteAppRequest,
    ) -> dingtalkexclusive__1__0_models.SaveWhiteAppResponse:
        """
        @summary 用于提供mdm微应用白名单配置能力
        
        @param request: SaveWhiteAppRequest
        @return: SaveWhiteAppResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SaveWhiteAppHeaders()
        return await self.save_white_app_with_options_async(request, headers, runtime)

    def search_org_inner_group_info_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
        headers: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        """
        @summary 查询企业内部群信息
        
        @param request: SearchOrgInnerGroupInfoRequest
        @param headers: SearchOrgInnerGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchOrgInnerGroupInfoResponse
        """
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
        """
        @summary 查询企业内部群信息
        
        @param request: SearchOrgInnerGroupInfoRequest
        @param headers: SearchOrgInnerGroupInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchOrgInnerGroupInfoResponse
        """
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
        """
        @summary 查询企业内部群信息
        
        @param request: SearchOrgInnerGroupInfoRequest
        @return: SearchOrgInnerGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return self.search_org_inner_group_info_with_options(request, headers, runtime)

    async def search_org_inner_group_info_async(
        self,
        request: dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoRequest,
    ) -> dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoResponse:
        """
        @summary 查询企业内部群信息
        
        @param request: SearchOrgInnerGroupInfoRequest
        @return: SearchOrgInnerGroupInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SearchOrgInnerGroupInfoHeaders()
        return await self.search_org_inner_group_info_with_options_async(request, headers, runtime)

    def send_app_ding_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
        headers: dingtalkexclusive__1__0_models.SendAppDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        """
        @summary 通过接口发送应用内DING
        
        @param request: SendAppDingRequest
        @param headers: SendAppDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAppDingResponse
        """
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
        """
        @summary 通过接口发送应用内DING
        
        @param request: SendAppDingRequest
        @param headers: SendAppDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendAppDingResponse
        """
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
        """
        @summary 通过接口发送应用内DING
        
        @param request: SendAppDingRequest
        @return: SendAppDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendAppDingHeaders()
        return self.send_app_ding_with_options(request, headers, runtime)

    async def send_app_ding_async(
        self,
        request: dingtalkexclusive__1__0_models.SendAppDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendAppDingResponse:
        """
        @summary 通过接口发送应用内DING
        
        @param request: SendAppDingRequest
        @return: SendAppDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendAppDingHeaders()
        return await self.send_app_ding_with_options_async(request, headers, runtime)

    def send_invitation_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
        headers: dingtalkexclusive__1__0_models.SendInvitationHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        """
        @summary 发送邀请函
        
        @param request: SendInvitationRequest
        @param headers: SendInvitationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInvitationResponse
        """
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
        """
        @summary 发送邀请函
        
        @param request: SendInvitationRequest
        @param headers: SendInvitationHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendInvitationResponse
        """
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
        """
        @summary 发送邀请函
        
        @param request: SendInvitationRequest
        @return: SendInvitationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendInvitationHeaders()
        return self.send_invitation_with_options(request, headers, runtime)

    async def send_invitation_async(
        self,
        request: dingtalkexclusive__1__0_models.SendInvitationRequest,
    ) -> dingtalkexclusive__1__0_models.SendInvitationResponse:
        """
        @summary 发送邀请函
        
        @param request: SendInvitationRequest
        @return: SendInvitationResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendInvitationHeaders()
        return await self.send_invitation_with_options_async(request, headers, runtime)

    def send_phone_ding_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
        headers: dingtalkexclusive__1__0_models.SendPhoneDingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        """
        @summary 通过接口发送电话DING
        
        @param request: SendPhoneDingRequest
        @param headers: SendPhoneDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendPhoneDingResponse
        """
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
        """
        @summary 通过接口发送电话DING
        
        @param request: SendPhoneDingRequest
        @param headers: SendPhoneDingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SendPhoneDingResponse
        """
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
        """
        @summary 通过接口发送电话DING
        
        @param request: SendPhoneDingRequest
        @return: SendPhoneDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendPhoneDingHeaders()
        return self.send_phone_ding_with_options(request, headers, runtime)

    async def send_phone_ding_async(
        self,
        request: dingtalkexclusive__1__0_models.SendPhoneDingRequest,
    ) -> dingtalkexclusive__1__0_models.SendPhoneDingResponse:
        """
        @summary 通过接口发送电话DING
        
        @param request: SendPhoneDingRequest
        @return: SendPhoneDingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SendPhoneDingHeaders()
        return await self.send_phone_ding_with_options_async(request, headers, runtime)

    def set_conversation_category_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetConversationCategoryResponse:
        """
        @summary 设置会话所属分组
        
        @param request: SetConversationCategoryRequest
        @param headers: SetConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetConversationCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_id):
            body['categoryId'] = request.category_id
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
            action='SetConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationCategories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetConversationCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def set_conversation_category_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetConversationCategoryResponse:
        """
        @summary 设置会话所属分组
        
        @param request: SetConversationCategoryRequest
        @param headers: SetConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetConversationCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_id):
            body['categoryId'] = request.category_id
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
            action='SetConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationCategories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetConversationCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_conversation_category(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetConversationCategoryResponse:
        """
        @summary 设置会话所属分组
        
        @param request: SetConversationCategoryRequest
        @return: SetConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetConversationCategoryHeaders()
        return self.set_conversation_category_with_options(request, headers, runtime)

    async def set_conversation_category_async(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetConversationCategoryResponse:
        """
        @summary 设置会话所属分组
        
        @param request: SetConversationCategoryRequest
        @return: SetConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetConversationCategoryHeaders()
        return await self.set_conversation_category_with_options_async(request, headers, runtime)

    def set_conversation_top_category_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationTopCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetConversationTopCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse:
        """
        @summary 设置会话所属顶部分组
        
        @param request: SetConversationTopCategoryRequest
        @param headers: SetConversationTopCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetConversationTopCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.set_category_list):
            body['setCategoryList'] = request.set_category_list
        if not UtilClient.is_unset(request.sign):
            body['sign'] = request.sign
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetConversationTopCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversations/topCategories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def set_conversation_top_category_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationTopCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetConversationTopCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse:
        """
        @summary 设置会话所属顶部分组
        
        @param request: SetConversationTopCategoryRequest
        @param headers: SetConversationTopCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetConversationTopCategoryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open_conversation_id):
            body['openConversationId'] = request.open_conversation_id
        if not UtilClient.is_unset(request.set_category_list):
            body['setCategoryList'] = request.set_category_list
        if not UtilClient.is_unset(request.sign):
            body['sign'] = request.sign
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SetConversationTopCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversations/topCategories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_conversation_top_category(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationTopCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse:
        """
        @summary 设置会话所属顶部分组
        
        @param request: SetConversationTopCategoryRequest
        @return: SetConversationTopCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetConversationTopCategoryHeaders()
        return self.set_conversation_top_category_with_options(request, headers, runtime)

    async def set_conversation_top_category_async(
        self,
        request: dingtalkexclusive__1__0_models.SetConversationTopCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetConversationTopCategoryResponse:
        """
        @summary 设置会话所属顶部分组
        
        @param request: SetConversationTopCategoryRequest
        @return: SetConversationTopCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetConversationTopCategoryHeaders()
        return await self.set_conversation_top_category_with_options_async(request, headers, runtime)

    def set_dept_partner_type_and_num_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
        headers: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        """
        @summary 伙伴钉设置部门伙伴编码和伙伴类型
        
        @param request: SetDeptPartnerTypeAndNumRequest
        @param headers: SetDeptPartnerTypeAndNumHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDeptPartnerTypeAndNumResponse
        """
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
        """
        @summary 伙伴钉设置部门伙伴编码和伙伴类型
        
        @param request: SetDeptPartnerTypeAndNumRequest
        @param headers: SetDeptPartnerTypeAndNumHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDeptPartnerTypeAndNumResponse
        """
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
        """
        @summary 伙伴钉设置部门伙伴编码和伙伴类型
        
        @param request: SetDeptPartnerTypeAndNumRequest
        @return: SetDeptPartnerTypeAndNumResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return self.set_dept_partner_type_and_num_with_options(request, headers, runtime)

    async def set_dept_partner_type_and_num_async(
        self,
        request: dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumRequest,
    ) -> dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumResponse:
        """
        @summary 伙伴钉设置部门伙伴编码和伙伴类型
        
        @param request: SetDeptPartnerTypeAndNumRequest
        @return: SetDeptPartnerTypeAndNumResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetDeptPartnerTypeAndNumHeaders()
        return await self.set_dept_partner_type_and_num_with_options_async(request, headers, runtime)

    def set_org_top_conversation_category_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse:
        """
        @summary 设置企业全局顶部会话分组
        
        @param request: SetOrgTopConversationCategoryRequest
        @param headers: SetOrgTopConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetOrgTopConversationCategoryResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='SetOrgTopConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/topConversations/categories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse(),
            self.execute(params, req, runtime)
        )

    async def set_org_top_conversation_category_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryRequest,
        headers: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse:
        """
        @summary 设置企业全局顶部会话分组
        
        @param request: SetOrgTopConversationCategoryRequest
        @param headers: SetOrgTopConversationCategoryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetOrgTopConversationCategoryResponse
        """
        UtilClient.validate_model(request)
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=UtilClient.to_array(request.body)
        )
        params = open_api_models.Params(
            action='SetOrgTopConversationCategory',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/topConversations/categories/set',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_org_top_conversation_category(
        self,
        request: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse:
        """
        @summary 设置企业全局顶部会话分组
        
        @param request: SetOrgTopConversationCategoryRequest
        @return: SetOrgTopConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryHeaders()
        return self.set_org_top_conversation_category_with_options(request, headers, runtime)

    async def set_org_top_conversation_category_async(
        self,
        request: dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryRequest,
    ) -> dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryResponse:
        """
        @summary 设置企业全局顶部会话分组
        
        @param request: SetOrgTopConversationCategoryRequest
        @return: SetOrgTopConversationCategoryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SetOrgTopConversationCategoryHeaders()
        return await self.set_org_top_conversation_category_with_options_async(request, headers, runtime)

    def special_rule_batch_receiver_with_options(
        self,
        request: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverRequest,
        headers: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse:
        """
        @summary 千人千面按规则批量发消息
        
        @param request: SpecialRuleBatchReceiverRequest
        @param headers: SpecialRuleBatchReceiverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SpecialRuleBatchReceiverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.batch_no):
            body['batchNo'] = request.batch_no
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.special_strategy):
            body['specialStrategy'] = request.special_strategy
        if not UtilClient.is_unset(request.task_batch_no):
            body['taskBatchNo'] = request.task_batch_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SpecialRuleBatchReceiver',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dmc/rules/specialMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse(),
            self.execute(params, req, runtime)
        )

    async def special_rule_batch_receiver_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverRequest,
        headers: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse:
        """
        @summary 千人千面按规则批量发消息
        
        @param request: SpecialRuleBatchReceiverRequest
        @param headers: SpecialRuleBatchReceiverHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SpecialRuleBatchReceiverResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.batch_no):
            body['batchNo'] = request.batch_no
        if not UtilClient.is_unset(request.card_options):
            body['cardOptions'] = request.card_options
        if not UtilClient.is_unset(request.data):
            body['data'] = request.data
        if not UtilClient.is_unset(request.rule_code):
            body['ruleCode'] = request.rule_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.special_strategy):
            body['specialStrategy'] = request.special_strategy
        if not UtilClient.is_unset(request.task_batch_no):
            body['taskBatchNo'] = request.task_batch_no
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SpecialRuleBatchReceiver',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/dmc/rules/specialMessages/batchSend',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse(),
            await self.execute_async(params, req, runtime)
        )

    def special_rule_batch_receiver(
        self,
        request: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverRequest,
    ) -> dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse:
        """
        @summary 千人千面按规则批量发消息
        
        @param request: SpecialRuleBatchReceiverRequest
        @return: SpecialRuleBatchReceiverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverHeaders()
        return self.special_rule_batch_receiver_with_options(request, headers, runtime)

    async def special_rule_batch_receiver_async(
        self,
        request: dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverRequest,
    ) -> dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverResponse:
        """
        @summary 千人千面按规则批量发消息
        
        @param request: SpecialRuleBatchReceiverRequest
        @return: SpecialRuleBatchReceiverResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.SpecialRuleBatchReceiverHeaders()
        return await self.special_rule_batch_receiver_with_options_async(request, headers, runtime)

    def task_info_add_del_task_person_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse:
        """
        @summary 增加/删除任务人员
        
        @param request: TaskInfoAddDelTaskPersonRequest
        @param headers: TaskInfoAddDelTaskPersonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoAddDelTaskPersonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoAddDelTaskPerson',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse(),
            self.execute(params, req, runtime)
        )

    async def task_info_add_del_task_person_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse:
        """
        @summary 增加/删除任务人员
        
        @param request: TaskInfoAddDelTaskPersonRequest
        @param headers: TaskInfoAddDelTaskPersonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoAddDelTaskPersonResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoAddDelTaskPerson',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/addDelTaskPerson',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def task_info_add_del_task_person(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse:
        """
        @summary 增加/删除任务人员
        
        @param request: TaskInfoAddDelTaskPersonRequest
        @return: TaskInfoAddDelTaskPersonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonHeaders()
        return self.task_info_add_del_task_person_with_options(request, headers, runtime)

    async def task_info_add_del_task_person_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonResponse:
        """
        @summary 增加/删除任务人员
        
        @param request: TaskInfoAddDelTaskPersonRequest
        @return: TaskInfoAddDelTaskPersonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoAddDelTaskPersonHeaders()
        return await self.task_info_add_del_task_person_with_options_async(request, headers, runtime)

    def task_info_cancel_or_del_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse:
        """
        @summary 删除任务
        
        @param request: TaskInfoCancelOrDelTaskRequest
        @param headers: TaskInfoCancelOrDelTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoCancelOrDelTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoCancelOrDelTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def task_info_cancel_or_del_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse:
        """
        @summary 删除任务
        
        @param request: TaskInfoCancelOrDelTaskRequest
        @param headers: TaskInfoCancelOrDelTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoCancelOrDelTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoCancelOrDelTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/cancelOrDelTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def task_info_cancel_or_del_task(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse:
        """
        @summary 删除任务
        
        @param request: TaskInfoCancelOrDelTaskRequest
        @return: TaskInfoCancelOrDelTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskHeaders()
        return self.task_info_cancel_or_del_task_with_options(request, headers, runtime)

    async def task_info_cancel_or_del_task_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskResponse:
        """
        @summary 删除任务
        
        @param request: TaskInfoCancelOrDelTaskRequest
        @return: TaskInfoCancelOrDelTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoCancelOrDelTaskHeaders()
        return await self.task_info_cancel_or_del_task_with_options_async(request, headers, runtime)

    def task_info_create_and_start_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse:
        """
        @summary 创建并启动任务
        
        @param request: TaskInfoCreateAndStartTaskRequest
        @param headers: TaskInfoCreateAndStartTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoCreateAndStartTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.backlog_dto):
            body['backlogDTO'] = request.backlog_dto
        if not UtilClient.is_unset(request.backlog_generate_flag):
            body['backlogGenerateFlag'] = request.backlog_generate_flag
        if not UtilClient.is_unset(request.business_code):
            body['businessCode'] = request.business_code
        if not UtilClient.is_unset(request.canceldel_task_card_id):
            body['canceldelTaskCardId'] = request.canceldel_task_card_id
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.custom_flag):
            body['customFlag'] = request.custom_flag
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.finish_task_card_id):
            body['finishTaskCardId'] = request.finish_task_card_id
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.sort):
            body['sort'] = request.sort
        if not UtilClient.is_unset(request.start_task_card_id):
            body['startTaskCardId'] = request.start_task_card_id
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
        if not UtilClient.is_unset(request.task_content):
            body['taskContent'] = request.task_content
        if not UtilClient.is_unset(request.task_end_time):
            body['taskEndTime'] = request.task_end_time
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        if not UtilClient.is_unset(request.task_group_dtolist):
            body['taskGroupDTOList'] = request.task_group_dtolist
        if not UtilClient.is_unset(request.task_system):
            body['taskSystem'] = request.task_system
        if not UtilClient.is_unset(request.task_templ_code):
            body['taskTemplCode'] = request.task_templ_code
        if not UtilClient.is_unset(request.task_title):
            body['taskTitle'] = request.task_title
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_url_mobile):
            body['taskUrlMobile'] = request.task_url_mobile
        if not UtilClient.is_unset(request.task_url_pc):
            body['taskUrlPc'] = request.task_url_pc
        if not UtilClient.is_unset(request.update_task_card_id):
            body['updateTaskCardId'] = request.update_task_card_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoCreateAndStartTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/createAndStart',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def task_info_create_and_start_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse:
        """
        @summary 创建并启动任务
        
        @param request: TaskInfoCreateAndStartTaskRequest
        @param headers: TaskInfoCreateAndStartTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoCreateAndStartTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.backlog_dto):
            body['backlogDTO'] = request.backlog_dto
        if not UtilClient.is_unset(request.backlog_generate_flag):
            body['backlogGenerateFlag'] = request.backlog_generate_flag
        if not UtilClient.is_unset(request.business_code):
            body['businessCode'] = request.business_code
        if not UtilClient.is_unset(request.canceldel_task_card_id):
            body['canceldelTaskCardId'] = request.canceldel_task_card_id
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.custom_flag):
            body['customFlag'] = request.custom_flag
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.finish_task_card_id):
            body['finishTaskCardId'] = request.finish_task_card_id
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.robot_code):
            body['robotCode'] = request.robot_code
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.sort):
            body['sort'] = request.sort
        if not UtilClient.is_unset(request.start_task_card_id):
            body['startTaskCardId'] = request.start_task_card_id
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
        if not UtilClient.is_unset(request.task_content):
            body['taskContent'] = request.task_content
        if not UtilClient.is_unset(request.task_end_time):
            body['taskEndTime'] = request.task_end_time
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        if not UtilClient.is_unset(request.task_group_dtolist):
            body['taskGroupDTOList'] = request.task_group_dtolist
        if not UtilClient.is_unset(request.task_system):
            body['taskSystem'] = request.task_system
        if not UtilClient.is_unset(request.task_templ_code):
            body['taskTemplCode'] = request.task_templ_code
        if not UtilClient.is_unset(request.task_title):
            body['taskTitle'] = request.task_title
        if not UtilClient.is_unset(request.task_type):
            body['taskType'] = request.task_type
        if not UtilClient.is_unset(request.task_url_mobile):
            body['taskUrlMobile'] = request.task_url_mobile
        if not UtilClient.is_unset(request.task_url_pc):
            body['taskUrlPc'] = request.task_url_pc
        if not UtilClient.is_unset(request.update_task_card_id):
            body['updateTaskCardId'] = request.update_task_card_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoCreateAndStartTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/createAndStart',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def task_info_create_and_start_task(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse:
        """
        @summary 创建并启动任务
        
        @param request: TaskInfoCreateAndStartTaskRequest
        @return: TaskInfoCreateAndStartTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskHeaders()
        return self.task_info_create_and_start_task_with_options(request, headers, runtime)

    async def task_info_create_and_start_task_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskResponse:
        """
        @summary 创建并启动任务
        
        @param request: TaskInfoCreateAndStartTaskRequest
        @return: TaskInfoCreateAndStartTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoCreateAndStartTaskHeaders()
        return await self.task_info_create_and_start_task_with_options_async(request, headers, runtime)

    def task_info_finish_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoFinishTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoFinishTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse:
        """
        @summary 完成任务
        
        @param request: TaskInfoFinishTaskRequest
        @param headers: TaskInfoFinishTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoFinishTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoFinishTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/finishTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def task_info_finish_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoFinishTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoFinishTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse:
        """
        @summary 完成任务
        
        @param request: TaskInfoFinishTaskRequest
        @param headers: TaskInfoFinishTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoFinishTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoFinishTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/finishTask',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def task_info_finish_task(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoFinishTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse:
        """
        @summary 完成任务
        
        @param request: TaskInfoFinishTaskRequest
        @return: TaskInfoFinishTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoFinishTaskHeaders()
        return self.task_info_finish_task_with_options(request, headers, runtime)

    async def task_info_finish_task_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoFinishTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoFinishTaskResponse:
        """
        @summary 完成任务
        
        @param request: TaskInfoFinishTaskRequest
        @return: TaskInfoFinishTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoFinishTaskHeaders()
        return await self.task_info_finish_task_with_options_async(request, headers, runtime)

    def task_info_update_task_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse:
        """
        @summary 更新任务
        
        @param request: TaskInfoUpdateTaskRequest
        @param headers: TaskInfoUpdateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoUpdateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.canceldel_task_card_id):
            body['canceldelTaskCardId'] = request.canceldel_task_card_id
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.finish_task_card_id):
            body['finishTaskCardId'] = request.finish_task_card_id
        if not UtilClient.is_unset(request.list_open_conversation_id):
            body['listOpenConversationId'] = request.list_open_conversation_id
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.start_task_card_id):
            body['startTaskCardId'] = request.start_task_card_id
        if not UtilClient.is_unset(request.task_content):
            body['taskContent'] = request.task_content
        if not UtilClient.is_unset(request.task_end_time):
            body['taskEndTime'] = request.task_end_time
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        if not UtilClient.is_unset(request.task_title):
            body['taskTitle'] = request.task_title
        if not UtilClient.is_unset(request.task_url_mobile):
            body['taskUrlMobile'] = request.task_url_mobile
        if not UtilClient.is_unset(request.task_url_pc):
            body['taskUrlPc'] = request.task_url_pc
        if not UtilClient.is_unset(request.update_task_card_id):
            body['updateTaskCardId'] = request.update_task_card_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoUpdateTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse(),
            self.execute(params, req, runtime)
        )

    async def task_info_update_task_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskRequest,
        headers: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse:
        """
        @summary 更新任务
        
        @param request: TaskInfoUpdateTaskRequest
        @param headers: TaskInfoUpdateTaskHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TaskInfoUpdateTaskResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attr):
            body['attr'] = request.attr
        if not UtilClient.is_unset(request.canceldel_task_card_id):
            body['canceldelTaskCardId'] = request.canceldel_task_card_id
        if not UtilClient.is_unset(request.card_dto):
            body['cardDTO'] = request.card_dto
        if not UtilClient.is_unset(request.detail_url):
            body['detailUrl'] = request.detail_url
        if not UtilClient.is_unset(request.finish_task_card_id):
            body['finishTaskCardId'] = request.finish_task_card_id
        if not UtilClient.is_unset(request.list_open_conversation_id):
            body['listOpenConversationId'] = request.list_open_conversation_id
        if not UtilClient.is_unset(request.operate_type):
            body['operateType'] = request.operate_type
        if not UtilClient.is_unset(request.operator_account):
            body['operatorAccount'] = request.operator_account
        if not UtilClient.is_unset(request.out_task_id):
            body['outTaskId'] = request.out_task_id
        if not UtilClient.is_unset(request.proj_id):
            body['projId'] = request.proj_id
        if not UtilClient.is_unset(request.secret_key):
            body['secretKey'] = request.secret_key
        if not UtilClient.is_unset(request.send_msg_flag):
            body['sendMsgFlag'] = request.send_msg_flag
        if not UtilClient.is_unset(request.start_task_card_id):
            body['startTaskCardId'] = request.start_task_card_id
        if not UtilClient.is_unset(request.task_content):
            body['taskContent'] = request.task_content
        if not UtilClient.is_unset(request.task_end_time):
            body['taskEndTime'] = request.task_end_time
        if not UtilClient.is_unset(request.task_execute_person_dtos):
            body['taskExecutePersonDTOS'] = request.task_execute_person_dtos
        if not UtilClient.is_unset(request.task_title):
            body['taskTitle'] = request.task_title
        if not UtilClient.is_unset(request.task_url_mobile):
            body['taskUrlMobile'] = request.task_url_mobile
        if not UtilClient.is_unset(request.task_url_pc):
            body['taskUrlPc'] = request.task_url_pc
        if not UtilClient.is_unset(request.update_task_card_id):
            body['updateTaskCardId'] = request.update_task_card_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TaskInfoUpdateTask',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/taskCenters/taskInfos/update',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse(),
            await self.execute_async(params, req, runtime)
        )

    def task_info_update_task(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse:
        """
        @summary 更新任务
        
        @param request: TaskInfoUpdateTaskRequest
        @return: TaskInfoUpdateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoUpdateTaskHeaders()
        return self.task_info_update_task_with_options(request, headers, runtime)

    async def task_info_update_task_async(
        self,
        request: dingtalkexclusive__1__0_models.TaskInfoUpdateTaskRequest,
    ) -> dingtalkexclusive__1__0_models.TaskInfoUpdateTaskResponse:
        """
        @summary 更新任务
        
        @param request: TaskInfoUpdateTaskRequest
        @return: TaskInfoUpdateTaskResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TaskInfoUpdateTaskHeaders()
        return await self.task_info_update_task_with_options_async(request, headers, runtime)

    def transfer_exclusive_account_org_with_options(
        self,
        request: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgRequest,
        headers: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse:
        """
        @summary 切换组织归属
        
        @param request: TransferExclusiveAccountOrgRequest
        @param headers: TransferExclusiveAccountOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferExclusiveAccountOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_setting_main_org):
            body['isSettingMainOrg'] = request.is_setting_main_org
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
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
            action='TransferExclusiveAccountOrg',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/organizations/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def transfer_exclusive_account_org_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgRequest,
        headers: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse:
        """
        @summary 切换组织归属
        
        @param request: TransferExclusiveAccountOrgRequest
        @param headers: TransferExclusiveAccountOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransferExclusiveAccountOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.is_setting_main_org):
            body['isSettingMainOrg'] = request.is_setting_main_org
        if not UtilClient.is_unset(request.target_corp_id):
            body['targetCorpId'] = request.target_corp_id
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
            action='TransferExclusiveAccountOrg',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/organizations/transfer',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def transfer_exclusive_account_org(
        self,
        request: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgRequest,
    ) -> dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse:
        """
        @summary 切换组织归属
        
        @param request: TransferExclusiveAccountOrgRequest
        @return: TransferExclusiveAccountOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgHeaders()
        return self.transfer_exclusive_account_org_with_options(request, headers, runtime)

    async def transfer_exclusive_account_org_async(
        self,
        request: dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgRequest,
    ) -> dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgResponse:
        """
        @summary 切换组织归属
        
        @param request: TransferExclusiveAccountOrgRequest
        @return: TransferExclusiveAccountOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.TransferExclusiveAccountOrgHeaders()
        return await self.transfer_exclusive_account_org_with_options_async(request, headers, runtime)

    def update_category_name_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
        headers: dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        """
        @summary 更改分组名称
        
        @param request: UpdateCategoryNameRequest
        @param headers: UpdateCategoryNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCategoryNameResponse
        """
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
        """
        @summary 更改分组名称
        
        @param request: UpdateCategoryNameRequest
        @param headers: UpdateCategoryNameHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateCategoryNameResponse
        """
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
        """
        @summary 更改分组名称
        
        @param request: UpdateCategoryNameRequest
        @return: UpdateCategoryNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders()
        return self.update_category_name_with_options(request, headers, runtime)

    async def update_category_name_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateCategoryNameRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateCategoryNameResponse:
        """
        @summary 更改分组名称
        
        @param request: UpdateCategoryNameRequest
        @return: UpdateCategoryNameResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateCategoryNameHeaders()
        return await self.update_category_name_with_options_async(request, headers, runtime)

    def update_conversation_type_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateConversationTypeRequest,
        headers: dingtalkexclusive__1__0_models.UpdateConversationTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateConversationTypeResponse:
        """
        @summary 变更群聊类型
        
        @param request: UpdateConversationTypeRequest
        @param headers: UpdateConversationTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateConversationTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manage_sign):
            body['manageSign'] = request.manage_sign
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
            action='UpdateConversationType',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationTypes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateConversationTypeResponse(),
            self.execute(params, req, runtime)
        )

    async def update_conversation_type_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateConversationTypeRequest,
        headers: dingtalkexclusive__1__0_models.UpdateConversationTypeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateConversationTypeResponse:
        """
        @summary 变更群聊类型
        
        @param request: UpdateConversationTypeRequest
        @param headers: UpdateConversationTypeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateConversationTypeResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.manage_sign):
            body['manageSign'] = request.manage_sign
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
            action='UpdateConversationType',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/conversationTypes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateConversationTypeResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_conversation_type(
        self,
        request: dingtalkexclusive__1__0_models.UpdateConversationTypeRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateConversationTypeResponse:
        """
        @summary 变更群聊类型
        
        @param request: UpdateConversationTypeRequest
        @return: UpdateConversationTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateConversationTypeHeaders()
        return self.update_conversation_type_with_options(request, headers, runtime)

    async def update_conversation_type_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateConversationTypeRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateConversationTypeResponse:
        """
        @summary 变更群聊类型
        
        @param request: UpdateConversationTypeRequest
        @return: UpdateConversationTypeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateConversationTypeHeaders()
        return await self.update_conversation_type_with_options_async(request, headers, runtime)

    def update_file_status_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateFileStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        """
        @summary 更新发送文件的检测状态
        
        @param request: UpdateFileStatusRequest
        @param headers: UpdateFileStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFileStatusResponse
        """
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
        """
        @summary 更新发送文件的检测状态
        
        @param request: UpdateFileStatusRequest
        @param headers: UpdateFileStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateFileStatusResponse
        """
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
        """
        @summary 更新发送文件的检测状态
        
        @param request: UpdateFileStatusRequest
        @return: UpdateFileStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateFileStatusHeaders()
        return self.update_file_status_with_options(request, headers, runtime)

    async def update_file_status_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateFileStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateFileStatusResponse:
        """
        @summary 更新发送文件的检测状态
        
        @param request: UpdateFileStatusRequest
        @return: UpdateFileStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateFileStatusHeaders()
        return await self.update_file_status_with_options_async(request, headers, runtime)

    def update_mini_app_version_status_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateMiniAppVersionStatusRequest
        @param headers: UpdateMiniAppVersionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMiniAppVersionStatusResponse
        """
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
        """
        @summary 发布版本
        
        @param request: UpdateMiniAppVersionStatusRequest
        @param headers: UpdateMiniAppVersionStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateMiniAppVersionStatusResponse
        """
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
        """
        @summary 发布版本
        
        @param request: UpdateMiniAppVersionStatusRequest
        @return: UpdateMiniAppVersionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders()
        return self.update_mini_app_version_status_with_options(request, headers, runtime)

    async def update_mini_app_version_status_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusResponse:
        """
        @summary 发布版本
        
        @param request: UpdateMiniAppVersionStatusRequest
        @return: UpdateMiniAppVersionStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateMiniAppVersionStatusHeaders()
        return await self.update_mini_app_version_status_with_options_async(request, headers, runtime)

    def update_partner_visibility_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        """
        @summary 修改伙伴类型可见性
        
        @param request: UpdatePartnerVisibilityRequest
        @param headers: UpdatePartnerVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePartnerVisibilityResponse
        """
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
        """
        @summary 修改伙伴类型可见性
        
        @param request: UpdatePartnerVisibilityRequest
        @param headers: UpdatePartnerVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdatePartnerVisibilityResponse
        """
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
        """
        @summary 修改伙伴类型可见性
        
        @param request: UpdatePartnerVisibilityRequest
        @return: UpdatePartnerVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders()
        return self.update_partner_visibility_with_options(request, headers, runtime)

    async def update_partner_visibility_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdatePartnerVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdatePartnerVisibilityResponse:
        """
        @summary 修改伙伴类型可见性
        
        @param request: UpdatePartnerVisibilityRequest
        @return: UpdatePartnerVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdatePartnerVisibilityHeaders()
        return await self.update_partner_visibility_with_options_async(request, headers, runtime)

    def update_realm_license_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRealmLicenseRequest,
        headers: dingtalkexclusive__1__0_models.UpdateRealmLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse:
        """
        @summary 专属一线版-企业修改员工license
        
        @param request: UpdateRealmLicenseRequest
        @param headers: UpdateRealmLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRealmLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRealmLicense',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/frontLines/licenses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse(),
            self.execute(params, req, runtime)
        )

    async def update_realm_license_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRealmLicenseRequest,
        headers: dingtalkexclusive__1__0_models.UpdateRealmLicenseHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse:
        """
        @summary 专属一线版-企业修改员工license
        
        @param request: UpdateRealmLicenseRequest
        @param headers: UpdateRealmLicenseHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRealmLicenseResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.detail_list):
            body['detailList'] = request.detail_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateRealmLicense',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/frontLines/licenses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_realm_license(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRealmLicenseRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse:
        """
        @summary 专属一线版-企业修改员工license
        
        @param request: UpdateRealmLicenseRequest
        @return: UpdateRealmLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRealmLicenseHeaders()
        return self.update_realm_license_with_options(request, headers, runtime)

    async def update_realm_license_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRealmLicenseRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateRealmLicenseResponse:
        """
        @summary 专属一线版-企业修改员工license
        
        @param request: UpdateRealmLicenseRequest
        @return: UpdateRealmLicenseResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRealmLicenseHeaders()
        return await self.update_realm_license_with_options_async(request, headers, runtime)

    def update_role_visibility_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
        headers: dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        """
        @summary 修改角色可见性
        
        @param request: UpdateRoleVisibilityRequest
        @param headers: UpdateRoleVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRoleVisibilityResponse
        """
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
        """
        @summary 修改角色可见性
        
        @param request: UpdateRoleVisibilityRequest
        @param headers: UpdateRoleVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateRoleVisibilityResponse
        """
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
        """
        @summary 修改角色可见性
        
        @param request: UpdateRoleVisibilityRequest
        @return: UpdateRoleVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders()
        return self.update_role_visibility_with_options(request, headers, runtime)

    async def update_role_visibility_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateRoleVisibilityRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateRoleVisibilityResponse:
        """
        @summary 修改角色可见性
        
        @param request: UpdateRoleVisibilityRequest
        @return: UpdateRoleVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateRoleVisibilityHeaders()
        return await self.update_role_visibility_with_options_async(request, headers, runtime)

    def update_storage_mode_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
        headers: dingtalkexclusive__1__0_models.UpdateStorageModeHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        """
        @summary 更新组织专属存储模式
        
        @param request: UpdateStorageModeRequest
        @param headers: UpdateStorageModeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateStorageModeResponse
        """
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
        """
        @summary 更新组织专属存储模式
        
        @param request: UpdateStorageModeRequest
        @param headers: UpdateStorageModeHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateStorageModeResponse
        """
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
        """
        @summary 更新组织专属存储模式
        
        @param request: UpdateStorageModeRequest
        @return: UpdateStorageModeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateStorageModeHeaders()
        return self.update_storage_mode_with_options(request, headers, runtime)

    async def update_storage_mode_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateStorageModeRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateStorageModeResponse:
        """
        @summary 更新组织专属存储模式
        
        @param request: UpdateStorageModeRequest
        @return: UpdateStorageModeResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateStorageModeHeaders()
        return await self.update_storage_mode_with_options_async(request, headers, runtime)

    def update_voice_msg_ctrl_status_with_options(
        self,
        request: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse:
        """
        @summary 允许三方调用该API，决定对应的语音消息管控状态
        
        @param request: UpdateVoiceMsgCtrlStatusRequest
        @param headers: UpdateVoiceMsgCtrlStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVoiceMsgCtrlStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.voice_msg_ctrl_info):
            body['voiceMsgCtrlInfo'] = request.voice_msg_ctrl_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateVoiceMsgCtrlStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/voiceMessages/ctrlStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_voice_msg_ctrl_status_with_options_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusRequest,
        headers: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse:
        """
        @summary 允许三方调用该API，决定对应的语音消息管控状态
        
        @param request: UpdateVoiceMsgCtrlStatusRequest
        @param headers: UpdateVoiceMsgCtrlStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateVoiceMsgCtrlStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.status):
            body['status'] = request.status
        if not UtilClient.is_unset(request.voice_msg_ctrl_info):
            body['voiceMsgCtrlInfo'] = request.voice_msg_ctrl_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateVoiceMsgCtrlStatus',
            version='exclusive_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/exclusive/voiceMessages/ctrlStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_voice_msg_ctrl_status(
        self,
        request: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse:
        """
        @summary 允许三方调用该API，决定对应的语音消息管控状态
        
        @param request: UpdateVoiceMsgCtrlStatusRequest
        @return: UpdateVoiceMsgCtrlStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusHeaders()
        return self.update_voice_msg_ctrl_status_with_options(request, headers, runtime)

    async def update_voice_msg_ctrl_status_async(
        self,
        request: dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusRequest,
    ) -> dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusResponse:
        """
        @summary 允许三方调用该API，决定对应的语音消息管控状态
        
        @param request: UpdateVoiceMsgCtrlStatusRequest
        @return: UpdateVoiceMsgCtrlStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkexclusive__1__0_models.UpdateVoiceMsgCtrlStatusHeaders()
        return await self.update_voice_msg_ctrl_status_with_options_async(request, headers, runtime)
