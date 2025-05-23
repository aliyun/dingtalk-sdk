# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.contact_1_0 import models as dingtalkcontact__1__0_models
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

    def add_account_mapping_with_options(
        self,
        request: dingtalkcontact__1__0_models.AddAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.AddAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddAccountMappingResponse:
        """
        @summary 创建账号映射
        
        @param request: AddAccountMappingRequest
        @param headers: AddAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAccountMappingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.out_id):
            body['outId'] = request.out_id
        if not UtilClient.is_unset(request.out_tenant_id):
            body['outTenantId'] = request.out_tenant_id
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
            action='AddAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddAccountMappingResponse(),
            self.execute(params, req, runtime)
        )

    async def add_account_mapping_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.AddAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.AddAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddAccountMappingResponse:
        """
        @summary 创建账号映射
        
        @param request: AddAccountMappingRequest
        @param headers: AddAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddAccountMappingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.domain):
            body['domain'] = request.domain
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.out_id):
            body['outId'] = request.out_id
        if not UtilClient.is_unset(request.out_tenant_id):
            body['outTenantId'] = request.out_tenant_id
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
            action='AddAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddAccountMappingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_account_mapping(
        self,
        request: dingtalkcontact__1__0_models.AddAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.AddAccountMappingResponse:
        """
        @summary 创建账号映射
        
        @param request: AddAccountMappingRequest
        @return: AddAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddAccountMappingHeaders()
        return self.add_account_mapping_with_options(request, headers, runtime)

    async def add_account_mapping_async(
        self,
        request: dingtalkcontact__1__0_models.AddAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.AddAccountMappingResponse:
        """
        @summary 创建账号映射
        
        @param request: AddAccountMappingRequest
        @return: AddAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddAccountMappingHeaders()
        return await self.add_account_mapping_with_options_async(request, headers, runtime)

    def add_contact_hide_by_scene_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.AddContactHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.AddContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse:
        """
        @summary 添加通讯录组织架构分场景隐藏设置
        
        @param request: AddContactHideBySceneSettingRequest
        @param headers: AddContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddContactHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.node_list_scene_config):
            body['nodeListSceneConfig'] = request.node_list_scene_config
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def add_contact_hide_by_scene_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.AddContactHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.AddContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse:
        """
        @summary 添加通讯录组织架构分场景隐藏设置
        
        @param request: AddContactHideBySceneSettingRequest
        @param headers: AddContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddContactHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.node_list_scene_config):
            body['nodeListSceneConfig'] = request.node_list_scene_config
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_contact_hide_by_scene_setting(
        self,
        request: dingtalkcontact__1__0_models.AddContactHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse:
        """
        @summary 添加通讯录组织架构分场景隐藏设置
        
        @param request: AddContactHideBySceneSettingRequest
        @return: AddContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddContactHideBySceneSettingHeaders()
        return self.add_contact_hide_by_scene_setting_with_options(request, headers, runtime)

    async def add_contact_hide_by_scene_setting_async(
        self,
        request: dingtalkcontact__1__0_models.AddContactHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.AddContactHideBySceneSettingResponse:
        """
        @summary 添加通讯录组织架构分场景隐藏设置
        
        @param request: AddContactHideBySceneSettingRequest
        @return: AddContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddContactHideBySceneSettingHeaders()
        return await self.add_contact_hide_by_scene_setting_with_options_async(request, headers, runtime)

    def add_emp_attribute_hide_by_scene_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse:
        """
        @summary 添加员工属性分场景隐藏设置
        
        @param request: AddEmpAttributeHideBySceneSettingRequest
        @param headers: AddEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddEmpAttributeHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_subtitle_config):
            body['chatSubtitleConfig'] = request.chat_subtitle_config
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def add_emp_attribute_hide_by_scene_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse:
        """
        @summary 添加员工属性分场景隐藏设置
        
        @param request: AddEmpAttributeHideBySceneSettingRequest
        @param headers: AddEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddEmpAttributeHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_subtitle_config):
            body['chatSubtitleConfig'] = request.chat_subtitle_config
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_emp_attribute_hide_by_scene_setting(
        self,
        request: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse:
        """
        @summary 添加员工属性分场景隐藏设置
        
        @param request: AddEmpAttributeHideBySceneSettingRequest
        @return: AddEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingHeaders()
        return self.add_emp_attribute_hide_by_scene_setting_with_options(request, headers, runtime)

    async def add_emp_attribute_hide_by_scene_setting_async(
        self,
        request: dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingResponse:
        """
        @summary 添加员工属性分场景隐藏设置
        
        @param request: AddEmpAttributeHideBySceneSettingRequest
        @return: AddEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddEmpAttributeHideBySceneSettingHeaders()
        return await self.add_emp_attribute_hide_by_scene_setting_with_options_async(request, headers, runtime)

    def add_org_account_ownness_with_options(
        self,
        request: dingtalkcontact__1__0_models.AddOrgAccountOwnnessRequest,
        headers: dingtalkcontact__1__0_models.AddOrgAccountOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse:
        """
        @summary 新增企业账号工作状态
        
        @param request: AddOrgAccountOwnnessRequest
        @param headers: AddOrgAccountOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgAccountOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            body['ownnessId'] = request.ownness_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOrgAccountOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/owness',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse(),
            self.execute(params, req, runtime)
        )

    async def add_org_account_ownness_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.AddOrgAccountOwnnessRequest,
        headers: dingtalkcontact__1__0_models.AddOrgAccountOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse:
        """
        @summary 新增企业账号工作状态
        
        @param request: AddOrgAccountOwnnessRequest
        @param headers: AddOrgAccountOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddOrgAccountOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            body['ownnessId'] = request.ownness_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AddOrgAccountOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/owness',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_org_account_ownness(
        self,
        request: dingtalkcontact__1__0_models.AddOrgAccountOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse:
        """
        @summary 新增企业账号工作状态
        
        @param request: AddOrgAccountOwnnessRequest
        @return: AddOrgAccountOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddOrgAccountOwnnessHeaders()
        return self.add_org_account_ownness_with_options(request, headers, runtime)

    async def add_org_account_ownness_async(
        self,
        request: dingtalkcontact__1__0_models.AddOrgAccountOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.AddOrgAccountOwnnessResponse:
        """
        @summary 新增企业账号工作状态
        
        @param request: AddOrgAccountOwnnessRequest
        @return: AddOrgAccountOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AddOrgAccountOwnnessHeaders()
        return await self.add_org_account_ownness_with_options_async(request, headers, runtime)

    def annual_certification_audit_with_options(
        self,
        request: dingtalkcontact__1__0_models.AnnualCertificationAuditRequest,
        headers: dingtalkcontact__1__0_models.AnnualCertificationAuditHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AnnualCertificationAuditResponse:
        """
        @summary 年检认证审核
        
        @param request: AnnualCertificationAuditRequest
        @param headers: AnnualCertificationAuditHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnnualCertificationAuditResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.applicant_mobile):
            body['applicantMobile'] = request.applicant_mobile
        if not UtilClient.is_unset(request.applicant_name):
            body['applicantName'] = request.applicant_name
        if not UtilClient.is_unset(request.application_letter):
            body['applicationLetter'] = request.application_letter
        if not UtilClient.is_unset(request.auth_status):
            body['authStatus'] = request.auth_status
        if not UtilClient.is_unset(request.certificate_type):
            body['certificateType'] = request.certificate_type
        if not UtilClient.is_unset(request.corp_name):
            body['corpName'] = request.corp_name
        if not UtilClient.is_unset(request.depositary_bank):
            body['depositaryBank'] = request.depositary_bank
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.legal_person):
            body['legalPerson'] = request.legal_person
        if not UtilClient.is_unset(request.license_number):
            body['licenseNumber'] = request.license_number
        if not UtilClient.is_unset(request.license_url):
            body['licenseUrl'] = request.license_url
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.public_account):
            body['publicAccount'] = request.public_account
        if not UtilClient.is_unset(request.reason_code):
            body['reasonCode'] = request.reason_code
        if not UtilClient.is_unset(request.reason_msg):
            body['reasonMsg'] = request.reason_msg
        if not UtilClient.is_unset(request.tag):
            body['tag'] = request.tag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AnnualCertificationAudit',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/authorities/audit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AnnualCertificationAuditResponse(),
            self.execute(params, req, runtime)
        )

    async def annual_certification_audit_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.AnnualCertificationAuditRequest,
        headers: dingtalkcontact__1__0_models.AnnualCertificationAuditHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.AnnualCertificationAuditResponse:
        """
        @summary 年检认证审核
        
        @param request: AnnualCertificationAuditRequest
        @param headers: AnnualCertificationAuditHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AnnualCertificationAuditResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.applicant_mobile):
            body['applicantMobile'] = request.applicant_mobile
        if not UtilClient.is_unset(request.applicant_name):
            body['applicantName'] = request.applicant_name
        if not UtilClient.is_unset(request.application_letter):
            body['applicationLetter'] = request.application_letter
        if not UtilClient.is_unset(request.auth_status):
            body['authStatus'] = request.auth_status
        if not UtilClient.is_unset(request.certificate_type):
            body['certificateType'] = request.certificate_type
        if not UtilClient.is_unset(request.corp_name):
            body['corpName'] = request.corp_name
        if not UtilClient.is_unset(request.depositary_bank):
            body['depositaryBank'] = request.depositary_bank
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.legal_person):
            body['legalPerson'] = request.legal_person
        if not UtilClient.is_unset(request.license_number):
            body['licenseNumber'] = request.license_number
        if not UtilClient.is_unset(request.license_url):
            body['licenseUrl'] = request.license_url
        if not UtilClient.is_unset(request.order_id):
            body['orderId'] = request.order_id
        if not UtilClient.is_unset(request.public_account):
            body['publicAccount'] = request.public_account
        if not UtilClient.is_unset(request.reason_code):
            body['reasonCode'] = request.reason_code
        if not UtilClient.is_unset(request.reason_msg):
            body['reasonMsg'] = request.reason_msg
        if not UtilClient.is_unset(request.tag):
            body['tag'] = request.tag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='AnnualCertificationAudit',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/authorities/audit',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.AnnualCertificationAuditResponse(),
            await self.execute_async(params, req, runtime)
        )

    def annual_certification_audit(
        self,
        request: dingtalkcontact__1__0_models.AnnualCertificationAuditRequest,
    ) -> dingtalkcontact__1__0_models.AnnualCertificationAuditResponse:
        """
        @summary 年检认证审核
        
        @param request: AnnualCertificationAuditRequest
        @return: AnnualCertificationAuditResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AnnualCertificationAuditHeaders()
        return self.annual_certification_audit_with_options(request, headers, runtime)

    async def annual_certification_audit_async(
        self,
        request: dingtalkcontact__1__0_models.AnnualCertificationAuditRequest,
    ) -> dingtalkcontact__1__0_models.AnnualCertificationAuditResponse:
        """
        @summary 年检认证审核
        
        @param request: AnnualCertificationAuditRequest
        @return: AnnualCertificationAuditResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.AnnualCertificationAuditHeaders()
        return await self.annual_certification_audit_with_options_async(request, headers, runtime)

    def batch_approve_union_apply_with_options(
        self,
        request: dingtalkcontact__1__0_models.BatchApproveUnionApplyRequest,
        headers: dingtalkcontact__1__0_models.BatchApproveUnionApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse:
        """
        @summary 批量同意(合作空间/集团)的关联申请
        
        @param request: BatchApproveUnionApplyRequest
        @param headers: BatchApproveUnionApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchApproveUnionApplyResponse
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
            action='BatchApproveUnionApply',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/unionApplications/approve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_approve_union_apply_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.BatchApproveUnionApplyRequest,
        headers: dingtalkcontact__1__0_models.BatchApproveUnionApplyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse:
        """
        @summary 批量同意(合作空间/集团)的关联申请
        
        @param request: BatchApproveUnionApplyRequest
        @param headers: BatchApproveUnionApplyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchApproveUnionApplyResponse
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
            action='BatchApproveUnionApply',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/unionApplications/approve',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_approve_union_apply(
        self,
        request: dingtalkcontact__1__0_models.BatchApproveUnionApplyRequest,
    ) -> dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse:
        """
        @summary 批量同意(合作空间/集团)的关联申请
        
        @param request: BatchApproveUnionApplyRequest
        @return: BatchApproveUnionApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.BatchApproveUnionApplyHeaders()
        return self.batch_approve_union_apply_with_options(request, headers, runtime)

    async def batch_approve_union_apply_async(
        self,
        request: dingtalkcontact__1__0_models.BatchApproveUnionApplyRequest,
    ) -> dingtalkcontact__1__0_models.BatchApproveUnionApplyResponse:
        """
        @summary 批量同意(合作空间/集团)的关联申请
        
        @param request: BatchApproveUnionApplyRequest
        @return: BatchApproveUnionApplyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.BatchApproveUnionApplyHeaders()
        return await self.batch_approve_union_apply_with_options_async(request, headers, runtime)

    def batch_update_external_title_with_options(
        self,
        request: dingtalkcontact__1__0_models.BatchUpdateExternalTitleRequest,
        headers: dingtalkcontact__1__0_models.BatchUpdateExternalTitleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse:
        """
        @summary 批量修改企业员工对外职位信息
        
        @param request: BatchUpdateExternalTitleRequest
        @param headers: BatchUpdateExternalTitleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateExternalTitleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.update_title_model_list):
            body['updateTitleModelList'] = request.update_title_model_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchUpdateExternalTitle',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/externalTitles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_external_title_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.BatchUpdateExternalTitleRequest,
        headers: dingtalkcontact__1__0_models.BatchUpdateExternalTitleHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse:
        """
        @summary 批量修改企业员工对外职位信息
        
        @param request: BatchUpdateExternalTitleRequest
        @param headers: BatchUpdateExternalTitleHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateExternalTitleResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.update_title_model_list):
            body['updateTitleModelList'] = request.update_title_model_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchUpdateExternalTitle',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/externalTitles',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_external_title(
        self,
        request: dingtalkcontact__1__0_models.BatchUpdateExternalTitleRequest,
    ) -> dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse:
        """
        @summary 批量修改企业员工对外职位信息
        
        @param request: BatchUpdateExternalTitleRequest
        @return: BatchUpdateExternalTitleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.BatchUpdateExternalTitleHeaders()
        return self.batch_update_external_title_with_options(request, headers, runtime)

    async def batch_update_external_title_async(
        self,
        request: dingtalkcontact__1__0_models.BatchUpdateExternalTitleRequest,
    ) -> dingtalkcontact__1__0_models.BatchUpdateExternalTitleResponse:
        """
        @summary 批量修改企业员工对外职位信息
        
        @param request: BatchUpdateExternalTitleRequest
        @return: BatchUpdateExternalTitleResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.BatchUpdateExternalTitleHeaders()
        return await self.batch_update_external_title_with_options_async(request, headers, runtime)

    def change_ding_talk_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.ChangeDingTalkIdRequest,
        headers: dingtalkcontact__1__0_models.ChangeDingTalkIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ChangeDingTalkIdResponse:
        """
        @summary 修改钉钉号
        
        @param request: ChangeDingTalkIdRequest
        @param headers: ChangeDingTalkIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeDingTalkIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_talk_id):
            body['dingTalkId'] = request.ding_talk_id
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
            action='ChangeDingTalkId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/dingTalkIds/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ChangeDingTalkIdResponse(),
            self.execute(params, req, runtime)
        )

    async def change_ding_talk_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ChangeDingTalkIdRequest,
        headers: dingtalkcontact__1__0_models.ChangeDingTalkIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ChangeDingTalkIdResponse:
        """
        @summary 修改钉钉号
        
        @param request: ChangeDingTalkIdRequest
        @param headers: ChangeDingTalkIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeDingTalkIdResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.ding_talk_id):
            body['dingTalkId'] = request.ding_talk_id
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
            action='ChangeDingTalkId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/dingTalkIds/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ChangeDingTalkIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def change_ding_talk_id(
        self,
        request: dingtalkcontact__1__0_models.ChangeDingTalkIdRequest,
    ) -> dingtalkcontact__1__0_models.ChangeDingTalkIdResponse:
        """
        @summary 修改钉钉号
        
        @param request: ChangeDingTalkIdRequest
        @return: ChangeDingTalkIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ChangeDingTalkIdHeaders()
        return self.change_ding_talk_id_with_options(request, headers, runtime)

    async def change_ding_talk_id_async(
        self,
        request: dingtalkcontact__1__0_models.ChangeDingTalkIdRequest,
    ) -> dingtalkcontact__1__0_models.ChangeDingTalkIdResponse:
        """
        @summary 修改钉钉号
        
        @param request: ChangeDingTalkIdRequest
        @return: ChangeDingTalkIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ChangeDingTalkIdHeaders()
        return await self.change_ding_talk_id_with_options_async(request, headers, runtime)

    def change_main_admin_with_options(
        self,
        request: dingtalkcontact__1__0_models.ChangeMainAdminRequest,
        headers: dingtalkcontact__1__0_models.ChangeMainAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ChangeMainAdminResponse:
        """
        @summary 专属帐号转交主管理员(创建者)
        
        @param request: ChangeMainAdminRequest
        @param headers: ChangeMainAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeMainAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.effect_corp_id):
            body['effectCorpId'] = request.effect_corp_id
        if not UtilClient.is_unset(request.source_user_id):
            body['sourceUserId'] = request.source_user_id
        if not UtilClient.is_unset(request.target_user_id):
            body['targetUserId'] = request.target_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ChangeMainAdmin',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mainAdministrators/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ChangeMainAdminResponse(),
            self.execute(params, req, runtime)
        )

    async def change_main_admin_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ChangeMainAdminRequest,
        headers: dingtalkcontact__1__0_models.ChangeMainAdminHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ChangeMainAdminResponse:
        """
        @summary 专属帐号转交主管理员(创建者)
        
        @param request: ChangeMainAdminRequest
        @param headers: ChangeMainAdminHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ChangeMainAdminResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.effect_corp_id):
            body['effectCorpId'] = request.effect_corp_id
        if not UtilClient.is_unset(request.source_user_id):
            body['sourceUserId'] = request.source_user_id
        if not UtilClient.is_unset(request.target_user_id):
            body['targetUserId'] = request.target_user_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ChangeMainAdmin',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mainAdministrators/change',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ChangeMainAdminResponse(),
            await self.execute_async(params, req, runtime)
        )

    def change_main_admin(
        self,
        request: dingtalkcontact__1__0_models.ChangeMainAdminRequest,
    ) -> dingtalkcontact__1__0_models.ChangeMainAdminResponse:
        """
        @summary 专属帐号转交主管理员(创建者)
        
        @param request: ChangeMainAdminRequest
        @return: ChangeMainAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ChangeMainAdminHeaders()
        return self.change_main_admin_with_options(request, headers, runtime)

    async def change_main_admin_async(
        self,
        request: dingtalkcontact__1__0_models.ChangeMainAdminRequest,
    ) -> dingtalkcontact__1__0_models.ChangeMainAdminResponse:
        """
        @summary 专属帐号转交主管理员(创建者)
        
        @param request: ChangeMainAdminRequest
        @return: ChangeMainAdminResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ChangeMainAdminHeaders()
        return await self.change_main_admin_with_options_async(request, headers, runtime)

    def create_cooperate_org_with_options(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
        headers: dingtalkcontact__1__0_models.CreateCooperateOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        """
        @summary 创建合作空间
        
        @param request: CreateCooperateOrgRequest
        @param headers: CreateCooperateOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCooperateOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
        if not UtilClient.is_unset(request.logo_media_id):
            body['logoMediaId'] = request.logo_media_id
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCooperateOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateCooperateOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def create_cooperate_org_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
        headers: dingtalkcontact__1__0_models.CreateCooperateOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        """
        @summary 创建合作空间
        
        @param request: CreateCooperateOrgRequest
        @param headers: CreateCooperateOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateCooperateOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.industry_code):
            body['industryCode'] = request.industry_code
        if not UtilClient.is_unset(request.logo_media_id):
            body['logoMediaId'] = request.logo_media_id
        if not UtilClient.is_unset(request.org_name):
            body['orgName'] = request.org_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateCooperateOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateCooperateOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_cooperate_org(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        """
        @summary 创建合作空间
        
        @param request: CreateCooperateOrgRequest
        @return: CreateCooperateOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateCooperateOrgHeaders()
        return self.create_cooperate_org_with_options(request, headers, runtime)

    async def create_cooperate_org_async(
        self,
        request: dingtalkcontact__1__0_models.CreateCooperateOrgRequest,
    ) -> dingtalkcontact__1__0_models.CreateCooperateOrgResponse:
        """
        @summary 创建合作空间
        
        @param request: CreateCooperateOrgRequest
        @return: CreateCooperateOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateCooperateOrgHeaders()
        return await self.create_cooperate_org_with_options_async(request, headers, runtime)

    def create_management_group_with_options(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        """
        @summary 创建管理组
        
        @param request: CreateManagementGroupRequest
        @param headers: CreateManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateManagementGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateManagementGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_management_group_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        """
        @summary 创建管理组
        
        @param request: CreateManagementGroupRequest
        @param headers: CreateManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateManagementGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateManagementGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_management_group(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        """
        @summary 创建管理组
        
        @param request: CreateManagementGroupRequest
        @return: CreateManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateManagementGroupHeaders()
        return self.create_management_group_with_options(request, headers, runtime)

    async def create_management_group_async(
        self,
        request: dingtalkcontact__1__0_models.CreateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateManagementGroupResponse:
        """
        @summary 创建管理组
        
        @param request: CreateManagementGroupRequest
        @return: CreateManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateManagementGroupHeaders()
        return await self.create_management_group_with_options_async(request, headers, runtime)

    def create_secondary_management_group_with_options(
        self,
        request: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse:
        """
        @summary 子管理员创建管理组
        
        @param request: CreateSecondaryManagementGroupRequest
        @param headers: CreateSecondaryManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSecondaryManagementGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSecondaryManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/secondaryAdministrators/managementGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def create_secondary_management_group_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse:
        """
        @summary 子管理员创建管理组
        
        @param request: CreateSecondaryManagementGroupRequest
        @param headers: CreateSecondaryManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSecondaryManagementGroupResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSecondaryManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/secondaryAdministrators/managementGroups',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_secondary_management_group(
        self,
        request: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse:
        """
        @summary 子管理员创建管理组
        
        @param request: CreateSecondaryManagementGroupRequest
        @return: CreateSecondaryManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateSecondaryManagementGroupHeaders()
        return self.create_secondary_management_group_with_options(request, headers, runtime)

    async def create_secondary_management_group_async(
        self,
        request: dingtalkcontact__1__0_models.CreateSecondaryManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.CreateSecondaryManagementGroupResponse:
        """
        @summary 子管理员创建管理组
        
        @param request: CreateSecondaryManagementGroupRequest
        @return: CreateSecondaryManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.CreateSecondaryManagementGroupHeaders()
        return await self.create_secondary_management_group_with_options_async(request, headers, runtime)

    def del_account_mapping_with_options(
        self,
        request: dingtalkcontact__1__0_models.DelAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.DelAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DelAccountMappingResponse:
        """
        @summary 删除账号映射
        
        @param request: DelAccountMappingRequest
        @param headers: DelAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelAccountMappingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
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
            action='DelAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DelAccountMappingResponse(),
            self.execute(params, req, runtime)
        )

    async def del_account_mapping_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.DelAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.DelAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DelAccountMappingResponse:
        """
        @summary 删除账号映射
        
        @param request: DelAccountMappingRequest
        @param headers: DelAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelAccountMappingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
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
            action='DelAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DelAccountMappingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def del_account_mapping(
        self,
        request: dingtalkcontact__1__0_models.DelAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.DelAccountMappingResponse:
        """
        @summary 删除账号映射
        
        @param request: DelAccountMappingRequest
        @return: DelAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DelAccountMappingHeaders()
        return self.del_account_mapping_with_options(request, headers, runtime)

    async def del_account_mapping_async(
        self,
        request: dingtalkcontact__1__0_models.DelAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.DelAccountMappingResponse:
        """
        @summary 删除账号映射
        
        @param request: DelAccountMappingRequest
        @return: DelAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DelAccountMappingHeaders()
        return await self.del_account_mapping_with_options_async(request, headers, runtime)

    def del_org_acc_user_ownness_with_options(
        self,
        request: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse:
        """
        @summary 删除企业账号工作状态
        
        @param request: DelOrgAccUserOwnnessRequest
        @param headers: DelOrgAccUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelOrgAccUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ownenss_type):
            query['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            query['ownnessId'] = request.ownness_id
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
            action='DelOrgAccUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/ownness',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse(),
            self.execute(params, req, runtime)
        )

    async def del_org_acc_user_ownness_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse:
        """
        @summary 删除企业账号工作状态
        
        @param request: DelOrgAccUserOwnnessRequest
        @param headers: DelOrgAccUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelOrgAccUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ownenss_type):
            query['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            query['ownnessId'] = request.ownness_id
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
            action='DelOrgAccUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/ownness',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def del_org_acc_user_ownness(
        self,
        request: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse:
        """
        @summary 删除企业账号工作状态
        
        @param request: DelOrgAccUserOwnnessRequest
        @return: DelOrgAccUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DelOrgAccUserOwnnessHeaders()
        return self.del_org_acc_user_ownness_with_options(request, headers, runtime)

    async def del_org_acc_user_ownness_async(
        self,
        request: dingtalkcontact__1__0_models.DelOrgAccUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.DelOrgAccUserOwnnessResponse:
        """
        @summary 删除企业账号工作状态
        
        @param request: DelOrgAccUserOwnnessRequest
        @return: DelOrgAccUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DelOrgAccUserOwnnessHeaders()
        return await self.del_org_acc_user_ownness_with_options_async(request, headers, runtime)

    def delete_contact_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse:
        """
        @summary 删除通讯录组织架构分场景隐藏设置
        
        @param headers: DeleteContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactHideBySceneSettingResponse
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
            action='DeleteContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_contact_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse:
        """
        @summary 删除通讯录组织架构分场景隐藏设置
        
        @param headers: DeleteContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactHideBySceneSettingResponse
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
            action='DeleteContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_contact_hide_by_scene_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse:
        """
        @summary 删除通讯录组织架构分场景隐藏设置
        
        @return: DeleteContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingHeaders()
        return self.delete_contact_hide_by_scene_setting_with_options(setting_id, headers, runtime)

    async def delete_contact_hide_by_scene_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingResponse:
        """
        @summary 删除通讯录组织架构分场景隐藏设置
        
        @return: DeleteContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactHideBySceneSettingHeaders()
        return await self.delete_contact_hide_by_scene_setting_with_options_async(setting_id, headers, runtime)

    def delete_contact_hide_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactHideSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideSettingResponse:
        """
        @summary 删除通讯录隐藏设置
        
        @param headers: DeleteContactHideSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactHideSettingResponse
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
            action='DeleteContactHideSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactHideSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_contact_hide_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactHideSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideSettingResponse:
        """
        @summary 删除通讯录隐藏设置
        
        @param headers: DeleteContactHideSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactHideSettingResponse
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
            action='DeleteContactHideSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactHideSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_contact_hide_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideSettingResponse:
        """
        @summary 删除通讯录隐藏设置
        
        @return: DeleteContactHideSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactHideSettingHeaders()
        return self.delete_contact_hide_setting_with_options(setting_id, headers, runtime)

    async def delete_contact_hide_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactHideSettingResponse:
        """
        @summary 删除通讯录隐藏设置
        
        @return: DeleteContactHideSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactHideSettingHeaders()
        return await self.delete_contact_hide_setting_with_options_async(setting_id, headers, runtime)

    def delete_contact_restrict_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse:
        """
        @summary 删除限制查看通讯录设置
        
        @param headers: DeleteContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactRestrictSettingResponse
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
            action='DeleteContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_contact_restrict_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse:
        """
        @summary 删除限制查看通讯录设置
        
        @param headers: DeleteContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteContactRestrictSettingResponse
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
            action='DeleteContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_contact_restrict_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse:
        """
        @summary 删除限制查看通讯录设置
        
        @return: DeleteContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactRestrictSettingHeaders()
        return self.delete_contact_restrict_setting_with_options(setting_id, headers, runtime)

    async def delete_contact_restrict_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteContactRestrictSettingResponse:
        """
        @summary 删除限制查看通讯录设置
        
        @return: DeleteContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteContactRestrictSettingHeaders()
        return await self.delete_contact_restrict_setting_with_options_async(setting_id, headers, runtime)

    def delete_emp_attribute_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse:
        """
        @summary 删除员工属性分场景隐藏设置
        
        @param headers: DeleteEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteEmpAttributeHideBySceneSettingResponse
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
            action='DeleteEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_emp_attribute_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse:
        """
        @summary 删除员工属性分场景隐藏设置
        
        @param headers: DeleteEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteEmpAttributeHideBySceneSettingResponse
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
            action='DeleteEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_emp_attribute_hide_by_scene_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse:
        """
        @summary 删除员工属性分场景隐藏设置
        
        @return: DeleteEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingHeaders()
        return self.delete_emp_attribute_hide_by_scene_setting_with_options(setting_id, headers, runtime)

    async def delete_emp_attribute_hide_by_scene_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingResponse:
        """
        @summary 删除员工属性分场景隐藏设置
        
        @return: DeleteEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeHideBySceneSettingHeaders()
        return await self.delete_emp_attribute_hide_by_scene_setting_with_options_async(setting_id, headers, runtime)

    def delete_emp_attribute_visibility_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        """
        @summary 删除员工字段可见性设置
        
        @param headers: DeleteEmpAttributeVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteEmpAttributeVisibilityResponse
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
            action='DeleteEmpAttributeVisibility',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_emp_attribute_visibility_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        """
        @summary 删除员工字段可见性设置
        
        @param headers: DeleteEmpAttributeVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteEmpAttributeVisibilityResponse
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
            action='DeleteEmpAttributeVisibility',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings/{setting_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_emp_attribute_visibility(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        """
        @summary 删除员工字段可见性设置
        
        @return: DeleteEmpAttributeVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders()
        return self.delete_emp_attribute_visibility_with_options(setting_id, headers, runtime)

    async def delete_emp_attribute_visibility_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityResponse:
        """
        @summary 删除员工字段可见性设置
        
        @return: DeleteEmpAttributeVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteEmpAttributeVisibilityHeaders()
        return await self.delete_emp_attribute_visibility_with_options_async(setting_id, headers, runtime)

    def delete_management_group_with_options(
        self,
        group_id: str,
        headers: dingtalkcontact__1__0_models.DeleteManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        """
        @summary 删除管理组
        
        @param headers: DeleteManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteManagementGroupResponse
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
            action='DeleteManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups/{group_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteManagementGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_management_group_with_options_async(
        self,
        group_id: str,
        headers: dingtalkcontact__1__0_models.DeleteManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        """
        @summary 删除管理组
        
        @param headers: DeleteManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteManagementGroupResponse
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
            action='DeleteManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups/{group_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.DeleteManagementGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_management_group(
        self,
        group_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        """
        @summary 删除管理组
        
        @return: DeleteManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteManagementGroupHeaders()
        return self.delete_management_group_with_options(group_id, headers, runtime)

    async def delete_management_group_async(
        self,
        group_id: str,
    ) -> dingtalkcontact__1__0_models.DeleteManagementGroupResponse:
        """
        @summary 删除管理组
        
        @return: DeleteManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.DeleteManagementGroupHeaders()
        return await self.delete_management_group_with_options_async(group_id, headers, runtime)

    def get_account_mapping_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.GetAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetAccountMappingResponse:
        """
        @summary 获取账号映射
        
        @param request: GetAccountMappingRequest
        @param headers: GetAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccountMappingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
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
            action='GetAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetAccountMappingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_account_mapping_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetAccountMappingRequest,
        headers: dingtalkcontact__1__0_models.GetAccountMappingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetAccountMappingResponse:
        """
        @summary 获取账号映射
        
        @param request: GetAccountMappingRequest
        @param headers: GetAccountMappingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetAccountMappingResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.domain):
            query['domain'] = request.domain
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
            action='GetAccountMapping',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/accountMappings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetAccountMappingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_account_mapping(
        self,
        request: dingtalkcontact__1__0_models.GetAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.GetAccountMappingResponse:
        """
        @summary 获取账号映射
        
        @param request: GetAccountMappingRequest
        @return: GetAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetAccountMappingHeaders()
        return self.get_account_mapping_with_options(request, headers, runtime)

    async def get_account_mapping_async(
        self,
        request: dingtalkcontact__1__0_models.GetAccountMappingRequest,
    ) -> dingtalkcontact__1__0_models.GetAccountMappingResponse:
        """
        @summary 获取账号映射
        
        @param request: GetAccountMappingRequest
        @return: GetAccountMappingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetAccountMappingHeaders()
        return await self.get_account_mapping_with_options_async(request, headers, runtime)

    def get_apply_invite_info_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
        headers: dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        """
        @summary 获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null
        
        @param request: GetApplyInviteInfoRequest
        @param headers: GetApplyInviteInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApplyInviteInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.inviter_user_id):
            query['inviterUserId'] = request.inviter_user_id
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
            action='GetApplyInviteInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/invites/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetApplyInviteInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_apply_invite_info_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
        headers: dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        """
        @summary 获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null
        
        @param request: GetApplyInviteInfoRequest
        @param headers: GetApplyInviteInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetApplyInviteInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dept_id):
            query['deptId'] = request.dept_id
        if not UtilClient.is_unset(request.inviter_user_id):
            query['inviterUserId'] = request.inviter_user_id
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
            action='GetApplyInviteInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/invites/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetApplyInviteInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_apply_invite_info(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        """
        @summary 获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null
        
        @param request: GetApplyInviteInfoRequest
        @return: GetApplyInviteInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders()
        return self.get_apply_invite_info_with_options(request, headers, runtime)

    async def get_apply_invite_info_async(
        self,
        request: dingtalkcontact__1__0_models.GetApplyInviteInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetApplyInviteInfoResponse:
        """
        @summary 获取企业的邀请信息，如果传部门ID则邀请链接为邀请加入部门，否则加入根部门；如果企业未开启邀请或者链接申请加入邀请链接为null
        
        @param request: GetApplyInviteInfoRequest
        @return: GetApplyInviteInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetApplyInviteInfoHeaders()
        return await self.get_apply_invite_info_with_options_async(request, headers, runtime)

    def get_branch_auth_data_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
        headers: dingtalkcontact__1__0_models.GetBranchAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        """
        @summary 分支授权主干的行业数据
        
        @param request: GetBranchAuthDataRequest
        @param headers: GetBranchAuthDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBranchAuthDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.branch_corp_id):
            query['branchCorpId'] = request.branch_corp_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        body = {}
        if not UtilClient.is_unset(request.body):
            body['body'] = request.body
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetBranchAuthData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/branchAuthDatas/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetBranchAuthDataResponse(),
            self.execute(params, req, runtime)
        )

    async def get_branch_auth_data_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
        headers: dingtalkcontact__1__0_models.GetBranchAuthDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        """
        @summary 分支授权主干的行业数据
        
        @param request: GetBranchAuthDataRequest
        @param headers: GetBranchAuthDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetBranchAuthDataResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.branch_corp_id):
            query['branchCorpId'] = request.branch_corp_id
        if not UtilClient.is_unset(request.code):
            query['code'] = request.code
        body = {}
        if not UtilClient.is_unset(request.body):
            body['body'] = request.body
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetBranchAuthData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/branchAuthDatas/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetBranchAuthDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_branch_auth_data(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        """
        @summary 分支授权主干的行业数据
        
        @param request: GetBranchAuthDataRequest
        @return: GetBranchAuthDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetBranchAuthDataHeaders()
        return self.get_branch_auth_data_with_options(request, headers, runtime)

    async def get_branch_auth_data_async(
        self,
        request: dingtalkcontact__1__0_models.GetBranchAuthDataRequest,
    ) -> dingtalkcontact__1__0_models.GetBranchAuthDataResponse:
        """
        @summary 分支授权主干的行业数据
        
        @param request: GetBranchAuthDataRequest
        @return: GetBranchAuthDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetBranchAuthDataHeaders()
        return await self.get_branch_auth_data_with_options_async(request, headers, runtime)

    def get_card_in_user_holder_with_options(
        self,
        card_id: str,
        headers: dingtalkcontact__1__0_models.GetCardInUserHolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCardInUserHolderResponse:
        """
        @summary 查询用户名片夹中的某张名片信息
        
        @param headers: GetCardInUserHolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCardInUserHolderResponse
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
            action='GetCardInUserHolder',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/holders/infos/{card_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCardInUserHolderResponse(),
            self.execute(params, req, runtime)
        )

    async def get_card_in_user_holder_with_options_async(
        self,
        card_id: str,
        headers: dingtalkcontact__1__0_models.GetCardInUserHolderHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCardInUserHolderResponse:
        """
        @summary 查询用户名片夹中的某张名片信息
        
        @param headers: GetCardInUserHolderHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCardInUserHolderResponse
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
            action='GetCardInUserHolder',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/holders/infos/{card_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCardInUserHolderResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_card_in_user_holder(
        self,
        card_id: str,
    ) -> dingtalkcontact__1__0_models.GetCardInUserHolderResponse:
        """
        @summary 查询用户名片夹中的某张名片信息
        
        @return: GetCardInUserHolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCardInUserHolderHeaders()
        return self.get_card_in_user_holder_with_options(card_id, headers, runtime)

    async def get_card_in_user_holder_async(
        self,
        card_id: str,
    ) -> dingtalkcontact__1__0_models.GetCardInUserHolderResponse:
        """
        @summary 查询用户名片夹中的某张名片信息
        
        @return: GetCardInUserHolderResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCardInUserHolderHeaders()
        return await self.get_card_in_user_holder_with_options_async(card_id, headers, runtime)

    def get_card_info_with_options(
        self,
        card_id: str,
        headers: dingtalkcontact__1__0_models.GetCardInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCardInfoResponse:
        """
        @summary 查询用户名片信息
        
        @param headers: GetCardInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCardInfoResponse
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
            action='GetCardInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/infos/{card_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCardInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_card_info_with_options_async(
        self,
        card_id: str,
        headers: dingtalkcontact__1__0_models.GetCardInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCardInfoResponse:
        """
        @summary 查询用户名片信息
        
        @param headers: GetCardInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCardInfoResponse
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
            action='GetCardInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/infos/{card_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCardInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_card_info(
        self,
        card_id: str,
    ) -> dingtalkcontact__1__0_models.GetCardInfoResponse:
        """
        @summary 查询用户名片信息
        
        @return: GetCardInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCardInfoHeaders()
        return self.get_card_info_with_options(card_id, headers, runtime)

    async def get_card_info_async(
        self,
        card_id: str,
    ) -> dingtalkcontact__1__0_models.GetCardInfoResponse:
        """
        @summary 查询用户名片信息
        
        @return: GetCardInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCardInfoHeaders()
        return await self.get_card_info_with_options_async(card_id, headers, runtime)

    def get_contact_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.GetContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse:
        """
        @summary 获取通讯录组织架构分场景隐藏设置
        
        @param headers: GetContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetContactHideBySceneSettingResponse
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
            action='GetContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_contact_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.GetContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse:
        """
        @summary 获取通讯录组织架构分场景隐藏设置
        
        @param headers: GetContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetContactHideBySceneSettingResponse
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
            action='GetContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_contact_hide_by_scene_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse:
        """
        @summary 获取通讯录组织架构分场景隐藏设置
        
        @return: GetContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetContactHideBySceneSettingHeaders()
        return self.get_contact_hide_by_scene_setting_with_options(setting_id, headers, runtime)

    async def get_contact_hide_by_scene_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.GetContactHideBySceneSettingResponse:
        """
        @summary 获取通讯录组织架构分场景隐藏设置
        
        @return: GetContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetContactHideBySceneSettingHeaders()
        return await self.get_contact_hide_by_scene_setting_with_options_async(setting_id, headers, runtime)

    def get_cooperate_org_invite_info_with_options(
        self,
        cooperate_corp_id: str,
        headers: dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        """
        @summary 获取邀请加入合作空间链接，分享链接之后企业可以申请加入
        
        @param headers: GetCooperateOrgInviteInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCooperateOrgInviteInfoResponse
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
            action='GetCooperateOrgInviteInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/{cooperate_corp_id}/inviteInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_cooperate_org_invite_info_with_options_async(
        self,
        cooperate_corp_id: str,
        headers: dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        """
        @summary 获取邀请加入合作空间链接，分享链接之后企业可以申请加入
        
        @param headers: GetCooperateOrgInviteInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCooperateOrgInviteInfoResponse
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
            action='GetCooperateOrgInviteInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/{cooperate_corp_id}/inviteInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_cooperate_org_invite_info(
        self,
        cooperate_corp_id: str,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        """
        @summary 获取邀请加入合作空间链接，分享链接之后企业可以申请加入
        
        @return: GetCooperateOrgInviteInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders()
        return self.get_cooperate_org_invite_info_with_options(cooperate_corp_id, headers, runtime)

    async def get_cooperate_org_invite_info_async(
        self,
        cooperate_corp_id: str,
    ) -> dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoResponse:
        """
        @summary 获取邀请加入合作空间链接，分享链接之后企业可以申请加入
        
        @return: GetCooperateOrgInviteInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCooperateOrgInviteInfoHeaders()
        return await self.get_cooperate_org_invite_info_with_options_async(cooperate_corp_id, headers, runtime)

    def get_corp_card_style_list_with_options(
        self,
        headers: dingtalkcontact__1__0_models.GetCorpCardStyleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCorpCardStyleListResponse:
        """
        @summary 查询企业模板列表
        
        @param headers: GetCorpCardStyleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpCardStyleListResponse
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
            action='GetCorpCardStyleList',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/styles/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCorpCardStyleListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_corp_card_style_list_with_options_async(
        self,
        headers: dingtalkcontact__1__0_models.GetCorpCardStyleListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetCorpCardStyleListResponse:
        """
        @summary 查询企业模板列表
        
        @param headers: GetCorpCardStyleListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetCorpCardStyleListResponse
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
            action='GetCorpCardStyleList',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/styles/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetCorpCardStyleListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_corp_card_style_list(self) -> dingtalkcontact__1__0_models.GetCorpCardStyleListResponse:
        """
        @summary 查询企业模板列表
        
        @return: GetCorpCardStyleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCorpCardStyleListHeaders()
        return self.get_corp_card_style_list_with_options(headers, runtime)

    async def get_corp_card_style_list_async(self) -> dingtalkcontact__1__0_models.GetCorpCardStyleListResponse:
        """
        @summary 查询企业模板列表
        
        @return: GetCorpCardStyleListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetCorpCardStyleListHeaders()
        return await self.get_corp_card_style_list_with_options_async(headers, runtime)

    def get_ding_id_by_migration_ding_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId
        
        @param request: GetDingIdByMigrationDingIdRequest
        @param headers: GetDingIdByMigrationDingIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingIdByMigrationDingIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_ding_id):
            query['migrationDingId'] = request.migration_ding_id
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
            action='GetDingIdByMigrationDingId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getDingIdByMigrationDingIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_ding_id_by_migration_ding_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId
        
        @param request: GetDingIdByMigrationDingIdRequest
        @param headers: GetDingIdByMigrationDingIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDingIdByMigrationDingIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_ding_id):
            query['migrationDingId'] = request.migration_ding_id
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
            action='GetDingIdByMigrationDingId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getDingIdByMigrationDingIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_ding_id_by_migration_ding_id(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId
        
        @param request: GetDingIdByMigrationDingIdRequest
        @return: GetDingIdByMigrationDingIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders()
        return self.get_ding_id_by_migration_ding_id_with_options(request, headers, runtime)

    async def get_ding_id_by_migration_ding_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的dingId查询原dingId
        
        @param request: GetDingIdByMigrationDingIdRequest
        @return: GetDingIdByMigrationDingIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetDingIdByMigrationDingIdHeaders()
        return await self.get_ding_id_by_migration_ding_id_with_options_async(request, headers, runtime)

    def get_emp_attribute_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse:
        """
        @summary 获取员工属性分场景隐藏设置
        
        @param headers: GetEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmpAttributeHideBySceneSettingResponse
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
            action='GetEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def get_emp_attribute_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        headers: dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse:
        """
        @summary 获取员工属性分场景隐藏设置
        
        @param headers: GetEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetEmpAttributeHideBySceneSettingResponse
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
            action='GetEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_emp_attribute_hide_by_scene_setting(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse:
        """
        @summary 获取员工属性分场景隐藏设置
        
        @return: GetEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingHeaders()
        return self.get_emp_attribute_hide_by_scene_setting_with_options(setting_id, headers, runtime)

    async def get_emp_attribute_hide_by_scene_setting_async(
        self,
        setting_id: str,
    ) -> dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingResponse:
        """
        @summary 获取员工属性分场景隐藏设置
        
        @return: GetEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetEmpAttributeHideBySceneSettingHeaders()
        return await self.get_emp_attribute_hide_by_scene_setting_with_options_async(setting_id, headers, runtime)

    def get_latest_ding_index_with_options(
        self,
        headers: dingtalkcontact__1__0_models.GetLatestDingIndexHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        """
        @summary 获取企业最新的钉钉指数
        
        @param headers: GetLatestDingIndexHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLatestDingIndexResponse
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
            action='GetLatestDingIndex',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/dingIndexs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetLatestDingIndexResponse(),
            self.execute(params, req, runtime)
        )

    async def get_latest_ding_index_with_options_async(
        self,
        headers: dingtalkcontact__1__0_models.GetLatestDingIndexHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        """
        @summary 获取企业最新的钉钉指数
        
        @param headers: GetLatestDingIndexHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetLatestDingIndexResponse
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
            action='GetLatestDingIndex',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/dingIndexs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetLatestDingIndexResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_latest_ding_index(self) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        """
        @summary 获取企业最新的钉钉指数
        
        @return: GetLatestDingIndexResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetLatestDingIndexHeaders()
        return self.get_latest_ding_index_with_options(headers, runtime)

    async def get_latest_ding_index_async(self) -> dingtalkcontact__1__0_models.GetLatestDingIndexResponse:
        """
        @summary 获取企业最新的钉钉指数
        
        @return: GetLatestDingIndexResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetLatestDingIndexHeaders()
        return await self.get_latest_ding_index_with_options_async(headers, runtime)

    def get_migration_ding_id_by_ding_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId
        
        @param request: GetMigrationDingIdByDingIdRequest
        @param headers: GetMigrationDingIdByDingIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMigrationDingIdByDingIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_id):
            query['dingId'] = request.ding_id
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
            action='GetMigrationDingIdByDingId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getMigrationDingIdByDingIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_migration_ding_id_by_ding_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId
        
        @param request: GetMigrationDingIdByDingIdRequest
        @param headers: GetMigrationDingIdByDingIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMigrationDingIdByDingIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.ding_id):
            query['dingId'] = request.ding_id
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
            action='GetMigrationDingIdByDingId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getMigrationDingIdByDingIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_migration_ding_id_by_ding_id(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId
        
        @param request: GetMigrationDingIdByDingIdRequest
        @return: GetMigrationDingIdByDingIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders()
        return self.get_migration_ding_id_by_ding_id_with_options(request, headers, runtime)

    async def get_migration_ding_id_by_ding_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原dingId查询迁移后的dingId
        
        @param request: GetMigrationDingIdByDingIdRequest
        @return: GetMigrationDingIdByDingIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationDingIdByDingIdHeaders()
        return await self.get_migration_ding_id_by_ding_id_with_options_async(request, headers, runtime)

    def get_migration_union_id_by_union_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId
        
        @param request: GetMigrationUnionIdByUnionIdRequest
        @param headers: GetMigrationUnionIdByUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMigrationUnionIdByUnionIdResponse
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
            action='GetMigrationUnionIdByUnionId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_migration_union_id_by_union_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId
        
        @param request: GetMigrationUnionIdByUnionIdRequest
        @param headers: GetMigrationUnionIdByUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMigrationUnionIdByUnionIdResponse
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
            action='GetMigrationUnionIdByUnionId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_migration_union_id_by_union_id(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId
        
        @param request: GetMigrationUnionIdByUnionIdRequest
        @return: GetMigrationUnionIdByUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders()
        return self.get_migration_union_id_by_union_id_with_options(request, headers, runtime)

    async def get_migration_union_id_by_union_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据原unionId查询迁移后的unionId
        
        @param request: GetMigrationUnionIdByUnionIdRequest
        @return: GetMigrationUnionIdByUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetMigrationUnionIdByUnionIdHeaders()
        return await self.get_migration_union_id_by_union_id_with_options_async(request, headers, runtime)

    def get_org_auth_info_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetOrgAuthInfoRequest,
        headers: dingtalkcontact__1__0_models.GetOrgAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetOrgAuthInfoResponse:
        """
        @summary 查询企业认证信息
        
        @param request: GetOrgAuthInfoRequest
        @param headers: GetOrgAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgAuthInfoResponse
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
            action='GetOrgAuthInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetOrgAuthInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_org_auth_info_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetOrgAuthInfoRequest,
        headers: dingtalkcontact__1__0_models.GetOrgAuthInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetOrgAuthInfoResponse:
        """
        @summary 查询企业认证信息
        
        @param request: GetOrgAuthInfoRequest
        @param headers: GetOrgAuthInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetOrgAuthInfoResponse
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
            action='GetOrgAuthInfo',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/authInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetOrgAuthInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_org_auth_info(
        self,
        request: dingtalkcontact__1__0_models.GetOrgAuthInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetOrgAuthInfoResponse:
        """
        @summary 查询企业认证信息
        
        @param request: GetOrgAuthInfoRequest
        @return: GetOrgAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetOrgAuthInfoHeaders()
        return self.get_org_auth_info_with_options(request, headers, runtime)

    async def get_org_auth_info_async(
        self,
        request: dingtalkcontact__1__0_models.GetOrgAuthInfoRequest,
    ) -> dingtalkcontact__1__0_models.GetOrgAuthInfoResponse:
        """
        @summary 查询企业认证信息
        
        @param request: GetOrgAuthInfoRequest
        @return: GetOrgAuthInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetOrgAuthInfoHeaders()
        return await self.get_org_auth_info_with_options_async(request, headers, runtime)

    def get_translate_file_job_result_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
        headers: dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        """
        @summary 获取异步文件内容转译结果
        
        @param request: GetTranslateFileJobResultRequest
        @param headers: GetTranslateFileJobResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranslateFileJobResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_id):
            query['jobId'] = request.job_id
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
            action='GetTranslateFileJobResult',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/files/translateResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_translate_file_job_result_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
        headers: dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        """
        @summary 获取异步文件内容转译结果
        
        @param request: GetTranslateFileJobResultRequest
        @param headers: GetTranslateFileJobResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTranslateFileJobResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.job_id):
            query['jobId'] = request.job_id
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
            action='GetTranslateFileJobResult',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/files/translateResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_translate_file_job_result(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        """
        @summary 获取异步文件内容转译结果
        
        @param request: GetTranslateFileJobResultRequest
        @return: GetTranslateFileJobResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders()
        return self.get_translate_file_job_result_with_options(request, headers, runtime)

    async def get_translate_file_job_result_async(
        self,
        request: dingtalkcontact__1__0_models.GetTranslateFileJobResultRequest,
    ) -> dingtalkcontact__1__0_models.GetTranslateFileJobResultResponse:
        """
        @summary 获取异步文件内容转译结果
        
        @param request: GetTranslateFileJobResultRequest
        @return: GetTranslateFileJobResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetTranslateFileJobResultHeaders()
        return await self.get_translate_file_job_result_with_options_async(request, headers, runtime)

    def get_union_id_by_migration_union_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId
        
        @param request: GetUnionIdByMigrationUnionIdRequest
        @param headers: GetUnionIdByMigrationUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUnionIdByMigrationUnionIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_union_id):
            query['migrationUnionId'] = request.migration_union_id
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
            action='GetUnionIdByMigrationUnionId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_union_id_by_migration_union_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
        headers: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId
        
        @param request: GetUnionIdByMigrationUnionIdRequest
        @param headers: GetUnionIdByMigrationUnionIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUnionIdByMigrationUnionIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.migration_union_id):
            query['migrationUnionId'] = request.migration_union_id
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
            action='GetUnionIdByMigrationUnionId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_union_id_by_migration_union_id(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId
        
        @param request: GetUnionIdByMigrationUnionIdRequest
        @return: GetUnionIdByMigrationUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders()
        return self.get_union_id_by_migration_union_id_with_options(request, headers, runtime)

    async def get_union_id_by_migration_union_id_async(
        self,
        request: dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdRequest,
    ) -> dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdResponse:
        """
        @summary 普通帐号迁移为专属帐号后，根据迁移后的unionId查询原unionId
        
        @param request: GetUnionIdByMigrationUnionIdRequest
        @return: GetUnionIdByMigrationUnionIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUnionIdByMigrationUnionIdHeaders()
        return await self.get_union_id_by_migration_union_id_with_options_async(request, headers, runtime)

    def get_user_with_options(
        self,
        union_id: str,
        headers: dingtalkcontact__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        """
        @summary 获取用户个人信息
        
        @param headers: GetUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserResponse
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
            action='GetUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/{union_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_with_options_async(
        self,
        union_id: str,
        headers: dingtalkcontact__1__0_models.GetUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        """
        @summary 获取用户个人信息
        
        @param headers: GetUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserResponse
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
            action='GetUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/{union_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user(
        self,
        union_id: str,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        """
        @summary 获取用户个人信息
        
        @return: GetUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserHeaders()
        return self.get_user_with_options(union_id, headers, runtime)

    async def get_user_async(
        self,
        union_id: str,
    ) -> dingtalkcontact__1__0_models.GetUserResponse:
        """
        @summary 获取用户个人信息
        
        @return: GetUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserHeaders()
        return await self.get_user_with_options_async(union_id, headers, runtime)

    def get_user_card_holder_list_with_options(
        self,
        request: dingtalkcontact__1__0_models.GetUserCardHolderListRequest,
        headers: dingtalkcontact__1__0_models.GetUserCardHolderListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserCardHolderListResponse:
        """
        @summary 查询用户名片夹信息
        
        @param request: GetUserCardHolderListRequest
        @param headers: GetUserCardHolderListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserCardHolderListResponse
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
            action='GetUserCardHolderList',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/holders/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserCardHolderListResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_card_holder_list_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.GetUserCardHolderListRequest,
        headers: dingtalkcontact__1__0_models.GetUserCardHolderListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.GetUserCardHolderListResponse:
        """
        @summary 查询用户名片夹信息
        
        @param request: GetUserCardHolderListRequest
        @param headers: GetUserCardHolderListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserCardHolderListResponse
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
            action='GetUserCardHolderList',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/holders/lists',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.GetUserCardHolderListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_card_holder_list(
        self,
        request: dingtalkcontact__1__0_models.GetUserCardHolderListRequest,
    ) -> dingtalkcontact__1__0_models.GetUserCardHolderListResponse:
        """
        @summary 查询用户名片夹信息
        
        @param request: GetUserCardHolderListRequest
        @return: GetUserCardHolderListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserCardHolderListHeaders()
        return self.get_user_card_holder_list_with_options(request, headers, runtime)

    async def get_user_card_holder_list_async(
        self,
        request: dingtalkcontact__1__0_models.GetUserCardHolderListRequest,
    ) -> dingtalkcontact__1__0_models.GetUserCardHolderListResponse:
        """
        @summary 查询用户名片夹信息
        
        @param request: GetUserCardHolderListRequest
        @return: GetUserCardHolderListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.GetUserCardHolderListHeaders()
        return await self.get_user_card_holder_list_with_options_async(request, headers, runtime)

    def init_verify_event_with_options(
        self,
        request: dingtalkcontact__1__0_models.InitVerifyEventRequest,
        headers: dingtalkcontact__1__0_models.InitVerifyEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.InitVerifyEventResponse:
        """
        @summary 初始化核身事件
        
        @param request: InitVerifyEventRequest
        @param headers: InitVerifyEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitVerifyEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_device_id):
            body['callerDeviceId'] = request.caller_device_id
        if not UtilClient.is_unset(request.factor_code_list):
            body['factorCodeList'] = request.factor_code_list
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='InitVerifyEvent',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyEvents/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.InitVerifyEventResponse(),
            self.execute(params, req, runtime)
        )

    async def init_verify_event_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.InitVerifyEventRequest,
        headers: dingtalkcontact__1__0_models.InitVerifyEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.InitVerifyEventResponse:
        """
        @summary 初始化核身事件
        
        @param request: InitVerifyEventRequest
        @param headers: InitVerifyEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InitVerifyEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_device_id):
            body['callerDeviceId'] = request.caller_device_id
        if not UtilClient.is_unset(request.factor_code_list):
            body['factorCodeList'] = request.factor_code_list
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='InitVerifyEvent',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyEvents/init',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.InitVerifyEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def init_verify_event(
        self,
        request: dingtalkcontact__1__0_models.InitVerifyEventRequest,
    ) -> dingtalkcontact__1__0_models.InitVerifyEventResponse:
        """
        @summary 初始化核身事件
        
        @param request: InitVerifyEventRequest
        @return: InitVerifyEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.InitVerifyEventHeaders()
        return self.init_verify_event_with_options(request, headers, runtime)

    async def init_verify_event_async(
        self,
        request: dingtalkcontact__1__0_models.InitVerifyEventRequest,
    ) -> dingtalkcontact__1__0_models.InitVerifyEventResponse:
        """
        @summary 初始化核身事件
        
        @param request: InitVerifyEventRequest
        @return: InitVerifyEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.InitVerifyEventHeaders()
        return await self.init_verify_event_with_options_async(request, headers, runtime)

    def is_friend_with_options(
        self,
        request: dingtalkcontact__1__0_models.IsFriendRequest,
        headers: dingtalkcontact__1__0_models.IsFriendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.IsFriendResponse:
        """
        @summary 判断某用户跟给定专属账号是否存在好友关系
        
        @param request: IsFriendRequest
        @param headers: IsFriendHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsFriendResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_no):
            body['mobileNo'] = request.mobile_no
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
            action='IsFriend',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/relationships/friends/judge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.IsFriendResponse(),
            self.execute(params, req, runtime)
        )

    async def is_friend_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.IsFriendRequest,
        headers: dingtalkcontact__1__0_models.IsFriendHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.IsFriendResponse:
        """
        @summary 判断某用户跟给定专属账号是否存在好友关系
        
        @param request: IsFriendRequest
        @param headers: IsFriendHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsFriendResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mobile_no):
            body['mobileNo'] = request.mobile_no
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
            action='IsFriend',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/relationships/friends/judge',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.IsFriendResponse(),
            await self.execute_async(params, req, runtime)
        )

    def is_friend(
        self,
        request: dingtalkcontact__1__0_models.IsFriendRequest,
    ) -> dingtalkcontact__1__0_models.IsFriendResponse:
        """
        @summary 判断某用户跟给定专属账号是否存在好友关系
        
        @param request: IsFriendRequest
        @return: IsFriendResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.IsFriendHeaders()
        return self.is_friend_with_options(request, headers, runtime)

    async def is_friend_async(
        self,
        request: dingtalkcontact__1__0_models.IsFriendRequest,
    ) -> dingtalkcontact__1__0_models.IsFriendResponse:
        """
        @summary 判断某用户跟给定专属账号是否存在好友关系
        
        @param request: IsFriendRequest
        @return: IsFriendResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.IsFriendHeaders()
        return await self.is_friend_with_options_async(request, headers, runtime)

    def isv_card_event_push_with_options(
        self,
        request: dingtalkcontact__1__0_models.IsvCardEventPushRequest,
        headers: dingtalkcontact__1__0_models.IsvCardEventPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.IsvCardEventPushResponse:
        """
        @summary 名片事件推送
        
        @param request: IsvCardEventPushRequest
        @param headers: IsvCardEventPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvCardEventPushResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_card_id):
            query['isvCardId'] = request.isv_card_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.isv_uid):
            query['isvUid'] = request.isv_uid
        body = {}
        if not UtilClient.is_unset(request.event_params):
            body['eventParams'] = request.event_params
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='IsvCardEventPush',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.IsvCardEventPushResponse(),
            self.execute(params, req, runtime)
        )

    async def isv_card_event_push_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.IsvCardEventPushRequest,
        headers: dingtalkcontact__1__0_models.IsvCardEventPushHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.IsvCardEventPushResponse:
        """
        @summary 名片事件推送
        
        @param request: IsvCardEventPushRequest
        @param headers: IsvCardEventPushHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: IsvCardEventPushResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.isv_card_id):
            query['isvCardId'] = request.isv_card_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.isv_uid):
            query['isvUid'] = request.isv_uid
        body = {}
        if not UtilClient.is_unset(request.event_params):
            body['eventParams'] = request.event_params
        if not UtilClient.is_unset(request.event_type):
            body['eventType'] = request.event_type
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='IsvCardEventPush',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/events/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.IsvCardEventPushResponse(),
            await self.execute_async(params, req, runtime)
        )

    def isv_card_event_push(
        self,
        request: dingtalkcontact__1__0_models.IsvCardEventPushRequest,
    ) -> dingtalkcontact__1__0_models.IsvCardEventPushResponse:
        """
        @summary 名片事件推送
        
        @param request: IsvCardEventPushRequest
        @return: IsvCardEventPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.IsvCardEventPushHeaders()
        return self.isv_card_event_push_with_options(request, headers, runtime)

    async def isv_card_event_push_async(
        self,
        request: dingtalkcontact__1__0_models.IsvCardEventPushRequest,
    ) -> dingtalkcontact__1__0_models.IsvCardEventPushResponse:
        """
        @summary 名片事件推送
        
        @param request: IsvCardEventPushRequest
        @return: IsvCardEventPushResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.IsvCardEventPushHeaders()
        return await self.isv_card_event_push_with_options_async(request, headers, runtime)

    def list_basic_role_in_page_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListBasicRoleInPageRequest,
        headers: dingtalkcontact__1__0_models.ListBasicRoleInPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListBasicRoleInPageResponse:
        """
        @summary 拉取管理组基本信息列表分页接口
        
        @param request: ListBasicRoleInPageRequest
        @param headers: ListBasicRoleInPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListBasicRoleInPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
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
            action='ListBasicRoleInPage',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/rbac/administrativeGroups/baseInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListBasicRoleInPageResponse(),
            self.execute(params, req, runtime)
        )

    async def list_basic_role_in_page_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListBasicRoleInPageRequest,
        headers: dingtalkcontact__1__0_models.ListBasicRoleInPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListBasicRoleInPageResponse:
        """
        @summary 拉取管理组基本信息列表分页接口
        
        @param request: ListBasicRoleInPageRequest
        @param headers: ListBasicRoleInPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListBasicRoleInPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.agent_id):
            query['agentId'] = request.agent_id
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
            action='ListBasicRoleInPage',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/rbac/administrativeGroups/baseInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListBasicRoleInPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_basic_role_in_page(
        self,
        request: dingtalkcontact__1__0_models.ListBasicRoleInPageRequest,
    ) -> dingtalkcontact__1__0_models.ListBasicRoleInPageResponse:
        """
        @summary 拉取管理组基本信息列表分页接口
        
        @param request: ListBasicRoleInPageRequest
        @return: ListBasicRoleInPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListBasicRoleInPageHeaders()
        return self.list_basic_role_in_page_with_options(request, headers, runtime)

    async def list_basic_role_in_page_async(
        self,
        request: dingtalkcontact__1__0_models.ListBasicRoleInPageRequest,
    ) -> dingtalkcontact__1__0_models.ListBasicRoleInPageResponse:
        """
        @summary 拉取管理组基本信息列表分页接口
        
        @param request: ListBasicRoleInPageRequest
        @return: ListBasicRoleInPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListBasicRoleInPageHeaders()
        return await self.list_basic_role_in_page_with_options_async(request, headers, runtime)

    def list_contact_hide_settings_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListContactHideSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListContactHideSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListContactHideSettingsResponse:
        """
        @summary 获取通讯录隐藏设置
        
        @param request: ListContactHideSettingsRequest
        @param headers: ListContactHideSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListContactHideSettingsResponse
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
            action='ListContactHideSettings',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListContactHideSettingsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_contact_hide_settings_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListContactHideSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListContactHideSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListContactHideSettingsResponse:
        """
        @summary 获取通讯录隐藏设置
        
        @param request: ListContactHideSettingsRequest
        @param headers: ListContactHideSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListContactHideSettingsResponse
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
            action='ListContactHideSettings',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListContactHideSettingsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_contact_hide_settings(
        self,
        request: dingtalkcontact__1__0_models.ListContactHideSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListContactHideSettingsResponse:
        """
        @summary 获取通讯录隐藏设置
        
        @param request: ListContactHideSettingsRequest
        @return: ListContactHideSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListContactHideSettingsHeaders()
        return self.list_contact_hide_settings_with_options(request, headers, runtime)

    async def list_contact_hide_settings_async(
        self,
        request: dingtalkcontact__1__0_models.ListContactHideSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListContactHideSettingsResponse:
        """
        @summary 获取通讯录隐藏设置
        
        @param request: ListContactHideSettingsRequest
        @return: ListContactHideSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListContactHideSettingsHeaders()
        return await self.list_contact_hide_settings_with_options_async(request, headers, runtime)

    def list_contact_restrict_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListContactRestrictSettingRequest,
        headers: dingtalkcontact__1__0_models.ListContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListContactRestrictSettingResponse:
        """
        @summary 获取限制查看通讯录设置列表
        
        @param request: ListContactRestrictSettingRequest
        @param headers: ListContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListContactRestrictSettingResponse
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
            action='ListContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListContactRestrictSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def list_contact_restrict_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListContactRestrictSettingRequest,
        headers: dingtalkcontact__1__0_models.ListContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListContactRestrictSettingResponse:
        """
        @summary 获取限制查看通讯录设置列表
        
        @param request: ListContactRestrictSettingRequest
        @param headers: ListContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListContactRestrictSettingResponse
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
            action='ListContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListContactRestrictSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_contact_restrict_setting(
        self,
        request: dingtalkcontact__1__0_models.ListContactRestrictSettingRequest,
    ) -> dingtalkcontact__1__0_models.ListContactRestrictSettingResponse:
        """
        @summary 获取限制查看通讯录设置列表
        
        @param request: ListContactRestrictSettingRequest
        @return: ListContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListContactRestrictSettingHeaders()
        return self.list_contact_restrict_setting_with_options(request, headers, runtime)

    async def list_contact_restrict_setting_async(
        self,
        request: dingtalkcontact__1__0_models.ListContactRestrictSettingRequest,
    ) -> dingtalkcontact__1__0_models.ListContactRestrictSettingResponse:
        """
        @summary 获取限制查看通讯录设置列表
        
        @param request: ListContactRestrictSettingRequest
        @return: ListContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListContactRestrictSettingHeaders()
        return await self.list_contact_restrict_setting_with_options_async(request, headers, runtime)

    def list_emp_attribute_visibility_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
        headers: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        """
        @summary 获取员工字段可见性设置
        
        @param request: ListEmpAttributeVisibilityRequest
        @param headers: ListEmpAttributeVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListEmpAttributeVisibilityResponse
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
            action='ListEmpAttributeVisibility',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse(),
            self.execute(params, req, runtime)
        )

    async def list_emp_attribute_visibility_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
        headers: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        """
        @summary 获取员工字段可见性设置
        
        @param request: ListEmpAttributeVisibilityRequest
        @param headers: ListEmpAttributeVisibilityHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListEmpAttributeVisibilityResponse
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
            action='ListEmpAttributeVisibility',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_emp_attribute_visibility(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        """
        @summary 获取员工字段可见性设置
        
        @param request: ListEmpAttributeVisibilityRequest
        @return: ListEmpAttributeVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders()
        return self.list_emp_attribute_visibility_with_options(request, headers, runtime)

    async def list_emp_attribute_visibility_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpAttributeVisibilityRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpAttributeVisibilityResponse:
        """
        @summary 获取员工字段可见性设置
        
        @param request: ListEmpAttributeVisibilityRequest
        @return: ListEmpAttributeVisibilityResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpAttributeVisibilityHeaders()
        return await self.list_emp_attribute_visibility_with_options_async(request, headers, runtime)

    def list_emp_leave_records_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListEmpLeaveRecordsRequest,
        headers: dingtalkcontact__1__0_models.ListEmpLeaveRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse:
        """
        @summary 查询离职记录
        
        @param request: ListEmpLeaveRecordsRequest
        @param headers: ListEmpLeaveRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListEmpLeaveRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='ListEmpLeaveRecords',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empLeaveRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_emp_leave_records_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpLeaveRecordsRequest,
        headers: dingtalkcontact__1__0_models.ListEmpLeaveRecordsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse:
        """
        @summary 查询离职记录
        
        @param request: ListEmpLeaveRecordsRequest
        @param headers: ListEmpLeaveRecordsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListEmpLeaveRecordsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='ListEmpLeaveRecords',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empLeaveRecords',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_emp_leave_records(
        self,
        request: dingtalkcontact__1__0_models.ListEmpLeaveRecordsRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse:
        """
        @summary 查询离职记录
        
        @param request: ListEmpLeaveRecordsRequest
        @return: ListEmpLeaveRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpLeaveRecordsHeaders()
        return self.list_emp_leave_records_with_options(request, headers, runtime)

    async def list_emp_leave_records_async(
        self,
        request: dingtalkcontact__1__0_models.ListEmpLeaveRecordsRequest,
    ) -> dingtalkcontact__1__0_models.ListEmpLeaveRecordsResponse:
        """
        @summary 查询离职记录
        
        @param request: ListEmpLeaveRecordsRequest
        @return: ListEmpLeaveRecordsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListEmpLeaveRecordsHeaders()
        return await self.list_emp_leave_records_with_options_async(request, headers, runtime)

    def list_management_groups_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
        headers: dingtalkcontact__1__0_models.ListManagementGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        """
        @summary 分页查询管理组
        
        @param request: ListManagementGroupsRequest
        @param headers: ListManagementGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListManagementGroupsResponse
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
            action='ListManagementGroups',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListManagementGroupsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_management_groups_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
        headers: dingtalkcontact__1__0_models.ListManagementGroupsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        """
        @summary 分页查询管理组
        
        @param request: ListManagementGroupsRequest
        @param headers: ListManagementGroupsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListManagementGroupsResponse
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
            action='ListManagementGroups',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListManagementGroupsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_management_groups(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        """
        @summary 分页查询管理组
        
        @param request: ListManagementGroupsRequest
        @return: ListManagementGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListManagementGroupsHeaders()
        return self.list_management_groups_with_options(request, headers, runtime)

    async def list_management_groups_async(
        self,
        request: dingtalkcontact__1__0_models.ListManagementGroupsRequest,
    ) -> dingtalkcontact__1__0_models.ListManagementGroupsResponse:
        """
        @summary 分页查询管理组
        
        @param request: ListManagementGroupsRequest
        @return: ListManagementGroupsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListManagementGroupsHeaders()
        return await self.list_management_groups_with_options_async(request, headers, runtime)

    def list_owned_org_by_staff_id_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdRequest,
        headers: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse:
        """
        @summary 查询专属帐号拥有的组织(作为创建者的组织)
        
        @param request: ListOwnedOrgByStaffIdRequest
        @param headers: ListOwnedOrgByStaffIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOwnedOrgByStaffIdResponse
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
            action='ListOwnedOrgByStaffId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/ownedOrganizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse(),
            self.execute(params, req, runtime)
        )

    async def list_owned_org_by_staff_id_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdRequest,
        headers: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse:
        """
        @summary 查询专属帐号拥有的组织(作为创建者的组织)
        
        @param request: ListOwnedOrgByStaffIdRequest
        @param headers: ListOwnedOrgByStaffIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListOwnedOrgByStaffIdResponse
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
            action='ListOwnedOrgByStaffId',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/ownedOrganizations',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_owned_org_by_staff_id(
        self,
        request: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdRequest,
    ) -> dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse:
        """
        @summary 查询专属帐号拥有的组织(作为创建者的组织)
        
        @param request: ListOwnedOrgByStaffIdRequest
        @return: ListOwnedOrgByStaffIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdHeaders()
        return self.list_owned_org_by_staff_id_with_options(request, headers, runtime)

    async def list_owned_org_by_staff_id_async(
        self,
        request: dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdRequest,
    ) -> dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdResponse:
        """
        @summary 查询专属帐号拥有的组织(作为创建者的组织)
        
        @param request: ListOwnedOrgByStaffIdRequest
        @return: ListOwnedOrgByStaffIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListOwnedOrgByStaffIdHeaders()
        return await self.list_owned_org_by_staff_id_with_options_async(request, headers, runtime)

    def list_senior_settings_with_options(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListSeniorSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        """
        @summary 获取员工高管设置
        
        @param request: ListSeniorSettingsRequest
        @param headers: ListSeniorSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSeniorSettingsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            query['seniorStaffId'] = request.senior_staff_id
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
            action='ListSeniorSettings',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/seniorSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListSeniorSettingsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_senior_settings_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
        headers: dingtalkcontact__1__0_models.ListSeniorSettingsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        """
        @summary 获取员工高管设置
        
        @param request: ListSeniorSettingsRequest
        @param headers: ListSeniorSettingsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSeniorSettingsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.senior_staff_id):
            query['seniorStaffId'] = request.senior_staff_id
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
            action='ListSeniorSettings',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/seniorSettings',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ListSeniorSettingsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_senior_settings(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        """
        @summary 获取员工高管设置
        
        @param request: ListSeniorSettingsRequest
        @return: ListSeniorSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListSeniorSettingsHeaders()
        return self.list_senior_settings_with_options(request, headers, runtime)

    async def list_senior_settings_async(
        self,
        request: dingtalkcontact__1__0_models.ListSeniorSettingsRequest,
    ) -> dingtalkcontact__1__0_models.ListSeniorSettingsResponse:
        """
        @summary 获取员工高管设置
        
        @param request: ListSeniorSettingsRequest
        @return: ListSeniorSettingsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ListSeniorSettingsHeaders()
        return await self.list_senior_settings_with_options_async(request, headers, runtime)

    def modify_org_acc_user_ownness_with_options(
        self,
        request: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse:
        """
        @summary 更新企业账号工作状态
        
        @param request: ModifyOrgAccUserOwnnessRequest
        @param headers: ModifyOrgAccUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ModifyOrgAccUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            body['ownnessId'] = request.ownness_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ModifyOrgAccUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/owness',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse(),
            self.execute(params, req, runtime)
        )

    async def modify_org_acc_user_ownness_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse:
        """
        @summary 更新企业账号工作状态
        
        @param request: ModifyOrgAccUserOwnnessRequest
        @param headers: ModifyOrgAccUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ModifyOrgAccUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.user_id):
            query['userId'] = request.user_id
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
        if not UtilClient.is_unset(request.ownness_id):
            body['ownnessId'] = request.ownness_id
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.text):
            body['text'] = request.text
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            query=OpenApiUtilClient.query(query),
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ModifyOrgAccUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/owness',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def modify_org_acc_user_ownness(
        self,
        request: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse:
        """
        @summary 更新企业账号工作状态
        
        @param request: ModifyOrgAccUserOwnnessRequest
        @return: ModifyOrgAccUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessHeaders()
        return self.modify_org_acc_user_ownness_with_options(request, headers, runtime)

    async def modify_org_acc_user_ownness_async(
        self,
        request: dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessResponse:
        """
        @summary 更新企业账号工作状态
        
        @param request: ModifyOrgAccUserOwnnessRequest
        @return: ModifyOrgAccUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.ModifyOrgAccUserOwnnessHeaders()
        return await self.modify_org_acc_user_ownness_with_options_async(request, headers, runtime)

    def multi_org_permission_grant_with_options(
        self,
        request: dingtalkcontact__1__0_models.MultiOrgPermissionGrantRequest,
        headers: dingtalkcontact__1__0_models.MultiOrgPermissionGrantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse:
        """
        @summary 授权专属帐号可加入多组织
        
        @param request: MultiOrgPermissionGrantRequest
        @param headers: MultiOrgPermissionGrantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MultiOrgPermissionGrantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.grant_dept_id_list):
            body['grantDeptIdList'] = request.grant_dept_id_list
        if not UtilClient.is_unset(request.join_corp_id):
            body['joinCorpId'] = request.join_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='MultiOrgPermissionGrant',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/multiOrgPermissions/auth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse(),
            self.execute(params, req, runtime)
        )

    async def multi_org_permission_grant_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.MultiOrgPermissionGrantRequest,
        headers: dingtalkcontact__1__0_models.MultiOrgPermissionGrantHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse:
        """
        @summary 授权专属帐号可加入多组织
        
        @param request: MultiOrgPermissionGrantRequest
        @param headers: MultiOrgPermissionGrantHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MultiOrgPermissionGrantResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.grant_dept_id_list):
            body['grantDeptIdList'] = request.grant_dept_id_list
        if not UtilClient.is_unset(request.join_corp_id):
            body['joinCorpId'] = request.join_corp_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='MultiOrgPermissionGrant',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/multiOrgPermissions/auth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse(),
            await self.execute_async(params, req, runtime)
        )

    def multi_org_permission_grant(
        self,
        request: dingtalkcontact__1__0_models.MultiOrgPermissionGrantRequest,
    ) -> dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse:
        """
        @summary 授权专属帐号可加入多组织
        
        @param request: MultiOrgPermissionGrantRequest
        @return: MultiOrgPermissionGrantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.MultiOrgPermissionGrantHeaders()
        return self.multi_org_permission_grant_with_options(request, headers, runtime)

    async def multi_org_permission_grant_async(
        self,
        request: dingtalkcontact__1__0_models.MultiOrgPermissionGrantRequest,
    ) -> dingtalkcontact__1__0_models.MultiOrgPermissionGrantResponse:
        """
        @summary 授权专属帐号可加入多组织
        
        @param request: MultiOrgPermissionGrantRequest
        @return: MultiOrgPermissionGrantResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.MultiOrgPermissionGrantHeaders()
        return await self.multi_org_permission_grant_with_options_async(request, headers, runtime)

    def org_account_mobile_visible_in_other_org_with_options(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgRequest,
        headers: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse:
        """
        @summary 授权其他组织查看本组织的企业账号信息
        
        @param request: OrgAccountMobileVisibleInOtherOrgRequest
        @param headers: OrgAccountMobileVisibleInOtherOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrgAccountMobileVisibleInOtherOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.to_corp_ids):
            body['toCorpIds'] = request.to_corp_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OrgAccountMobileVisibleInOtherOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mobiles/visibleInOtherOrg',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def org_account_mobile_visible_in_other_org_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgRequest,
        headers: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse:
        """
        @summary 授权其他组织查看本组织的企业账号信息
        
        @param request: OrgAccountMobileVisibleInOtherOrgRequest
        @param headers: OrgAccountMobileVisibleInOtherOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrgAccountMobileVisibleInOtherOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.fields):
            body['fields'] = request.fields
        if not UtilClient.is_unset(request.opt_user_id):
            body['optUserId'] = request.opt_user_id
        if not UtilClient.is_unset(request.to_corp_ids):
            body['toCorpIds'] = request.to_corp_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OrgAccountMobileVisibleInOtherOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mobiles/visibleInOtherOrg',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def org_account_mobile_visible_in_other_org(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgRequest,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse:
        """
        @summary 授权其他组织查看本组织的企业账号信息
        
        @param request: OrgAccountMobileVisibleInOtherOrgRequest
        @return: OrgAccountMobileVisibleInOtherOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgHeaders()
        return self.org_account_mobile_visible_in_other_org_with_options(request, headers, runtime)

    async def org_account_mobile_visible_in_other_org_async(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgRequest,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgResponse:
        """
        @summary 授权其他组织查看本组织的企业账号信息
        
        @param request: OrgAccountMobileVisibleInOtherOrgRequest
        @return: OrgAccountMobileVisibleInOtherOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.OrgAccountMobileVisibleInOtherOrgHeaders()
        return await self.org_account_mobile_visible_in_other_org_with_options_async(request, headers, runtime)

    def org_account_mobile_visible_permisson_with_options(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonRequest,
        headers: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse:
        """
        @summary 更新企业账号电话可见性
        
        @param request: OrgAccountMobileVisiblePermissonRequest
        @param headers: OrgAccountMobileVisiblePermissonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrgAccountMobileVisiblePermissonResponse
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
            action='OrgAccountMobileVisiblePermisson',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mobiles/visiblePermissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse(),
            self.execute(params, req, runtime)
        )

    async def org_account_mobile_visible_permisson_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonRequest,
        headers: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse:
        """
        @summary 更新企业账号电话可见性
        
        @param request: OrgAccountMobileVisiblePermissonRequest
        @param headers: OrgAccountMobileVisiblePermissonHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: OrgAccountMobileVisiblePermissonResponse
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
            action='OrgAccountMobileVisiblePermisson',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/mobiles/visiblePermissions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse(),
            await self.execute_async(params, req, runtime)
        )

    def org_account_mobile_visible_permisson(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonRequest,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse:
        """
        @summary 更新企业账号电话可见性
        
        @param request: OrgAccountMobileVisiblePermissonRequest
        @return: OrgAccountMobileVisiblePermissonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonHeaders()
        return self.org_account_mobile_visible_permisson_with_options(request, headers, runtime)

    async def org_account_mobile_visible_permisson_async(
        self,
        request: dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonRequest,
    ) -> dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonResponse:
        """
        @summary 更新企业账号电话可见性
        
        @param request: OrgAccountMobileVisiblePermissonRequest
        @return: OrgAccountMobileVisiblePermissonResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.OrgAccountMobileVisiblePermissonHeaders()
        return await self.org_account_mobile_visible_permisson_with_options_async(request, headers, runtime)

    def push_verify_event_with_options(
        self,
        request: dingtalkcontact__1__0_models.PushVerifyEventRequest,
        headers: dingtalkcontact__1__0_models.PushVerifyEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.PushVerifyEventResponse:
        """
        @summary 给员工推送事件唤起核身组件
        
        @param request: PushVerifyEventRequest
        @param headers: PushVerifyEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushVerifyEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_device_id):
            body['callerDeviceId'] = request.caller_device_id
        if not UtilClient.is_unset(request.factor_code_list):
            body['factorCodeList'] = request.factor_code_list
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='PushVerifyEvent',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyEvents/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.PushVerifyEventResponse(),
            self.execute(params, req, runtime)
        )

    async def push_verify_event_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.PushVerifyEventRequest,
        headers: dingtalkcontact__1__0_models.PushVerifyEventHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.PushVerifyEventResponse:
        """
        @summary 给员工推送事件唤起核身组件
        
        @param request: PushVerifyEventRequest
        @param headers: PushVerifyEventHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PushVerifyEventResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.caller_device_id):
            body['callerDeviceId'] = request.caller_device_id
        if not UtilClient.is_unset(request.factor_code_list):
            body['factorCodeList'] = request.factor_code_list
        if not UtilClient.is_unset(request.state):
            body['state'] = request.state
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
            action='PushVerifyEvent',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyEvents/push',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.PushVerifyEventResponse(),
            await self.execute_async(params, req, runtime)
        )

    def push_verify_event(
        self,
        request: dingtalkcontact__1__0_models.PushVerifyEventRequest,
    ) -> dingtalkcontact__1__0_models.PushVerifyEventResponse:
        """
        @summary 给员工推送事件唤起核身组件
        
        @param request: PushVerifyEventRequest
        @return: PushVerifyEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.PushVerifyEventHeaders()
        return self.push_verify_event_with_options(request, headers, runtime)

    async def push_verify_event_async(
        self,
        request: dingtalkcontact__1__0_models.PushVerifyEventRequest,
    ) -> dingtalkcontact__1__0_models.PushVerifyEventResponse:
        """
        @summary 给员工推送事件唤起核身组件
        
        @param request: PushVerifyEventRequest
        @return: PushVerifyEventResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.PushVerifyEventHeaders()
        return await self.push_verify_event_with_options_async(request, headers, runtime)

    def query_card_visitor_statistic_data_with_options(
        self,
        request: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataRequest,
        headers: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse:
        """
        @summary 查询访客统计信息信息
        
        @param request: QueryCardVisitorStatisticDataRequest
        @param headers: QueryCardVisitorStatisticDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCardVisitorStatisticDataResponse
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
            action='QueryCardVisitorStatisticData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/visitors/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_card_visitor_statistic_data_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataRequest,
        headers: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse:
        """
        @summary 查询访客统计信息信息
        
        @param request: QueryCardVisitorStatisticDataRequest
        @param headers: QueryCardVisitorStatisticDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCardVisitorStatisticDataResponse
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
            action='QueryCardVisitorStatisticData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/visitors/statistics',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_card_visitor_statistic_data(
        self,
        request: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataRequest,
    ) -> dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse:
        """
        @summary 查询访客统计信息信息
        
        @param request: QueryCardVisitorStatisticDataRequest
        @return: QueryCardVisitorStatisticDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataHeaders()
        return self.query_card_visitor_statistic_data_with_options(request, headers, runtime)

    async def query_card_visitor_statistic_data_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataRequest,
    ) -> dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataResponse:
        """
        @summary 查询访客统计信息信息
        
        @param request: QueryCardVisitorStatisticDataRequest
        @return: QueryCardVisitorStatisticDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCardVisitorStatisticDataHeaders()
        return await self.query_card_visitor_statistic_data_with_options_async(request, headers, runtime)

    def query_corp_statistic_data_with_options(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpStatisticDataRequest,
        headers: dingtalkcontact__1__0_models.QueryCorpStatisticDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse:
        """
        @summary 查询企业模版的统计数据
        
        @param request: QueryCorpStatisticDataRequest
        @param headers: QueryCorpStatisticDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCorpStatisticDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_ids):
            body['templateIds'] = request.template_ids
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
            action='QueryCorpStatisticData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/templates/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse(),
            self.execute(params, req, runtime)
        )

    async def query_corp_statistic_data_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpStatisticDataRequest,
        headers: dingtalkcontact__1__0_models.QueryCorpStatisticDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse:
        """
        @summary 查询企业模版的统计数据
        
        @param request: QueryCorpStatisticDataRequest
        @param headers: QueryCorpStatisticDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCorpStatisticDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_ids):
            body['templateIds'] = request.template_ids
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
            action='QueryCorpStatisticData',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/templates/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_corp_statistic_data(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpStatisticDataRequest,
    ) -> dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse:
        """
        @summary 查询企业模版的统计数据
        
        @param request: QueryCorpStatisticDataRequest
        @return: QueryCorpStatisticDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCorpStatisticDataHeaders()
        return self.query_corp_statistic_data_with_options(request, headers, runtime)

    async def query_corp_statistic_data_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpStatisticDataRequest,
    ) -> dingtalkcontact__1__0_models.QueryCorpStatisticDataResponse:
        """
        @summary 查询企业模版的统计数据
        
        @param request: QueryCorpStatisticDataRequest
        @return: QueryCorpStatisticDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCorpStatisticDataHeaders()
        return await self.query_corp_statistic_data_with_options_async(request, headers, runtime)

    def query_corp_user_statistic_with_options(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpUserStatisticRequest,
        headers: dingtalkcontact__1__0_models.QueryCorpUserStatisticHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse:
        """
        @summary 查询企业用户名片统计数据
        
        @param request: QueryCorpUserStatisticRequest
        @param headers: QueryCorpUserStatisticHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCorpUserStatisticResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_ids):
            body['templateIds'] = request.template_ids
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
            action='QueryCorpUserStatistic',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/users/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse(),
            self.execute(params, req, runtime)
        )

    async def query_corp_user_statistic_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpUserStatisticRequest,
        headers: dingtalkcontact__1__0_models.QueryCorpUserStatisticHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse:
        """
        @summary 查询企业用户名片统计数据
        
        @param request: QueryCorpUserStatisticRequest
        @param headers: QueryCorpUserStatisticHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCorpUserStatisticResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.max_results):
            body['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            body['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.start_time):
            body['startTime'] = request.start_time
        if not UtilClient.is_unset(request.template_ids):
            body['templateIds'] = request.template_ids
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
            action='QueryCorpUserStatistic',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cards/users/statistics/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_corp_user_statistic(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpUserStatisticRequest,
    ) -> dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse:
        """
        @summary 查询企业用户名片统计数据
        
        @param request: QueryCorpUserStatisticRequest
        @return: QueryCorpUserStatisticResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCorpUserStatisticHeaders()
        return self.query_corp_user_statistic_with_options(request, headers, runtime)

    async def query_corp_user_statistic_async(
        self,
        request: dingtalkcontact__1__0_models.QueryCorpUserStatisticRequest,
    ) -> dingtalkcontact__1__0_models.QueryCorpUserStatisticResponse:
        """
        @summary 查询企业用户名片统计数据
        
        @param request: QueryCorpUserStatisticRequest
        @return: QueryCorpUserStatisticResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryCorpUserStatisticHeaders()
        return await self.query_corp_user_statistic_with_options_async(request, headers, runtime)

    def query_resource_management_members_with_options(
        self,
        resource_id: str,
        headers: dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        """
        @summary 查询可管理资源的成员
        
        @param headers: QueryResourceManagementMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryResourceManagementMembersResponse
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
            action='QueryResourceManagementMembers',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/resources/{resource_id}/managementMembers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def query_resource_management_members_with_options_async(
        self,
        resource_id: str,
        headers: dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        """
        @summary 查询可管理资源的成员
        
        @param headers: QueryResourceManagementMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryResourceManagementMembersResponse
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
            action='QueryResourceManagementMembers',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/resources/{resource_id}/managementMembers',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_resource_management_members(
        self,
        resource_id: str,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        """
        @summary 查询可管理资源的成员
        
        @return: QueryResourceManagementMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders()
        return self.query_resource_management_members_with_options(resource_id, headers, runtime)

    async def query_resource_management_members_async(
        self,
        resource_id: str,
    ) -> dingtalkcontact__1__0_models.QueryResourceManagementMembersResponse:
        """
        @summary 查询可管理资源的成员
        
        @return: QueryResourceManagementMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryResourceManagementMembersHeaders()
        return await self.query_resource_management_members_with_options_async(resource_id, headers, runtime)

    def query_status_with_options(
        self,
        request: dingtalkcontact__1__0_models.QueryStatusRequest,
        headers: dingtalkcontact__1__0_models.QueryStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryStatusResponse:
        """
        @summary 查询专属帐号状态
        
        @param request: QueryStatusRequest
        @param headers: QueryStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStatusResponse
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
            action='QueryStatus',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/status',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def query_status_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.QueryStatusRequest,
        headers: dingtalkcontact__1__0_models.QueryStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryStatusResponse:
        """
        @summary 查询专属帐号状态
        
        @param request: QueryStatusRequest
        @param headers: QueryStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryStatusResponse
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
            action='QueryStatus',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/status',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_status(
        self,
        request: dingtalkcontact__1__0_models.QueryStatusRequest,
    ) -> dingtalkcontact__1__0_models.QueryStatusResponse:
        """
        @summary 查询专属帐号状态
        
        @param request: QueryStatusRequest
        @return: QueryStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryStatusHeaders()
        return self.query_status_with_options(request, headers, runtime)

    async def query_status_async(
        self,
        request: dingtalkcontact__1__0_models.QueryStatusRequest,
    ) -> dingtalkcontact__1__0_models.QueryStatusResponse:
        """
        @summary 查询专属帐号状态
        
        @param request: QueryStatusRequest
        @return: QueryStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryStatusHeaders()
        return await self.query_status_with_options_async(request, headers, runtime)

    def query_user_management_resources_with_options(
        self,
        user_id: str,
        headers: dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        """
        @summary 查询用户可以管理的资源
        
        @param headers: QueryUserManagementResourcesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserManagementResourcesResponse
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
            action='QueryUserManagementResources',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/{user_id}/managemementResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse(),
            self.execute(params, req, runtime)
        )

    async def query_user_management_resources_with_options_async(
        self,
        user_id: str,
        headers: dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        """
        @summary 查询用户可以管理的资源
        
        @param headers: QueryUserManagementResourcesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryUserManagementResourcesResponse
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
            action='QueryUserManagementResources',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/{user_id}/managemementResources',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_user_management_resources(
        self,
        user_id: str,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        """
        @summary 查询用户可以管理的资源
        
        @return: QueryUserManagementResourcesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders()
        return self.query_user_management_resources_with_options(user_id, headers, runtime)

    async def query_user_management_resources_async(
        self,
        user_id: str,
    ) -> dingtalkcontact__1__0_models.QueryUserManagementResourcesResponse:
        """
        @summary 查询用户可以管理的资源
        
        @return: QueryUserManagementResourcesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryUserManagementResourcesHeaders()
        return await self.query_user_management_resources_with_options_async(user_id, headers, runtime)

    def query_verify_result_with_options(
        self,
        request: dingtalkcontact__1__0_models.QueryVerifyResultRequest,
        headers: dingtalkcontact__1__0_models.QueryVerifyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryVerifyResultResponse:
        """
        @summary 读取员工核身结果
        
        @param request: QueryVerifyResultRequest
        @param headers: QueryVerifyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVerifyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.verify_id):
            query['verifyId'] = request.verify_id
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
            action='QueryVerifyResult',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryVerifyResultResponse(),
            self.execute(params, req, runtime)
        )

    async def query_verify_result_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.QueryVerifyResultRequest,
        headers: dingtalkcontact__1__0_models.QueryVerifyResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.QueryVerifyResultResponse:
        """
        @summary 读取员工核身结果
        
        @param request: QueryVerifyResultRequest
        @param headers: QueryVerifyResultHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryVerifyResultResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.verify_id):
            query['verifyId'] = request.verify_id
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
            action='QueryVerifyResult',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/verifyIdentities/verifyResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.QueryVerifyResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_verify_result(
        self,
        request: dingtalkcontact__1__0_models.QueryVerifyResultRequest,
    ) -> dingtalkcontact__1__0_models.QueryVerifyResultResponse:
        """
        @summary 读取员工核身结果
        
        @param request: QueryVerifyResultRequest
        @return: QueryVerifyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryVerifyResultHeaders()
        return self.query_verify_result_with_options(request, headers, runtime)

    async def query_verify_result_async(
        self,
        request: dingtalkcontact__1__0_models.QueryVerifyResultRequest,
    ) -> dingtalkcontact__1__0_models.QueryVerifyResultResponse:
        """
        @summary 读取员工核身结果
        
        @param request: QueryVerifyResultRequest
        @return: QueryVerifyResultResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.QueryVerifyResultHeaders()
        return await self.query_verify_result_with_options_async(request, headers, runtime)

    def search_department_with_options(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
        headers: dingtalkcontact__1__0_models.SearchDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        """
        @summary 搜索部门
        
        @param request: SearchDepartmentRequest
        @param headers: SearchDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchDepartmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
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
            action='SearchDepartment',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/departments/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SearchDepartmentResponse(),
            self.execute(params, req, runtime)
        )

    async def search_department_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
        headers: dingtalkcontact__1__0_models.SearchDepartmentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        """
        @summary 搜索部门
        
        @param request: SearchDepartmentRequest
        @param headers: SearchDepartmentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchDepartmentResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
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
            action='SearchDepartment',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/departments/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SearchDepartmentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_department(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        """
        @summary 搜索部门
        
        @param request: SearchDepartmentRequest
        @return: SearchDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchDepartmentHeaders()
        return self.search_department_with_options(request, headers, runtime)

    async def search_department_async(
        self,
        request: dingtalkcontact__1__0_models.SearchDepartmentRequest,
    ) -> dingtalkcontact__1__0_models.SearchDepartmentResponse:
        """
        @summary 搜索部门
        
        @param request: SearchDepartmentRequest
        @return: SearchDepartmentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchDepartmentHeaders()
        return await self.search_department_with_options_async(request, headers, runtime)

    def search_user_with_options(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
        headers: dingtalkcontact__1__0_models.SearchUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        """
        @summary 搜索用户
        
        @param request: SearchUserRequest
        @param headers: SearchUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.full_match_field):
            body['fullMatchField'] = request.full_match_field
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
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
            action='SearchUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SearchUserResponse(),
            self.execute(params, req, runtime)
        )

    async def search_user_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
        headers: dingtalkcontact__1__0_models.SearchUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        """
        @summary 搜索用户
        
        @param request: SearchUserRequest
        @param headers: SearchUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.full_match_field):
            body['fullMatchField'] = request.full_match_field
        if not UtilClient.is_unset(request.offset):
            body['offset'] = request.offset
        if not UtilClient.is_unset(request.query_word):
            body['queryWord'] = request.query_word
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
            action='SearchUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SearchUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_user(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        """
        @summary 搜索用户
        
        @param request: SearchUserRequest
        @return: SearchUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchUserHeaders()
        return self.search_user_with_options(request, headers, runtime)

    async def search_user_async(
        self,
        request: dingtalkcontact__1__0_models.SearchUserRequest,
    ) -> dingtalkcontact__1__0_models.SearchUserResponse:
        """
        @summary 搜索用户
        
        @param request: SearchUserRequest
        @return: SearchUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SearchUserHeaders()
        return await self.search_user_with_options_async(request, headers, runtime)

    def separate_branch_org_with_options(
        self,
        request: dingtalkcontact__1__0_models.SeparateBranchOrgRequest,
        headers: dingtalkcontact__1__0_models.SeparateBranchOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SeparateBranchOrgResponse:
        """
        @summary 解除关联组织
        
        @param request: SeparateBranchOrgRequest
        @param headers: SeparateBranchOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SeparateBranchOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attach_dept_id):
            body['attachDeptId'] = request.attach_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SeparateBranchOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/separate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SeparateBranchOrgResponse(),
            self.execute(params, req, runtime)
        )

    async def separate_branch_org_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SeparateBranchOrgRequest,
        headers: dingtalkcontact__1__0_models.SeparateBranchOrgHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SeparateBranchOrgResponse:
        """
        @summary 解除关联组织
        
        @param request: SeparateBranchOrgRequest
        @param headers: SeparateBranchOrgHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SeparateBranchOrgResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.attach_dept_id):
            body['attachDeptId'] = request.attach_dept_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SeparateBranchOrg',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/separate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SeparateBranchOrgResponse(),
            await self.execute_async(params, req, runtime)
        )

    def separate_branch_org(
        self,
        request: dingtalkcontact__1__0_models.SeparateBranchOrgRequest,
    ) -> dingtalkcontact__1__0_models.SeparateBranchOrgResponse:
        """
        @summary 解除关联组织
        
        @param request: SeparateBranchOrgRequest
        @return: SeparateBranchOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SeparateBranchOrgHeaders()
        return self.separate_branch_org_with_options(request, headers, runtime)

    async def separate_branch_org_async(
        self,
        request: dingtalkcontact__1__0_models.SeparateBranchOrgRequest,
    ) -> dingtalkcontact__1__0_models.SeparateBranchOrgResponse:
        """
        @summary 解除关联组织
        
        @param request: SeparateBranchOrgRequest
        @return: SeparateBranchOrgResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SeparateBranchOrgHeaders()
        return await self.separate_branch_org_with_options_async(request, headers, runtime)

    def set_disable_with_options(
        self,
        request: dingtalkcontact__1__0_models.SetDisableRequest,
        headers: dingtalkcontact__1__0_models.SetDisableHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SetDisableResponse:
        """
        @summary 停用专属帐号
        
        @param request: SetDisableRequest
        @param headers: SetDisableHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDisableResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
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
            action='SetDisable',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/disable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SetDisableResponse(),
            self.execute(params, req, runtime)
        )

    async def set_disable_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SetDisableRequest,
        headers: dingtalkcontact__1__0_models.SetDisableHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SetDisableResponse:
        """
        @summary 停用专属帐号
        
        @param request: SetDisableRequest
        @param headers: SetDisableHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetDisableResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
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
            action='SetDisable',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/disable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SetDisableResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_disable(
        self,
        request: dingtalkcontact__1__0_models.SetDisableRequest,
    ) -> dingtalkcontact__1__0_models.SetDisableResponse:
        """
        @summary 停用专属帐号
        
        @param request: SetDisableRequest
        @return: SetDisableResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SetDisableHeaders()
        return self.set_disable_with_options(request, headers, runtime)

    async def set_disable_async(
        self,
        request: dingtalkcontact__1__0_models.SetDisableRequest,
    ) -> dingtalkcontact__1__0_models.SetDisableResponse:
        """
        @summary 停用专属帐号
        
        @param request: SetDisableRequest
        @return: SetDisableResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SetDisableHeaders()
        return await self.set_disable_with_options_async(request, headers, runtime)

    def set_enable_with_options(
        self,
        request: dingtalkcontact__1__0_models.SetEnableRequest,
        headers: dingtalkcontact__1__0_models.SetEnableHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SetEnableResponse:
        """
        @summary 启用专属帐号
        
        @param request: SetEnableRequest
        @param headers: SetEnableHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetEnableResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='SetEnable',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/enable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SetEnableResponse(),
            self.execute(params, req, runtime)
        )

    async def set_enable_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SetEnableRequest,
        headers: dingtalkcontact__1__0_models.SetEnableHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SetEnableResponse:
        """
        @summary 启用专属帐号
        
        @param request: SetEnableRequest
        @param headers: SetEnableHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SetEnableResponse
        """
        UtilClient.validate_model(request)
        body = {}
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
            action='SetEnable',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/enable',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SetEnableResponse(),
            await self.execute_async(params, req, runtime)
        )

    def set_enable(
        self,
        request: dingtalkcontact__1__0_models.SetEnableRequest,
    ) -> dingtalkcontact__1__0_models.SetEnableResponse:
        """
        @summary 启用专属帐号
        
        @param request: SetEnableRequest
        @return: SetEnableResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SetEnableHeaders()
        return self.set_enable_with_options(request, headers, runtime)

    async def set_enable_async(
        self,
        request: dingtalkcontact__1__0_models.SetEnableRequest,
    ) -> dingtalkcontact__1__0_models.SetEnableResponse:
        """
        @summary 启用专属帐号
        
        @param request: SetEnableRequest
        @return: SetEnableResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SetEnableHeaders()
        return await self.set_enable_with_options_async(request, headers, runtime)

    def sign_out_with_options(
        self,
        request: dingtalkcontact__1__0_models.SignOutRequest,
        headers: dingtalkcontact__1__0_models.SignOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SignOutResponse:
        """
        @summary 强制登出专属帐号
        
        @param request: SignOutRequest
        @param headers: SignOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SignOutResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
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
            action='SignOut',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/signOut',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SignOutResponse(),
            self.execute(params, req, runtime)
        )

    async def sign_out_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SignOutRequest,
        headers: dingtalkcontact__1__0_models.SignOutHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SignOutResponse:
        """
        @summary 强制登出专属帐号
        
        @param request: SignOutRequest
        @param headers: SignOutHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SignOutResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.reason):
            body['reason'] = request.reason
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
            action='SignOut',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccounts/signOut',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SignOutResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sign_out(
        self,
        request: dingtalkcontact__1__0_models.SignOutRequest,
    ) -> dingtalkcontact__1__0_models.SignOutResponse:
        """
        @summary 强制登出专属帐号
        
        @param request: SignOutRequest
        @return: SignOutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SignOutHeaders()
        return self.sign_out_with_options(request, headers, runtime)

    async def sign_out_async(
        self,
        request: dingtalkcontact__1__0_models.SignOutRequest,
    ) -> dingtalkcontact__1__0_models.SignOutResponse:
        """
        @summary 强制登出专属帐号
        
        @param request: SignOutRequest
        @return: SignOutResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SignOutHeaders()
        return await self.sign_out_with_options_async(request, headers, runtime)

    def sort_user_with_options(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
        headers: dingtalkcontact__1__0_models.SortUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        """
        @summary 根据用户名排序
        
        @param request: SortUserRequest
        @param headers: SortUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SortUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_type):
            body['sortType'] = request.sort_type
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
            action='SortUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/sort',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SortUserResponse(),
            self.execute(params, req, runtime)
        )

    async def sort_user_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
        headers: dingtalkcontact__1__0_models.SortUserHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        """
        @summary 根据用户名排序
        
        @param request: SortUserRequest
        @param headers: SortUserHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SortUserResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_type):
            body['sortType'] = request.sort_type
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
            action='SortUser',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/users/sort',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.SortUserResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sort_user(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        """
        @summary 根据用户名排序
        
        @param request: SortUserRequest
        @return: SortUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SortUserHeaders()
        return self.sort_user_with_options(request, headers, runtime)

    async def sort_user_async(
        self,
        request: dingtalkcontact__1__0_models.SortUserRequest,
    ) -> dingtalkcontact__1__0_models.SortUserResponse:
        """
        @summary 根据用户名排序
        
        @param request: SortUserRequest
        @return: SortUserResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.SortUserHeaders()
        return await self.sort_user_with_options_async(request, headers, runtime)

    def transform_to_exclusive_account_with_options(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
        headers: dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        """
        @summary 普通帐号转换为专属帐号
        
        @param request: TransformToExclusiveAccountRequest
        @param headers: TransformToExclusiveAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransformToExclusiveAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.idp_ding_talk):
            body['idpDingTalk'] = request.idp_ding_talk
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.login_id):
            body['loginId'] = request.login_id
        if not UtilClient.is_unset(request.transform_type):
            body['transformType'] = request.transform_type
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
            action='TransformToExclusiveAccount',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/transformToExclusiveAccounts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse(),
            self.execute(params, req, runtime)
        )

    async def transform_to_exclusive_account_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
        headers: dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        """
        @summary 普通帐号转换为专属帐号
        
        @param request: TransformToExclusiveAccountRequest
        @param headers: TransformToExclusiveAccountHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TransformToExclusiveAccountResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.idp_ding_talk):
            body['idpDingTalk'] = request.idp_ding_talk
        if not UtilClient.is_unset(request.init_password):
            body['initPassword'] = request.init_password
        if not UtilClient.is_unset(request.login_id):
            body['loginId'] = request.login_id
        if not UtilClient.is_unset(request.transform_type):
            body['transformType'] = request.transform_type
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
            action='TransformToExclusiveAccount',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/orgAccount/transformToExclusiveAccounts',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse(),
            await self.execute_async(params, req, runtime)
        )

    def transform_to_exclusive_account(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        """
        @summary 普通帐号转换为专属帐号
        
        @param request: TransformToExclusiveAccountRequest
        @return: TransformToExclusiveAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders()
        return self.transform_to_exclusive_account_with_options(request, headers, runtime)

    async def transform_to_exclusive_account_async(
        self,
        request: dingtalkcontact__1__0_models.TransformToExclusiveAccountRequest,
    ) -> dingtalkcontact__1__0_models.TransformToExclusiveAccountResponse:
        """
        @summary 普通帐号转换为专属帐号
        
        @param request: TransformToExclusiveAccountRequest
        @return: TransformToExclusiveAccountResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TransformToExclusiveAccountHeaders()
        return await self.transform_to_exclusive_account_with_options_async(request, headers, runtime)

    def translate_file_with_options(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
        headers: dingtalkcontact__1__0_models.TranslateFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        """
        @summary 异步文件内容转译
        
        @param request: TranslateFileRequest
        @param headers: TranslateFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TranslateFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.medias):
            body['medias'] = request.medias
        if not UtilClient.is_unset(request.output_file_name):
            body['outputFileName'] = request.output_file_name
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
            action='TranslateFile',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/files/translate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.TranslateFileResponse(),
            self.execute(params, req, runtime)
        )

    async def translate_file_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
        headers: dingtalkcontact__1__0_models.TranslateFileHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        """
        @summary 异步文件内容转译
        
        @param request: TranslateFileRequest
        @param headers: TranslateFileHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TranslateFileResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.medias):
            body['medias'] = request.medias
        if not UtilClient.is_unset(request.output_file_name):
            body['outputFileName'] = request.output_file_name
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
            action='TranslateFile',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/files/translate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.TranslateFileResponse(),
            await self.execute_async(params, req, runtime)
        )

    def translate_file(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        """
        @summary 异步文件内容转译
        
        @param request: TranslateFileRequest
        @return: TranslateFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TranslateFileHeaders()
        return self.translate_file_with_options(request, headers, runtime)

    async def translate_file_async(
        self,
        request: dingtalkcontact__1__0_models.TranslateFileRequest,
    ) -> dingtalkcontact__1__0_models.TranslateFileResponse:
        """
        @summary 异步文件内容转译
        
        @param request: TranslateFileRequest
        @return: TranslateFileResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.TranslateFileHeaders()
        return await self.translate_file_with_options_async(request, headers, runtime)

    def unique_query_user_card_with_options(
        self,
        request: dingtalkcontact__1__0_models.UniqueQueryUserCardRequest,
        headers: dingtalkcontact__1__0_models.UniqueQueryUserCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UniqueQueryUserCardResponse:
        """
        @summary 唯一查询用户名片
        
        @param request: UniqueQueryUserCardRequest
        @param headers: UniqueQueryUserCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UniqueQueryUserCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='UniqueQueryUserCard',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/uniques/cards',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UniqueQueryUserCardResponse(),
            self.execute(params, req, runtime)
        )

    async def unique_query_user_card_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UniqueQueryUserCardRequest,
        headers: dingtalkcontact__1__0_models.UniqueQueryUserCardHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UniqueQueryUserCardResponse:
        """
        @summary 唯一查询用户名片
        
        @param request: UniqueQueryUserCardRequest
        @param headers: UniqueQueryUserCardHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UniqueQueryUserCardResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.template_id):
            query['templateId'] = request.template_id
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
            action='UniqueQueryUserCard',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/uniques/cards',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UniqueQueryUserCardResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unique_query_user_card(
        self,
        request: dingtalkcontact__1__0_models.UniqueQueryUserCardRequest,
    ) -> dingtalkcontact__1__0_models.UniqueQueryUserCardResponse:
        """
        @summary 唯一查询用户名片
        
        @param request: UniqueQueryUserCardRequest
        @return: UniqueQueryUserCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UniqueQueryUserCardHeaders()
        return self.unique_query_user_card_with_options(request, headers, runtime)

    async def unique_query_user_card_async(
        self,
        request: dingtalkcontact__1__0_models.UniqueQueryUserCardRequest,
    ) -> dingtalkcontact__1__0_models.UniqueQueryUserCardResponse:
        """
        @summary 唯一查询用户名片
        
        @param request: UniqueQueryUserCardRequest
        @return: UniqueQueryUserCardResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UniqueQueryUserCardHeaders()
        return await self.unique_query_user_card_with_options_async(request, headers, runtime)

    def update_branch_attributes_in_cooperate_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateRequest,
        headers: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse:
        """
        @summary 更新(分支/伙伴)在(集团/合作空间)的属性信息
        
        @param request: UpdateBranchAttributesInCooperateRequest
        @param headers: UpdateBranchAttributesInCooperateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBranchAttributesInCooperateResponse
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
            action='UpdateBranchAttributesInCooperate',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/branchAttributes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_branch_attributes_in_cooperate_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateRequest,
        headers: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse:
        """
        @summary 更新(分支/伙伴)在(集团/合作空间)的属性信息
        
        @param request: UpdateBranchAttributesInCooperateRequest
        @param headers: UpdateBranchAttributesInCooperateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBranchAttributesInCooperateResponse
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
            action='UpdateBranchAttributesInCooperate',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/branchAttributes',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_branch_attributes_in_cooperate(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateRequest,
    ) -> dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse:
        """
        @summary 更新(分支/伙伴)在(集团/合作空间)的属性信息
        
        @param request: UpdateBranchAttributesInCooperateRequest
        @return: UpdateBranchAttributesInCooperateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateHeaders()
        return self.update_branch_attributes_in_cooperate_with_options(request, headers, runtime)

    async def update_branch_attributes_in_cooperate_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateRequest,
    ) -> dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateResponse:
        """
        @summary 更新(分支/伙伴)在(集团/合作空间)的属性信息
        
        @param request: UpdateBranchAttributesInCooperateRequest
        @return: UpdateBranchAttributesInCooperateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateBranchAttributesInCooperateHeaders()
        return await self.update_branch_attributes_in_cooperate_with_options_async(request, headers, runtime)

    def update_branch_visible_setting_in_cooperate_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateRequest,
        headers: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse:
        """
        @summary 设置(分支/伙伴)在(集团/合作空间)的可见范围
        
        @param request: UpdateBranchVisibleSettingInCooperateRequest
        @param headers: UpdateBranchVisibleSettingInCooperateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBranchVisibleSettingInCooperateResponse
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
            action='UpdateBranchVisibleSettingInCooperate',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/branchVisibleSettings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse(),
            self.execute(params, req, runtime)
        )

    async def update_branch_visible_setting_in_cooperate_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateRequest,
        headers: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse:
        """
        @summary 设置(分支/伙伴)在(集团/合作空间)的可见范围
        
        @param request: UpdateBranchVisibleSettingInCooperateRequest
        @param headers: UpdateBranchVisibleSettingInCooperateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateBranchVisibleSettingInCooperateResponse
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
            action='UpdateBranchVisibleSettingInCooperate',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/cooperateCorps/branchVisibleSettings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_branch_visible_setting_in_cooperate(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateRequest,
    ) -> dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse:
        """
        @summary 设置(分支/伙伴)在(集团/合作空间)的可见范围
        
        @param request: UpdateBranchVisibleSettingInCooperateRequest
        @return: UpdateBranchVisibleSettingInCooperateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateHeaders()
        return self.update_branch_visible_setting_in_cooperate_with_options(request, headers, runtime)

    async def update_branch_visible_setting_in_cooperate_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateRequest,
    ) -> dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateResponse:
        """
        @summary 设置(分支/伙伴)在(集团/合作空间)的可见范围
        
        @param request: UpdateBranchVisibleSettingInCooperateRequest
        @return: UpdateBranchVisibleSettingInCooperateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateBranchVisibleSettingInCooperateHeaders()
        return await self.update_branch_visible_setting_in_cooperate_with_options_async(request, headers, runtime)

    def update_contact_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse:
        """
        @summary 更新通讯录组织架构隐藏设置
        
        @param request: UpdateContactHideBySceneSettingRequest
        @param headers: UpdateContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.node_list_scene_config):
            body['nodeListSceneConfig'] = request.node_list_scene_config
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_contact_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse:
        """
        @summary 更新通讯录组织架构隐藏设置
        
        @param request: UpdateContactHideBySceneSettingRequest
        @param headers: UpdateContactHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.node_list_scene_config):
            body['nodeListSceneConfig'] = request.node_list_scene_config
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateContactHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/organizations/hides/settings/{setting_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_contact_hide_by_scene_setting(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse:
        """
        @summary 更新通讯录组织架构隐藏设置
        
        @param request: UpdateContactHideBySceneSettingRequest
        @return: UpdateContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingHeaders()
        return self.update_contact_hide_by_scene_setting_with_options(setting_id, request, headers, runtime)

    async def update_contact_hide_by_scene_setting_async(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingResponse:
        """
        @summary 更新通讯录组织架构隐藏设置
        
        @param request: UpdateContactHideBySceneSettingRequest
        @return: UpdateContactHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactHideBySceneSettingHeaders()
        return await self.update_contact_hide_by_scene_setting_with_options_async(setting_id, request, headers, runtime)

    def update_contact_hide_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactHideSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactHideSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideSettingResponse:
        """
        @summary 更新通讯录隐藏设置
        
        @param request: UpdateContactHideSettingRequest
        @param headers: UpdateContactHideSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactHideSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.hide_in_search):
            body['hideInSearch'] = request.hide_in_search
        if not UtilClient.is_unset(request.hide_in_user_profile):
            body['hideInUserProfile'] = request.hide_in_user_profile
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateContactHideSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactHideSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_contact_hide_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactHideSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactHideSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideSettingResponse:
        """
        @summary 更新通讯录隐藏设置
        
        @param request: UpdateContactHideSettingRequest
        @param headers: UpdateContactHideSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactHideSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.hide_in_search):
            body['hideInSearch'] = request.hide_in_search
        if not UtilClient.is_unset(request.hide_in_user_profile):
            body['hideInUserProfile'] = request.hide_in_user_profile
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateContactHideSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/contactHideSettings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactHideSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_contact_hide_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactHideSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideSettingResponse:
        """
        @summary 更新通讯录隐藏设置
        
        @param request: UpdateContactHideSettingRequest
        @return: UpdateContactHideSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactHideSettingHeaders()
        return self.update_contact_hide_setting_with_options(request, headers, runtime)

    async def update_contact_hide_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactHideSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactHideSettingResponse:
        """
        @summary 更新通讯录隐藏设置
        
        @param request: UpdateContactHideSettingRequest
        @return: UpdateContactHideSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactHideSettingHeaders()
        return await self.update_contact_hide_setting_with_options_async(request, headers, runtime)

    def update_contact_restrict_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactRestrictSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse:
        """
        @summary 新增或修改限制查看通讯录设置
        
        @param request: UpdateContactRestrictSettingRequest
        @param headers: UpdateContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactRestrictSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.restrict_in_search):
            body['restrictInSearch'] = request.restrict_in_search
        if not UtilClient.is_unset(request.restrict_in_user_profile):
            body['restrictInUserProfile'] = request.restrict_in_user_profile
        if not UtilClient.is_unset(request.subject_dept_ids):
            body['subjectDeptIds'] = request.subject_dept_ids
        if not UtilClient.is_unset(request.subject_tag_ids):
            body['subjectTagIds'] = request.subject_tag_ids
        if not UtilClient.is_unset(request.subject_user_ids):
            body['subjectUserIds'] = request.subject_user_ids
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
            action='UpdateContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_contact_restrict_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactRestrictSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateContactRestrictSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse:
        """
        @summary 新增或修改限制查看通讯录设置
        
        @param request: UpdateContactRestrictSettingRequest
        @param headers: UpdateContactRestrictSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateContactRestrictSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.restrict_in_search):
            body['restrictInSearch'] = request.restrict_in_search
        if not UtilClient.is_unset(request.restrict_in_user_profile):
            body['restrictInUserProfile'] = request.restrict_in_user_profile
        if not UtilClient.is_unset(request.subject_dept_ids):
            body['subjectDeptIds'] = request.subject_dept_ids
        if not UtilClient.is_unset(request.subject_tag_ids):
            body['subjectTagIds'] = request.subject_tag_ids
        if not UtilClient.is_unset(request.subject_user_ids):
            body['subjectUserIds'] = request.subject_user_ids
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
            action='UpdateContactRestrictSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/restrictions/settings',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_contact_restrict_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactRestrictSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse:
        """
        @summary 新增或修改限制查看通讯录设置
        
        @param request: UpdateContactRestrictSettingRequest
        @return: UpdateContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactRestrictSettingHeaders()
        return self.update_contact_restrict_setting_with_options(request, headers, runtime)

    async def update_contact_restrict_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateContactRestrictSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateContactRestrictSettingResponse:
        """
        @summary 新增或修改限制查看通讯录设置
        
        @param request: UpdateContactRestrictSettingRequest
        @return: UpdateContactRestrictSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateContactRestrictSettingHeaders()
        return await self.update_contact_restrict_setting_with_options_async(request, headers, runtime)

    def update_dept_settng_tail_first_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstRequest,
        headers: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse:
        """
        @summary 通讯录可见性部门设置子部门设置优先
        
        @param request: UpdateDeptSettngTailFirstRequest
        @param headers: UpdateDeptSettngTailFirstHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateDeptSettngTailFirstResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable):
            body['enable'] = request.enable
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateDeptSettngTailFirst',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/depts/settings/priorities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse(),
            self.execute(params, req, runtime)
        )

    async def update_dept_settng_tail_first_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstRequest,
        headers: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse:
        """
        @summary 通讯录可见性部门设置子部门设置优先
        
        @param request: UpdateDeptSettngTailFirstRequest
        @param headers: UpdateDeptSettngTailFirstHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateDeptSettngTailFirstResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.enable):
            body['enable'] = request.enable
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateDeptSettngTailFirst',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/depts/settings/priorities',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='formData',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_dept_settng_tail_first(
        self,
        request: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstRequest,
    ) -> dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse:
        """
        @summary 通讯录可见性部门设置子部门设置优先
        
        @param request: UpdateDeptSettngTailFirstRequest
        @return: UpdateDeptSettngTailFirstResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstHeaders()
        return self.update_dept_settng_tail_first_with_options(request, headers, runtime)

    async def update_dept_settng_tail_first_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstRequest,
    ) -> dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstResponse:
        """
        @summary 通讯录可见性部门设置子部门设置优先
        
        @param request: UpdateDeptSettngTailFirstRequest
        @return: UpdateDeptSettngTailFirstResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateDeptSettngTailFirstHeaders()
        return await self.update_dept_settng_tail_first_with_options_async(request, headers, runtime)

    def update_emp_attrbute_visibility_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        """
        @summary 更新企业员工属性字段可见性设置
        
        @param request: UpdateEmpAttrbuteVisibilitySettingRequest
        @param headers: UpdateEmpAttrbuteVisibilitySettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateEmpAttrbuteVisibilitySettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateEmpAttrbuteVisibilitySetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_emp_attrbute_visibility_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        """
        @summary 更新企业员工属性字段可见性设置
        
        @param request: UpdateEmpAttrbuteVisibilitySettingRequest
        @param headers: UpdateEmpAttrbuteVisibilitySettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateEmpAttrbuteVisibilitySettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.active):
            body['active'] = request.active
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_staff_ids):
            body['excludeStaffIds'] = request.exclude_staff_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_staff_ids):
            body['objectStaffIds'] = request.object_staff_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateEmpAttrbuteVisibilitySetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/staffAttributes/visibilitySettings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_emp_attrbute_visibility_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        """
        @summary 更新企业员工属性字段可见性设置
        
        @param request: UpdateEmpAttrbuteVisibilitySettingRequest
        @return: UpdateEmpAttrbuteVisibilitySettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders()
        return self.update_emp_attrbute_visibility_setting_with_options(request, headers, runtime)

    async def update_emp_attrbute_visibility_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingResponse:
        """
        @summary 更新企业员工属性字段可见性设置
        
        @param request: UpdateEmpAttrbuteVisibilitySettingRequest
        @return: UpdateEmpAttrbuteVisibilitySettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttrbuteVisibilitySettingHeaders()
        return await self.update_emp_attrbute_visibility_setting_with_options_async(request, headers, runtime)

    def update_emp_attribute_hide_by_scene_setting_with_options(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse:
        """
        @summary 更新员工属性分场景隐藏设置
        
        @param request: UpdateEmpAttributeHideBySceneSettingRequest
        @param headers: UpdateEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateEmpAttributeHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_subtitle_config):
            body['chatSubtitleConfig'] = request.chat_subtitle_config
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_emp_attribute_hide_by_scene_setting_with_options_async(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse:
        """
        @summary 更新员工属性分场景隐藏设置
        
        @param request: UpdateEmpAttributeHideBySceneSettingRequest
        @param headers: UpdateEmpAttributeHideBySceneSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateEmpAttributeHideBySceneSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.chat_subtitle_config):
            body['chatSubtitleConfig'] = request.chat_subtitle_config
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.exclude_dept_ids):
            body['excludeDeptIds'] = request.exclude_dept_ids
        if not UtilClient.is_unset(request.exclude_tag_ids):
            body['excludeTagIds'] = request.exclude_tag_ids
        if not UtilClient.is_unset(request.exclude_user_ids):
            body['excludeUserIds'] = request.exclude_user_ids
        if not UtilClient.is_unset(request.hide_fields):
            body['hideFields'] = request.hide_fields
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.object_dept_ids):
            body['objectDeptIds'] = request.object_dept_ids
        if not UtilClient.is_unset(request.object_tag_ids):
            body['objectTagIds'] = request.object_tag_ids
        if not UtilClient.is_unset(request.object_user_ids):
            body['objectUserIds'] = request.object_user_ids
        if not UtilClient.is_unset(request.profile_scene_config):
            body['profileSceneConfig'] = request.profile_scene_config
        if not UtilClient.is_unset(request.search_scene_config):
            body['searchSceneConfig'] = request.search_scene_config
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateEmpAttributeHideBySceneSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/empAttributes/hides/settings/{setting_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_emp_attribute_hide_by_scene_setting(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse:
        """
        @summary 更新员工属性分场景隐藏设置
        
        @param request: UpdateEmpAttributeHideBySceneSettingRequest
        @return: UpdateEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingHeaders()
        return self.update_emp_attribute_hide_by_scene_setting_with_options(setting_id, request, headers, runtime)

    async def update_emp_attribute_hide_by_scene_setting_async(
        self,
        setting_id: str,
        request: dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingResponse:
        """
        @summary 更新员工属性分场景隐藏设置
        
        @param request: UpdateEmpAttributeHideBySceneSettingRequest
        @return: UpdateEmpAttributeHideBySceneSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateEmpAttributeHideBySceneSettingHeaders()
        return await self.update_emp_attribute_hide_by_scene_setting_with_options_async(setting_id, request, headers, runtime)

    def update_management_group_with_options(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.UpdateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        """
        @summary 更新管理组
        
        @param request: UpdateManagementGroupRequest
        @param headers: UpdateManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateManagementGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups/{group_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateManagementGroupResponse(),
            self.execute(params, req, runtime)
        )

    async def update_management_group_with_options_async(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
        headers: dingtalkcontact__1__0_models.UpdateManagementGroupHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        """
        @summary 更新管理组
        
        @param request: UpdateManagementGroupRequest
        @param headers: UpdateManagementGroupHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateManagementGroupResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.group_name):
            body['groupName'] = request.group_name
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.resource_ids):
            body['resourceIds'] = request.resource_ids
        if not UtilClient.is_unset(request.scope):
            body['scope'] = request.scope
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateManagementGroup',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/managementGroups/{group_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='json',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateManagementGroupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_management_group(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        """
        @summary 更新管理组
        
        @param request: UpdateManagementGroupRequest
        @return: UpdateManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateManagementGroupHeaders()
        return self.update_management_group_with_options(group_id, request, headers, runtime)

    async def update_management_group_async(
        self,
        group_id: str,
        request: dingtalkcontact__1__0_models.UpdateManagementGroupRequest,
    ) -> dingtalkcontact__1__0_models.UpdateManagementGroupResponse:
        """
        @summary 更新管理组
        
        @param request: UpdateManagementGroupRequest
        @return: UpdateManagementGroupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateManagementGroupHeaders()
        return await self.update_management_group_with_options_async(group_id, request, headers, runtime)

    def update_senior_setting_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        """
        @summary 设置高管模式
        
        @param request: UpdateSeniorSettingRequest
        @param headers: UpdateSeniorSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSeniorSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open):
            body['open'] = request.open
        if not UtilClient.is_unset(request.permit_dept_ids):
            body['permitDeptIds'] = request.permit_dept_ids
        if not UtilClient.is_unset(request.permit_staff_ids):
            body['permitStaffIds'] = request.permit_staff_ids
        if not UtilClient.is_unset(request.permit_tag_ids):
            body['permitTagIds'] = request.permit_tag_ids
        if not UtilClient.is_unset(request.protect_scenes):
            body['protectScenes'] = request.protect_scenes
        if not UtilClient.is_unset(request.senior_staff_id):
            body['seniorStaffId'] = request.senior_staff_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSeniorSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/seniorSettings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateSeniorSettingResponse(),
            self.execute(params, req, runtime)
        )

    async def update_senior_setting_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
        headers: dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        """
        @summary 设置高管模式
        
        @param request: UpdateSeniorSettingRequest
        @param headers: UpdateSeniorSettingHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateSeniorSettingResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.open):
            body['open'] = request.open
        if not UtilClient.is_unset(request.permit_dept_ids):
            body['permitDeptIds'] = request.permit_dept_ids
        if not UtilClient.is_unset(request.permit_staff_ids):
            body['permitStaffIds'] = request.permit_staff_ids
        if not UtilClient.is_unset(request.permit_tag_ids):
            body['permitTagIds'] = request.permit_tag_ids
        if not UtilClient.is_unset(request.protect_scenes):
            body['protectScenes'] = request.protect_scenes
        if not UtilClient.is_unset(request.senior_staff_id):
            body['seniorStaffId'] = request.senior_staff_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateSeniorSetting',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/seniorSettings',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='none'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateSeniorSettingResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_senior_setting(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        """
        @summary 设置高管模式
        
        @param request: UpdateSeniorSettingRequest
        @return: UpdateSeniorSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders()
        return self.update_senior_setting_with_options(request, headers, runtime)

    async def update_senior_setting_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateSeniorSettingRequest,
    ) -> dingtalkcontact__1__0_models.UpdateSeniorSettingResponse:
        """
        @summary 设置高管模式
        
        @param request: UpdateSeniorSettingRequest
        @return: UpdateSeniorSettingResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateSeniorSettingHeaders()
        return await self.update_senior_setting_with_options_async(request, headers, runtime)

    def update_title_audit_status_with_options(
        self,
        request: dingtalkcontact__1__0_models.UpdateTitleAuditStatusRequest,
        headers: dingtalkcontact__1__0_models.UpdateTitleAuditStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse:
        """
        @summary 三方通过该接口更新个人履历的审核状态
        
        @param request: UpdateTitleAuditStatusRequest
        @param headers: UpdateTitleAuditStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTitleAuditStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_status):
            body['authStatus'] = request.auth_status
        if not UtilClient.is_unset(request.education_level):
            body['educationLevel'] = request.education_level
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.major):
            body['major'] = request.major
        if not UtilClient.is_unset(request.position):
            body['position'] = request.position
        if not UtilClient.is_unset(request.reason_code):
            body['reasonCode'] = request.reason_code
        if not UtilClient.is_unset(request.reason_msg):
            body['reasonMsg'] = request.reason_msg
        if not UtilClient.is_unset(request.school):
            body['school'] = request.school
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='UpdateTitleAuditStatus',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/userTitles/auditStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_title_audit_status_with_options_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateTitleAuditStatusRequest,
        headers: dingtalkcontact__1__0_models.UpdateTitleAuditStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse:
        """
        @summary 三方通过该接口更新个人履历的审核状态
        
        @param request: UpdateTitleAuditStatusRequest
        @param headers: UpdateTitleAuditStatusHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTitleAuditStatusResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.auth_status):
            body['authStatus'] = request.auth_status
        if not UtilClient.is_unset(request.education_level):
            body['educationLevel'] = request.education_level
        if not UtilClient.is_unset(request.extension):
            body['extension'] = request.extension
        if not UtilClient.is_unset(request.major):
            body['major'] = request.major
        if not UtilClient.is_unset(request.position):
            body['position'] = request.position
        if not UtilClient.is_unset(request.reason_code):
            body['reasonCode'] = request.reason_code
        if not UtilClient.is_unset(request.reason_msg):
            body['reasonMsg'] = request.reason_msg
        if not UtilClient.is_unset(request.school):
            body['school'] = request.school
        if not UtilClient.is_unset(request.type):
            body['type'] = request.type
        if not UtilClient.is_unset(request.union_id):
            body['unionId'] = request.union_id
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
            action='UpdateTitleAuditStatus',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/userTitles/auditStatuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_title_audit_status(
        self,
        request: dingtalkcontact__1__0_models.UpdateTitleAuditStatusRequest,
    ) -> dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse:
        """
        @summary 三方通过该接口更新个人履历的审核状态
        
        @param request: UpdateTitleAuditStatusRequest
        @return: UpdateTitleAuditStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateTitleAuditStatusHeaders()
        return self.update_title_audit_status_with_options(request, headers, runtime)

    async def update_title_audit_status_async(
        self,
        request: dingtalkcontact__1__0_models.UpdateTitleAuditStatusRequest,
    ) -> dingtalkcontact__1__0_models.UpdateTitleAuditStatusResponse:
        """
        @summary 三方通过该接口更新个人履历的审核状态
        
        @param request: UpdateTitleAuditStatusRequest
        @return: UpdateTitleAuditStatusResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateTitleAuditStatusHeaders()
        return await self.update_title_audit_status_with_options_async(request, headers, runtime)

    def update_user_ownness_with_options(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        """
        @summary 更新用户个人状态
        
        @param request: UpdateUserOwnnessRequest
        @param headers: UpdateUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.deleted_flag):
            body['deletedFlag'] = request.deleted_flag
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
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
            action='UpdateUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/user/{user_id}/ownness',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateUserOwnnessResponse(),
            self.execute(params, req, runtime)
        )

    async def update_user_ownness_with_options_async(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
        headers: dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        """
        @summary 更新用户个人状态
        
        @param request: UpdateUserOwnnessRequest
        @param headers: UpdateUserOwnnessHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateUserOwnnessResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.deleted_flag):
            body['deletedFlag'] = request.deleted_flag
        if not UtilClient.is_unset(request.end_time):
            body['endTime'] = request.end_time
        if not UtilClient.is_unset(request.id):
            body['id'] = request.id
        if not UtilClient.is_unset(request.ownenss_type):
            body['ownenssType'] = request.ownenss_type
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
            action='UpdateUserOwnness',
            version='contact_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/contact/user/{user_id}/ownness',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcontact__1__0_models.UpdateUserOwnnessResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_user_ownness(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        """
        @summary 更新用户个人状态
        
        @param request: UpdateUserOwnnessRequest
        @return: UpdateUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders()
        return self.update_user_ownness_with_options(user_id, request, headers, runtime)

    async def update_user_ownness_async(
        self,
        user_id: str,
        request: dingtalkcontact__1__0_models.UpdateUserOwnnessRequest,
    ) -> dingtalkcontact__1__0_models.UpdateUserOwnnessResponse:
        """
        @summary 更新用户个人状态
        
        @param request: UpdateUserOwnnessRequest
        @return: UpdateUserOwnnessResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcontact__1__0_models.UpdateUserOwnnessHeaders()
        return await self.update_user_ownness_with_options_async(user_id, request, headers, runtime)
