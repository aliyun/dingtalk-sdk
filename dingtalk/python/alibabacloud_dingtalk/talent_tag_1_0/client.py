# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.talent_tag_1_0 import models as dingtalktalent_tag__1__0_models
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

    def talent_v2add_custom_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse:
        """
        @summary 人才标签：添加员工自定义标签
        
        @param request: TalentV2AddCustomTagRequest
        @param headers: TalentV2AddCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddCustomTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
            action='TalentV2AddCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addCustomTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2add_custom_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse:
        """
        @summary 人才标签：添加员工自定义标签
        
        @param request: TalentV2AddCustomTagRequest
        @param headers: TalentV2AddCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddCustomTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
            action='TalentV2AddCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addCustomTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2add_custom_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse:
        """
        @summary 人才标签：添加员工自定义标签
        
        @param request: TalentV2AddCustomTagRequest
        @return: TalentV2AddCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddCustomTagHeaders()
        return self.talent_v2add_custom_tag_with_options(request, headers, runtime)

    async def talent_v2add_custom_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddCustomTagResponse:
        """
        @summary 人才标签：添加员工自定义标签
        
        @param request: TalentV2AddCustomTagRequest
        @return: TalentV2AddCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddCustomTagHeaders()
        return await self.talent_v2add_custom_tag_with_options_async(request, headers, runtime)

    def talent_v2add_objective_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse:
        """
        @summary 人才标签：添加员工客观标签
        
        @param request: TalentV2AddObjectiveTagRequest
        @param headers: TalentV2AddObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddObjectiveTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
            action='TalentV2AddObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addObjectiveTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2add_objective_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse:
        """
        @summary 人才标签：添加员工客观标签
        
        @param request: TalentV2AddObjectiveTagRequest
        @param headers: TalentV2AddObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddObjectiveTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
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
            action='TalentV2AddObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addObjectiveTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2add_objective_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse:
        """
        @summary 人才标签：添加员工客观标签
        
        @param request: TalentV2AddObjectiveTagRequest
        @return: TalentV2AddObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagHeaders()
        return self.talent_v2add_objective_tag_with_options(request, headers, runtime)

    async def talent_v2add_objective_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagResponse:
        """
        @summary 人才标签：添加员工客观标签
        
        @param request: TalentV2AddObjectiveTagRequest
        @return: TalentV2AddObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddObjectiveTagHeaders()
        return await self.talent_v2add_objective_tag_with_options_async(request, headers, runtime)

    def talent_v2add_personality_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse:
        """
        @summary 人才标签：添加企业个性标签
        
        @param request: TalentV2AddPersonalityTagRequest
        @param headers: TalentV2AddPersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddPersonalityTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_code):
            body['categoryCode'] = request.category_code
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.category_sort_order):
            body['categorySortOrder'] = request.category_sort_order
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TalentV2AddPersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addPersonalityTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2add_personality_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse:
        """
        @summary 人才标签：添加企业个性标签
        
        @param request: TalentV2AddPersonalityTagRequest
        @param headers: TalentV2AddPersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2AddPersonalityTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.category_code):
            body['categoryCode'] = request.category_code
        if not UtilClient.is_unset(request.category_name):
            body['categoryName'] = request.category_name
        if not UtilClient.is_unset(request.category_sort_order):
            body['categorySortOrder'] = request.category_sort_order
        if not UtilClient.is_unset(request.sort_order):
            body['sortOrder'] = request.sort_order
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        if not UtilClient.is_unset(request.tag_name):
            body['tagName'] = request.tag_name
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TalentV2AddPersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/addPersonalityTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2add_personality_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse:
        """
        @summary 人才标签：添加企业个性标签
        
        @param request: TalentV2AddPersonalityTagRequest
        @return: TalentV2AddPersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagHeaders()
        return self.talent_v2add_personality_tag_with_options(request, headers, runtime)

    async def talent_v2add_personality_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagResponse:
        """
        @summary 人才标签：添加企业个性标签
        
        @param request: TalentV2AddPersonalityTagRequest
        @return: TalentV2AddPersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2AddPersonalityTagHeaders()
        return await self.talent_v2add_personality_tag_with_options_async(request, headers, runtime)

    def talent_v2delete_custom_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse:
        """
        @summary 人才标签：删除员工自定义标签并清除所有点赞记录
        
        @param request: TalentV2DeleteCustomTagRequest
        @param headers: TalentV2DeleteCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeleteCustomTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2DeleteCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2delete_custom_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse:
        """
        @summary 人才标签：删除员工自定义标签并清除所有点赞记录
        
        @param request: TalentV2DeleteCustomTagRequest
        @param headers: TalentV2DeleteCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeleteCustomTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2DeleteCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deleteCustomTagWithClearLike',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2delete_custom_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse:
        """
        @summary 人才标签：删除员工自定义标签并清除所有点赞记录
        
        @param request: TalentV2DeleteCustomTagRequest
        @return: TalentV2DeleteCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagHeaders()
        return self.talent_v2delete_custom_tag_with_options(request, headers, runtime)

    async def talent_v2delete_custom_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagResponse:
        """
        @summary 人才标签：删除员工自定义标签并清除所有点赞记录
        
        @param request: TalentV2DeleteCustomTagRequest
        @return: TalentV2DeleteCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeleteCustomTagHeaders()
        return await self.talent_v2delete_custom_tag_with_options_async(request, headers, runtime)

    def talent_v2delete_objective_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse:
        """
        @summary 人才标签：删除员工客观标签
        
        @param request: TalentV2DeleteObjectiveTagRequest
        @param headers: TalentV2DeleteObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeleteObjectiveTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2DeleteObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deleteObjectiveTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2delete_objective_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse:
        """
        @summary 人才标签：删除员工客观标签
        
        @param request: TalentV2DeleteObjectiveTagRequest
        @param headers: TalentV2DeleteObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeleteObjectiveTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2DeleteObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deleteObjectiveTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2delete_objective_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse:
        """
        @summary 人才标签：删除员工客观标签
        
        @param request: TalentV2DeleteObjectiveTagRequest
        @return: TalentV2DeleteObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagHeaders()
        return self.talent_v2delete_objective_tag_with_options(request, headers, runtime)

    async def talent_v2delete_objective_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagResponse:
        """
        @summary 人才标签：删除员工客观标签
        
        @param request: TalentV2DeleteObjectiveTagRequest
        @return: TalentV2DeleteObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeleteObjectiveTagHeaders()
        return await self.talent_v2delete_objective_tag_with_options_async(request, headers, runtime)

    def talent_v2delete_personality_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse:
        """
        @summary 人才标签：删除企业个性标签
        
        @param request: TalentV2DeletePersonalityTagRequest
        @param headers: TalentV2DeletePersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeletePersonalityTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TalentV2DeletePersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deletePersonalityTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2delete_personality_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse:
        """
        @summary 人才标签：删除企业个性标签
        
        @param request: TalentV2DeletePersonalityTagRequest
        @param headers: TalentV2DeletePersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2DeletePersonalityTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='TalentV2DeletePersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/deletePersonalityTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2delete_personality_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse:
        """
        @summary 人才标签：删除企业个性标签
        
        @param request: TalentV2DeletePersonalityTagRequest
        @return: TalentV2DeletePersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagHeaders()
        return self.talent_v2delete_personality_tag_with_options(request, headers, runtime)

    async def talent_v2delete_personality_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagResponse:
        """
        @summary 人才标签：删除企业个性标签
        
        @param request: TalentV2DeletePersonalityTagRequest
        @return: TalentV2DeletePersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2DeletePersonalityTagHeaders()
        return await self.talent_v2delete_personality_tag_with_options_async(request, headers, runtime)

    def talent_v2like_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2LikeTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2LikeTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse:
        """
        @summary 人才标签：点赞/取消点赞标签
        
        @param request: TalentV2LikeTagRequest
        @param headers: TalentV2LikeTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2LikeTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2LikeTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/likeTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2like_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2LikeTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2LikeTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse:
        """
        @summary 人才标签：点赞/取消点赞标签
        
        @param request: TalentV2LikeTagRequest
        @param headers: TalentV2LikeTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2LikeTagResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_type):
            body['actionType'] = request.action_type
        if not UtilClient.is_unset(request.operator_user_id):
            body['operatorUserId'] = request.operator_user_id
        if not UtilClient.is_unset(request.tag_code):
            body['tagCode'] = request.tag_code
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
            action='TalentV2LikeTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/likeTag',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2like_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2LikeTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse:
        """
        @summary 人才标签：点赞/取消点赞标签
        
        @param request: TalentV2LikeTagRequest
        @return: TalentV2LikeTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2LikeTagHeaders()
        return self.talent_v2like_tag_with_options(request, headers, runtime)

    async def talent_v2like_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2LikeTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2LikeTagResponse:
        """
        @summary 人才标签：点赞/取消点赞标签
        
        @param request: TalentV2LikeTagRequest
        @return: TalentV2LikeTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2LikeTagHeaders()
        return await self.talent_v2like_tag_with_options_async(request, headers, runtime)

    def talent_v2query_custom_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse:
        """
        @summary 人才标签：查询员工自定义标签
        
        @param request: TalentV2QueryCustomTagRequest
        @param headers: TalentV2QueryCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryCustomTagResponse
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
            action='TalentV2QueryCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryCustomTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2query_custom_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse:
        """
        @summary 人才标签：查询员工自定义标签
        
        @param request: TalentV2QueryCustomTagRequest
        @param headers: TalentV2QueryCustomTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryCustomTagResponse
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
            action='TalentV2QueryCustomTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryCustomTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2query_custom_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse:
        """
        @summary 人才标签：查询员工自定义标签
        
        @param request: TalentV2QueryCustomTagRequest
        @return: TalentV2QueryCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagHeaders()
        return self.talent_v2query_custom_tag_with_options(request, headers, runtime)

    async def talent_v2query_custom_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagResponse:
        """
        @summary 人才标签：查询员工自定义标签
        
        @param request: TalentV2QueryCustomTagRequest
        @return: TalentV2QueryCustomTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryCustomTagHeaders()
        return await self.talent_v2query_custom_tag_with_options_async(request, headers, runtime)

    def talent_v2query_objective_tag_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse:
        """
        @summary 人才标签：查询员工客观标签
        
        @param request: TalentV2QueryObjectiveTagRequest
        @param headers: TalentV2QueryObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryObjectiveTagResponse
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
            action='TalentV2QueryObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryObjectiveTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2query_objective_tag_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse:
        """
        @summary 人才标签：查询员工客观标签
        
        @param request: TalentV2QueryObjectiveTagRequest
        @param headers: TalentV2QueryObjectiveTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryObjectiveTagResponse
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
            action='TalentV2QueryObjectiveTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryObjectiveTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2query_objective_tag(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse:
        """
        @summary 人才标签：查询员工客观标签
        
        @param request: TalentV2QueryObjectiveTagRequest
        @return: TalentV2QueryObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagHeaders()
        return self.talent_v2query_objective_tag_with_options(request, headers, runtime)

    async def talent_v2query_objective_tag_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagResponse:
        """
        @summary 人才标签：查询员工客观标签
        
        @param request: TalentV2QueryObjectiveTagRequest
        @return: TalentV2QueryObjectiveTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryObjectiveTagHeaders()
        return await self.talent_v2query_objective_tag_with_options_async(request, headers, runtime)

    def talent_v2query_personality_tag_with_options(
        self,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse:
        """
        @summary 人才标签：查询企业个性标签
        
        @param headers: TalentV2QueryPersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryPersonalityTagResponse
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
            action='TalentV2QueryPersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryPersonalityTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2query_personality_tag_with_options_async(
        self,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse:
        """
        @summary 人才标签：查询企业个性标签
        
        @param headers: TalentV2QueryPersonalityTagHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryPersonalityTagResponse
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
            action='TalentV2QueryPersonalityTag',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryPersonalityTag',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2query_personality_tag(self) -> dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse:
        """
        @summary 人才标签：查询企业个性标签
        
        @return: TalentV2QueryPersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagHeaders()
        return self.talent_v2query_personality_tag_with_options(headers, runtime)

    async def talent_v2query_personality_tag_async(self) -> dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagResponse:
        """
        @summary 人才标签：查询企业个性标签
        
        @return: TalentV2QueryPersonalityTagResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryPersonalityTagHeaders()
        return await self.talent_v2query_personality_tag_with_options_async(headers, runtime)

    def talent_v2query_tag_like_detail_list_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse:
        """
        @summary 人才标签：分页查询指定标签的点赞记录
        
        @param request: TalentV2QueryTagLikeDetailListRequest
        @param headers: TalentV2QueryTagLikeDetailListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryTagLikeDetailListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.tag_code):
            query['tagCode'] = request.tag_code
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
            action='TalentV2QueryTagLikeDetailList',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryTagLikeDetailList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2query_tag_like_detail_list_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse:
        """
        @summary 人才标签：分页查询指定标签的点赞记录
        
        @param request: TalentV2QueryTagLikeDetailListRequest
        @param headers: TalentV2QueryTagLikeDetailListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryTagLikeDetailListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.cursor):
            query['cursor'] = request.cursor
        if not UtilClient.is_unset(request.size):
            query['size'] = request.size
        if not UtilClient.is_unset(request.tag_code):
            query['tagCode'] = request.tag_code
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
            action='TalentV2QueryTagLikeDetailList',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryTagLikeDetailList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2query_tag_like_detail_list(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse:
        """
        @summary 人才标签：分页查询指定标签的点赞记录
        
        @param request: TalentV2QueryTagLikeDetailListRequest
        @return: TalentV2QueryTagLikeDetailListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListHeaders()
        return self.talent_v2query_tag_like_detail_list_with_options(request, headers, runtime)

    async def talent_v2query_tag_like_detail_list_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListResponse:
        """
        @summary 人才标签：分页查询指定标签的点赞记录
        
        @param request: TalentV2QueryTagLikeDetailListRequest
        @return: TalentV2QueryTagLikeDetailListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeDetailListHeaders()
        return await self.talent_v2query_tag_like_detail_list_with_options_async(request, headers, runtime)

    def talent_v2query_tag_like_list_with_options(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse:
        """
        @summary 人才标签：查询点赞标签列表
        
        @param request: TalentV2QueryTagLikeListRequest
        @param headers: TalentV2QueryTagLikeListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryTagLikeListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
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
            action='TalentV2QueryTagLikeList',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryTagLikeList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse(),
            self.execute(params, req, runtime)
        )

    async def talent_v2query_tag_like_list_with_options_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListRequest,
        headers: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse:
        """
        @summary 人才标签：查询点赞标签列表
        
        @param request: TalentV2QueryTagLikeListRequest
        @param headers: TalentV2QueryTagLikeListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TalentV2QueryTagLikeListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_user_id):
            query['operatorUserId'] = request.operator_user_id
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
            action='TalentV2QueryTagLikeList',
            version='talentTag_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/talentTag/talentTags/queryTagLikeList',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def talent_v2query_tag_like_list(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse:
        """
        @summary 人才标签：查询点赞标签列表
        
        @param request: TalentV2QueryTagLikeListRequest
        @return: TalentV2QueryTagLikeListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListHeaders()
        return self.talent_v2query_tag_like_list_with_options(request, headers, runtime)

    async def talent_v2query_tag_like_list_async(
        self,
        request: dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListRequest,
    ) -> dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListResponse:
        """
        @summary 人才标签：查询点赞标签列表
        
        @param request: TalentV2QueryTagLikeListRequest
        @return: TalentV2QueryTagLikeListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktalent_tag__1__0_models.TalentV2QueryTagLikeListHeaders()
        return await self.talent_v2query_tag_like_list_with_options_async(request, headers, runtime)
