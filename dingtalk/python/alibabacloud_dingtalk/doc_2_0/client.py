# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.doc_2_0 import models as dingtalkdoc__2__0_models
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

    def batch_create_team_with_options(
        self,
        request: dingtalkdoc__2__0_models.BatchCreateTeamRequest,
        headers: dingtalkdoc__2__0_models.BatchCreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.BatchCreateTeamResponse:
        """
        @summary 批量创建小组
        
        @param request: BatchCreateTeamRequest
        @param headers: BatchCreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='BatchCreateTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.BatchCreateTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_team_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.BatchCreateTeamRequest,
        headers: dingtalkdoc__2__0_models.BatchCreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.BatchCreateTeamResponse:
        """
        @summary 批量创建小组
        
        @param request: BatchCreateTeamRequest
        @param headers: BatchCreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='BatchCreateTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/batch',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.BatchCreateTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_team(
        self,
        request: dingtalkdoc__2__0_models.BatchCreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.BatchCreateTeamResponse:
        """
        @summary 批量创建小组
        
        @param request: BatchCreateTeamRequest
        @return: BatchCreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.BatchCreateTeamHeaders()
        return self.batch_create_team_with_options(request, headers, runtime)

    async def batch_create_team_async(
        self,
        request: dingtalkdoc__2__0_models.BatchCreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.BatchCreateTeamResponse:
        """
        @summary 批量创建小组
        
        @param request: BatchCreateTeamRequest
        @return: BatchCreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.BatchCreateTeamHeaders()
        return await self.batch_create_team_with_options_async(request, headers, runtime)

    def batch_delete_recents_with_options(
        self,
        request: dingtalkdoc__2__0_models.BatchDeleteRecentsRequest,
        headers: dingtalkdoc__2__0_models.BatchDeleteRecentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.BatchDeleteRecentsResponse:
        """
        @summary 批量删除文档最近记录
        
        @param request: BatchDeleteRecentsRequest
        @param headers: BatchDeleteRecentsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchDeleteRecentsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.dentry_uuids):
            body['dentryUuids'] = request.dentry_uuids
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
            action='BatchDeleteRecents',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/recentRecords/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.BatchDeleteRecentsResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_delete_recents_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.BatchDeleteRecentsRequest,
        headers: dingtalkdoc__2__0_models.BatchDeleteRecentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.BatchDeleteRecentsResponse:
        """
        @summary 批量删除文档最近记录
        
        @param request: BatchDeleteRecentsRequest
        @param headers: BatchDeleteRecentsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchDeleteRecentsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.dentry_uuids):
            body['dentryUuids'] = request.dentry_uuids
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
            action='BatchDeleteRecents',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/recentRecords/batchRemove',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.BatchDeleteRecentsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_delete_recents(
        self,
        request: dingtalkdoc__2__0_models.BatchDeleteRecentsRequest,
    ) -> dingtalkdoc__2__0_models.BatchDeleteRecentsResponse:
        """
        @summary 批量删除文档最近记录
        
        @param request: BatchDeleteRecentsRequest
        @return: BatchDeleteRecentsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.BatchDeleteRecentsHeaders()
        return self.batch_delete_recents_with_options(request, headers, runtime)

    async def batch_delete_recents_async(
        self,
        request: dingtalkdoc__2__0_models.BatchDeleteRecentsRequest,
    ) -> dingtalkdoc__2__0_models.BatchDeleteRecentsResponse:
        """
        @summary 批量删除文档最近记录
        
        @param request: BatchDeleteRecentsRequest
        @return: BatchDeleteRecentsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.BatchDeleteRecentsHeaders()
        return await self.batch_delete_recents_with_options_async(request, headers, runtime)

    def categories_templates_with_options(
        self,
        request: dingtalkdoc__2__0_models.CategoriesTemplatesRequest,
        headers: dingtalkdoc__2__0_models.CategoriesTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CategoriesTemplatesResponse:
        """
        @summary 按分类列表查询模板列表
        
        @param request: CategoriesTemplatesRequest
        @param headers: CategoriesTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoriesTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CategoriesTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/categoryLists/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CategoriesTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def categories_templates_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CategoriesTemplatesRequest,
        headers: dingtalkdoc__2__0_models.CategoriesTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CategoriesTemplatesResponse:
        """
        @summary 按分类列表查询模板列表
        
        @param request: CategoriesTemplatesRequest
        @param headers: CategoriesTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoriesTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CategoriesTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/categoryLists/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CategoriesTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def categories_templates(
        self,
        request: dingtalkdoc__2__0_models.CategoriesTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.CategoriesTemplatesResponse:
        """
        @summary 按分类列表查询模板列表
        
        @param request: CategoriesTemplatesRequest
        @return: CategoriesTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CategoriesTemplatesHeaders()
        return self.categories_templates_with_options(request, headers, runtime)

    async def categories_templates_async(
        self,
        request: dingtalkdoc__2__0_models.CategoriesTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.CategoriesTemplatesResponse:
        """
        @summary 按分类列表查询模板列表
        
        @param request: CategoriesTemplatesRequest
        @return: CategoriesTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CategoriesTemplatesHeaders()
        return await self.categories_templates_with_options_async(request, headers, runtime)

    def category_templates_with_options(
        self,
        request: dingtalkdoc__2__0_models.CategoryTemplatesRequest,
        headers: dingtalkdoc__2__0_models.CategoryTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CategoryTemplatesResponse:
        """
        @summary 按分类查询模板列表
        
        @param request: CategoryTemplatesRequest
        @param headers: CategoryTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoryTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CategoryTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/categories/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CategoryTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def category_templates_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CategoryTemplatesRequest,
        headers: dingtalkdoc__2__0_models.CategoryTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CategoryTemplatesResponse:
        """
        @summary 按分类查询模板列表
        
        @param request: CategoryTemplatesRequest
        @param headers: CategoryTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CategoryTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CategoryTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/categories/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CategoryTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def category_templates(
        self,
        request: dingtalkdoc__2__0_models.CategoryTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.CategoryTemplatesResponse:
        """
        @summary 按分类查询模板列表
        
        @param request: CategoryTemplatesRequest
        @return: CategoryTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CategoryTemplatesHeaders()
        return self.category_templates_with_options(request, headers, runtime)

    async def category_templates_async(
        self,
        request: dingtalkdoc__2__0_models.CategoryTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.CategoryTemplatesResponse:
        """
        @summary 按分类查询模板列表
        
        @param request: CategoryTemplatesRequest
        @return: CategoryTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CategoryTemplatesHeaders()
        return await self.category_templates_with_options_async(request, headers, runtime)

    def copy_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
        headers: dingtalkdoc__2__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        """
        @summary 拷贝知识库节点
        
        @param request: CopyDentryRequest
        @param headers: CopyDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
        headers: dingtalkdoc__2__0_models.CopyDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        """
        @summary 拷贝知识库节点
        
        @param request: CopyDentryRequest
        @param headers: CopyDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        """
        @summary 拷贝知识库节点
        
        @param request: CopyDentryRequest
        @return: CopyDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyDentryHeaders()
        return self.copy_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def copy_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.CopyDentryRequest,
    ) -> dingtalkdoc__2__0_models.CopyDentryResponse:
        """
        @summary 拷贝知识库节点
        
        @param request: CopyDentryRequest
        @return: CopyDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyDentryHeaders()
        return await self.copy_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def copy_workspace_with_options(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceRequest,
        headers: dingtalkdoc__2__0_models.CopyWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceResponse:
        """
        @summary 拷贝知识库
        
        @param request: CopyWorkspaceRequest
        @param headers: CopyWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyWorkspaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyWorkspace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/workspace/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyWorkspaceResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_workspace_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceRequest,
        headers: dingtalkdoc__2__0_models.CopyWorkspaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceResponse:
        """
        @summary 拷贝知识库
        
        @param request: CopyWorkspaceRequest
        @param headers: CopyWorkspaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyWorkspaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyWorkspace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/workspace/copy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyWorkspaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_workspace(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceRequest,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceResponse:
        """
        @summary 拷贝知识库
        
        @param request: CopyWorkspaceRequest
        @return: CopyWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyWorkspaceHeaders()
        return self.copy_workspace_with_options(request, headers, runtime)

    async def copy_workspace_async(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceRequest,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceResponse:
        """
        @summary 拷贝知识库
        
        @param request: CopyWorkspaceRequest
        @return: CopyWorkspaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyWorkspaceHeaders()
        return await self.copy_workspace_with_options_async(request, headers, runtime)

    def copy_workspace_async_with_options(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceAsyncRequest,
        headers: dingtalkdoc__2__0_models.CopyWorkspaceAsyncHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse:
        """
        @summary 异步拷贝知识库
        
        @param request: CopyWorkspaceAsyncRequest
        @param headers: CopyWorkspaceAsyncHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyWorkspaceAsyncResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyWorkspaceAsync',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/workspace/asyncCopy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse(),
            self.execute(params, req, runtime)
        )

    async def copy_workspace_async_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceAsyncRequest,
        headers: dingtalkdoc__2__0_models.CopyWorkspaceAsyncHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse:
        """
        @summary 异步拷贝知识库
        
        @param request: CopyWorkspaceAsyncRequest
        @param headers: CopyWorkspaceAsyncHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CopyWorkspaceAsyncResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CopyWorkspaceAsync',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/workspace/asyncCopy',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse(),
            await self.execute_async(params, req, runtime)
        )

    def copy_workspace_async(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceAsyncRequest,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse:
        """
        @summary 异步拷贝知识库
        
        @param request: CopyWorkspaceAsyncRequest
        @return: CopyWorkspaceAsyncResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyWorkspaceAsyncHeaders()
        return self.copy_workspace_async_with_options(request, headers, runtime)

    async def copy_workspace_async_async(
        self,
        request: dingtalkdoc__2__0_models.CopyWorkspaceAsyncRequest,
    ) -> dingtalkdoc__2__0_models.CopyWorkspaceAsyncResponse:
        """
        @summary 异步拷贝知识库
        
        @param request: CopyWorkspaceAsyncRequest
        @return: CopyWorkspaceAsyncResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CopyWorkspaceAsyncHeaders()
        return await self.copy_workspace_async_with_options_async(request, headers, runtime)

    def create_dentry_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
        headers: dingtalkdoc__2__0_models.CreateDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        """
        @summary 创建知识库节点（包括文档和文件夹）
        
        @param request: CreateDentryRequest
        @param headers: CreateDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_type):
            body['dentryType'] = request.dentry_type
        if not UtilClient.is_unset(request.document_type):
            body['documentType'] = request.document_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_dentry_id):
            body['parentDentryId'] = request.parent_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def create_dentry_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
        headers: dingtalkdoc__2__0_models.CreateDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        """
        @summary 创建知识库节点（包括文档和文件夹）
        
        @param request: CreateDentryRequest
        @param headers: CreateDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_type):
            body['dentryType'] = request.dentry_type
        if not UtilClient.is_unset(request.document_type):
            body['documentType'] = request.document_type
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.parent_dentry_id):
            body['parentDentryId'] = request.parent_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_dentry(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        """
        @summary 创建知识库节点（包括文档和文件夹）
        
        @param request: CreateDentryRequest
        @return: CreateDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateDentryHeaders()
        return self.create_dentry_with_options(space_id, request, headers, runtime)

    async def create_dentry_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.CreateDentryRequest,
    ) -> dingtalkdoc__2__0_models.CreateDentryResponse:
        """
        @summary 创建知识库节点（包括文档和文件夹）
        
        @param request: CreateDentryRequest
        @return: CreateDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateDentryHeaders()
        return await self.create_dentry_with_options_async(space_id, request, headers, runtime)

    def create_space_with_options(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
        headers: dingtalkdoc__2__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        """
        @summary 创建知识库
        
        @param request: CreateSpaceRequest
        @param headers: CreateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.section_id):
            body['sectionId'] = request.section_id
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_space_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
        headers: dingtalkdoc__2__0_models.CreateSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        """
        @summary 创建知识库
        
        @param request: CreateSpaceRequest
        @param headers: CreateSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateSpaceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.section_id):
            body['sectionId'] = request.section_id
        if not UtilClient.is_unset(request.share_scope):
            body['shareScope'] = request.share_scope
        if not UtilClient.is_unset(request.team_id):
            body['teamId'] = request.team_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_space(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        """
        @summary 创建知识库
        
        @param request: CreateSpaceRequest
        @return: CreateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateSpaceHeaders()
        return self.create_space_with_options(request, headers, runtime)

    async def create_space_async(
        self,
        request: dingtalkdoc__2__0_models.CreateSpaceRequest,
    ) -> dingtalkdoc__2__0_models.CreateSpaceResponse:
        """
        @summary 创建知识库
        
        @param request: CreateSpaceRequest
        @return: CreateSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateSpaceHeaders()
        return await self.create_space_with_options_async(request, headers, runtime)

    def create_team_with_options(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
        headers: dingtalkdoc__2__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        """
        @summary 创建小组
        
        @param request: CreateTeamRequest
        @param headers: CreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover):
            body['cover'] = request.cover
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_type):
            body['teamType'] = request.team_type
        real_headers = {}
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
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def create_team_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
        headers: dingtalkdoc__2__0_models.CreateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        """
        @summary 创建小组
        
        @param request: CreateTeamRequest
        @param headers: CreateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.cover):
            body['cover'] = request.cover
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.icon):
            body['icon'] = request.icon
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_type):
            body['teamType'] = request.team_type
        real_headers = {}
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
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CreateTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_team(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        """
        @summary 创建小组
        
        @param request: CreateTeamRequest
        @return: CreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateTeamHeaders()
        return self.create_team_with_options(request, headers, runtime)

    async def create_team_async(
        self,
        request: dingtalkdoc__2__0_models.CreateTeamRequest,
    ) -> dingtalkdoc__2__0_models.CreateTeamResponse:
        """
        @summary 创建小组
        
        @param request: CreateTeamRequest
        @return: CreateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CreateTeamHeaders()
        return await self.create_team_with_options_async(request, headers, runtime)

    def cross_org_migrate_with_options(
        self,
        request: dingtalkdoc__2__0_models.CrossOrgMigrateRequest,
        headers: dingtalkdoc__2__0_models.CrossOrgMigrateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CrossOrgMigrateResponse:
        """
        @summary 跨组织迁移知识库
        
        @param request: CrossOrgMigrateRequest
        @param headers: CrossOrgMigrateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CrossOrgMigrateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CrossOrgMigrate',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/crossOrganizations/spaces/migrate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CrossOrgMigrateResponse(),
            self.execute(params, req, runtime)
        )

    async def cross_org_migrate_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.CrossOrgMigrateRequest,
        headers: dingtalkdoc__2__0_models.CrossOrgMigrateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.CrossOrgMigrateResponse:
        """
        @summary 跨组织迁移知识库
        
        @param request: CrossOrgMigrateRequest
        @param headers: CrossOrgMigrateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CrossOrgMigrateResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='CrossOrgMigrate',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/crossOrganizations/spaces/migrate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.CrossOrgMigrateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def cross_org_migrate(
        self,
        request: dingtalkdoc__2__0_models.CrossOrgMigrateRequest,
    ) -> dingtalkdoc__2__0_models.CrossOrgMigrateResponse:
        """
        @summary 跨组织迁移知识库
        
        @param request: CrossOrgMigrateRequest
        @return: CrossOrgMigrateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CrossOrgMigrateHeaders()
        return self.cross_org_migrate_with_options(request, headers, runtime)

    async def cross_org_migrate_async(
        self,
        request: dingtalkdoc__2__0_models.CrossOrgMigrateRequest,
    ) -> dingtalkdoc__2__0_models.CrossOrgMigrateResponse:
        """
        @summary 跨组织迁移知识库
        
        @param request: CrossOrgMigrateRequest
        @return: CrossOrgMigrateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.CrossOrgMigrateHeaders()
        return await self.cross_org_migrate_with_options_async(request, headers, runtime)

    def delete_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
        headers: dingtalkdoc__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        """
        @summary 删除小组
        
        @param request: DeleteTeamRequest
        @param headers: DeleteTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DeleteTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
        headers: dingtalkdoc__2__0_models.DeleteTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        """
        @summary 删除小组
        
        @param request: DeleteTeamRequest
        @param headers: DeleteTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='DeleteTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DeleteTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        """
        @summary 删除小组
        
        @param request: DeleteTeamRequest
        @return: DeleteTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DeleteTeamHeaders()
        return self.delete_team_with_options(team_id, request, headers, runtime)

    async def delete_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.DeleteTeamRequest,
    ) -> dingtalkdoc__2__0_models.DeleteTeamResponse:
        """
        @summary 删除小组
        
        @param request: DeleteTeamRequest
        @return: DeleteTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DeleteTeamHeaders()
        return await self.delete_team_with_options_async(team_id, request, headers, runtime)

    def doc_content_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.DocContentRequest,
        headers: dingtalkdoc__2__0_models.DocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: DocContentRequest
        @param headers: DocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='DocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DocContentResponse(),
            self.execute(params, req, runtime)
        )

    async def doc_content_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.DocContentRequest,
        headers: dingtalkdoc__2__0_models.DocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.DocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: DocContentRequest
        @param headers: DocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='DocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.DocContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def doc_content(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.DocContentRequest,
    ) -> dingtalkdoc__2__0_models.DocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: DocContentRequest
        @return: DocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DocContentHeaders()
        return self.doc_content_with_options(dentry_uuid, request, headers, runtime)

    async def doc_content_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.DocContentRequest,
    ) -> dingtalkdoc__2__0_models.DocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: DocContentRequest
        @return: DocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.DocContentHeaders()
        return await self.doc_content_with_options_async(dentry_uuid, request, headers, runtime)

    def export_doc_with_options(
        self,
        request: dingtalkdoc__2__0_models.ExportDocRequest,
        headers: dingtalkdoc__2__0_models.ExportDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ExportDocResponse:
        """
        @summary 导出文档
        
        @param request: ExportDocRequest
        @param headers: ExportDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExportDoc',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ExportDocResponse(),
            self.execute(params, req, runtime)
        )

    async def export_doc_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ExportDocRequest,
        headers: dingtalkdoc__2__0_models.ExportDocHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ExportDocResponse:
        """
        @summary 导出文档
        
        @param request: ExportDocRequest
        @param headers: ExportDocHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ExportDocResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ExportDoc',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/export',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ExportDocResponse(),
            await self.execute_async(params, req, runtime)
        )

    def export_doc(
        self,
        request: dingtalkdoc__2__0_models.ExportDocRequest,
    ) -> dingtalkdoc__2__0_models.ExportDocResponse:
        """
        @summary 导出文档
        
        @param request: ExportDocRequest
        @return: ExportDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ExportDocHeaders()
        return self.export_doc_with_options(request, headers, runtime)

    async def export_doc_async(
        self,
        request: dingtalkdoc__2__0_models.ExportDocRequest,
    ) -> dingtalkdoc__2__0_models.ExportDocResponse:
        """
        @summary 导出文档
        
        @param request: ExportDocRequest
        @return: ExportDocResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ExportDocHeaders()
        return await self.export_doc_with_options_async(request, headers, runtime)

    def get_dentry_id_by_uuid_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDentryIdByUuidRequest,
        headers: dingtalkdoc__2__0_models.GetDentryIdByUuidHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDentryIdByUuidResponse:
        """
        @summary 根据文件DentryUuid获取文件DentryId
        
        @param request: GetDentryIdByUuidRequest
        @param headers: GetDentryIdByUuidHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryIdByUuidResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetDentryIdByUuid',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/queryDentryId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDentryIdByUuidResponse(),
            self.execute(params, req, runtime)
        )

    async def get_dentry_id_by_uuid_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDentryIdByUuidRequest,
        headers: dingtalkdoc__2__0_models.GetDentryIdByUuidHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDentryIdByUuidResponse:
        """
        @summary 根据文件DentryUuid获取文件DentryId
        
        @param request: GetDentryIdByUuidRequest
        @param headers: GetDentryIdByUuidHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDentryIdByUuidResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetDentryIdByUuid',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/queryDentryId',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDentryIdByUuidResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_dentry_id_by_uuid(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDentryIdByUuidRequest,
    ) -> dingtalkdoc__2__0_models.GetDentryIdByUuidResponse:
        """
        @summary 根据文件DentryUuid获取文件DentryId
        
        @param request: GetDentryIdByUuidRequest
        @return: GetDentryIdByUuidResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDentryIdByUuidHeaders()
        return self.get_dentry_id_by_uuid_with_options(dentry_uuid, request, headers, runtime)

    async def get_dentry_id_by_uuid_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDentryIdByUuidRequest,
    ) -> dingtalkdoc__2__0_models.GetDentryIdByUuidResponse:
        """
        @summary 根据文件DentryUuid获取文件DentryId
        
        @param request: GetDentryIdByUuidRequest
        @return: GetDentryIdByUuidResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDentryIdByUuidHeaders()
        return await self.get_dentry_id_by_uuid_with_options_async(dentry_uuid, request, headers, runtime)

    def get_doc_content_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentRequest,
        headers: dingtalkdoc__2__0_models.GetDocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDocContentResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentRequest
        @param headers: GetDocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.generate_cp):
            query['generateCp'] = request.generate_cp
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='GetDocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/me/query/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDocContentResponse(),
            self.execute(params, req, runtime)
        )

    async def get_doc_content_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentRequest,
        headers: dingtalkdoc__2__0_models.GetDocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDocContentResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentRequest
        @param headers: GetDocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.generate_cp):
            query['generateCp'] = request.generate_cp
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='GetDocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/me/query/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDocContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_doc_content(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentRequest,
    ) -> dingtalkdoc__2__0_models.GetDocContentResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentRequest
        @return: GetDocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDocContentHeaders()
        return self.get_doc_content_with_options(dentry_uuid, request, headers, runtime)

    async def get_doc_content_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentRequest,
    ) -> dingtalkdoc__2__0_models.GetDocContentResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentRequest
        @return: GetDocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDocContentHeaders()
        return await self.get_doc_content_with_options_async(dentry_uuid, request, headers, runtime)

    def get_doc_content_for_elmwith_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentForELMRequest,
        headers: dingtalkdoc__2__0_models.GetDocContentForELMHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDocContentForELMResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentForELMRequest
        @param headers: GetDocContentForELMHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocContentForELMResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='GetDocContentForELM',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/elm/me/dentries/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDocContentForELMResponse(),
            self.execute(params, req, runtime)
        )

    async def get_doc_content_for_elmwith_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentForELMRequest,
        headers: dingtalkdoc__2__0_models.GetDocContentForELMHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetDocContentForELMResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentForELMRequest
        @param headers: GetDocContentForELMHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetDocContentForELMResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='GetDocContentForELM',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/elm/me/dentries/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetDocContentForELMResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_doc_content_for_elm(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentForELMRequest,
    ) -> dingtalkdoc__2__0_models.GetDocContentForELMResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentForELMRequest
        @return: GetDocContentForELMResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDocContentForELMHeaders()
        return self.get_doc_content_for_elmwith_options(dentry_uuid, request, headers, runtime)

    async def get_doc_content_for_elm_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetDocContentForELMRequest,
    ) -> dingtalkdoc__2__0_models.GetDocContentForELMResponse:
        """
        @summary 委托权限获取文档内容
        
        @param request: GetDocContentForELMRequest
        @return: GetDocContentForELMResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetDocContentForELMHeaders()
        return await self.get_doc_content_for_elmwith_options_async(dentry_uuid, request, headers, runtime)

    def get_my_space_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetMySpaceRequest,
        headers: dingtalkdoc__2__0_models.GetMySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetMySpaceResponse:
        """
        @summary 获取当前企业下钉盘目录我的文件对应的空间信息
        
        @param request: GetMySpaceRequest
        @param headers: GetMySpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMySpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_my_space):
            query['isMySpace'] = request.is_my_space
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
            action='GetMySpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/me/mySpace/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetMySpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def get_my_space_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetMySpaceRequest,
        headers: dingtalkdoc__2__0_models.GetMySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetMySpaceResponse:
        """
        @summary 获取当前企业下钉盘目录我的文件对应的空间信息
        
        @param request: GetMySpaceRequest
        @param headers: GetMySpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetMySpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.is_my_space):
            query['isMySpace'] = request.is_my_space
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
            action='GetMySpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/me/mySpace/infos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetMySpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_my_space(
        self,
        request: dingtalkdoc__2__0_models.GetMySpaceRequest,
    ) -> dingtalkdoc__2__0_models.GetMySpaceResponse:
        """
        @summary 获取当前企业下钉盘目录我的文件对应的空间信息
        
        @param request: GetMySpaceRequest
        @return: GetMySpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetMySpaceHeaders()
        return self.get_my_space_with_options(request, headers, runtime)

    async def get_my_space_async(
        self,
        request: dingtalkdoc__2__0_models.GetMySpaceRequest,
    ) -> dingtalkdoc__2__0_models.GetMySpaceResponse:
        """
        @summary 获取当前企业下钉盘目录我的文件对应的空间信息
        
        @param request: GetMySpaceRequest
        @return: GetMySpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetMySpaceHeaders()
        return await self.get_my_space_with_options_async(request, headers, runtime)

    def get_schema_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
        headers: dingtalkdoc__2__0_models.GetSchemaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        """
        @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
        
        @param request: GetSchemaRequest
        @param headers: GetSchemaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSchemaResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSchema',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/schemas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSchemaResponse(),
            self.execute(params, req, runtime)
        )

    async def get_schema_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
        headers: dingtalkdoc__2__0_models.GetSchemaHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        """
        @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
        
        @param request: GetSchemaRequest
        @param headers: GetSchemaHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSchemaResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSchema',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/schemas',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSchemaResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_schema(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        """
        @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
        
        @param request: GetSchemaRequest
        @return: GetSchemaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSchemaHeaders()
        return self.get_schema_with_options(team_id, request, headers, runtime)

    async def get_schema_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetSchemaRequest,
    ) -> dingtalkdoc__2__0_models.GetSchemaResponse:
        """
        @summary 查询小组主页schema （包括轮播图、公告、便捷入口）
        
        @param request: GetSchemaRequest
        @return: GetSchemaResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSchemaHeaders()
        return await self.get_schema_with_options_async(team_id, request, headers, runtime)

    def get_space_directories_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
        headers: dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        """
        @summary 查询目录树
        
        @param request: GetSpaceDirectoriesRequest
        @param headers: GetSpaceDirectoriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceDirectoriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dentry_id):
            query['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSpaceDirectories',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/directories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_space_directories_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
        headers: dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        """
        @summary 查询目录树
        
        @param request: GetSpaceDirectoriesRequest
        @param headers: GetSpaceDirectoriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetSpaceDirectoriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.dentry_id):
            query['dentryId'] = request.dentry_id
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetSpaceDirectories',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/directories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_space_directories(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        """
        @summary 查询目录树
        
        @param request: GetSpaceDirectoriesRequest
        @return: GetSpaceDirectoriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders()
        return self.get_space_directories_with_options(space_id, request, headers, runtime)

    async def get_space_directories_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.GetSpaceDirectoriesRequest,
    ) -> dingtalkdoc__2__0_models.GetSpaceDirectoriesResponse:
        """
        @summary 查询目录树
        
        @param request: GetSpaceDirectoriesRequest
        @return: GetSpaceDirectoriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetSpaceDirectoriesHeaders()
        return await self.get_space_directories_with_options_async(space_id, request, headers, runtime)

    def get_star_info_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetStarInfoRequest,
        headers: dingtalkdoc__2__0_models.GetStarInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetStarInfoResponse:
        """
        @summary 获取星标信息
        
        @param request: GetStarInfoRequest
        @param headers: GetStarInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStarInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetStarInfo',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/starInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetStarInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_star_info_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetStarInfoRequest,
        headers: dingtalkdoc__2__0_models.GetStarInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetStarInfoResponse:
        """
        @summary 获取星标信息
        
        @param request: GetStarInfoRequest
        @param headers: GetStarInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetStarInfoResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetStarInfo',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/starInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetStarInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_star_info(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetStarInfoRequest,
    ) -> dingtalkdoc__2__0_models.GetStarInfoResponse:
        """
        @summary 获取星标信息
        
        @param request: GetStarInfoRequest
        @return: GetStarInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetStarInfoHeaders()
        return self.get_star_info_with_options(dentry_uuid, request, headers, runtime)

    async def get_star_info_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.GetStarInfoRequest,
    ) -> dingtalkdoc__2__0_models.GetStarInfoResponse:
        """
        @summary 获取星标信息
        
        @param request: GetStarInfoRequest
        @return: GetStarInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetStarInfoHeaders()
        return await self.get_star_info_with_options_async(dentry_uuid, request, headers, runtime)

    def get_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
        headers: dingtalkdoc__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        """
        @summary 查询小组详情
        
        @param request: GetTeamRequest
        @param headers: GetTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def get_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
        headers: dingtalkdoc__2__0_models.GetTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        """
        @summary 查询小组详情
        
        @param request: GetTeamRequest
        @param headers: GetTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTeamResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        """
        @summary 查询小组详情
        
        @param request: GetTeamRequest
        @return: GetTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTeamHeaders()
        return self.get_team_with_options(team_id, request, headers, runtime)

    async def get_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.GetTeamRequest,
    ) -> dingtalkdoc__2__0_models.GetTeamResponse:
        """
        @summary 查询小组详情
        
        @param request: GetTeamRequest
        @return: GetTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTeamHeaders()
        return await self.get_team_with_options_async(team_id, request, headers, runtime)

    def get_total_number_of_dentries_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        """
        @summary 获取知识库下的总节点数
        
        @param request: GetTotalNumberOfDentriesRequest
        @param headers: GetTotalNumberOfDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTotalNumberOfDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_folder):
            query['includeFolder'] = request.include_folder
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_types):
            query['spaceTypes'] = request.space_types
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
            action='GetTotalNumberOfDentries',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/statistics/dentryCounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_total_number_of_dentries_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        """
        @summary 获取知识库下的总节点数
        
        @param request: GetTotalNumberOfDentriesRequest
        @param headers: GetTotalNumberOfDentriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTotalNumberOfDentriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_folder):
            query['includeFolder'] = request.include_folder
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_types):
            query['spaceTypes'] = request.space_types
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
            action='GetTotalNumberOfDentries',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/statistics/dentryCounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_total_number_of_dentries(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        """
        @summary 获取知识库下的总节点数
        
        @param request: GetTotalNumberOfDentriesRequest
        @return: GetTotalNumberOfDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders()
        return self.get_total_number_of_dentries_with_options(request, headers, runtime)

    async def get_total_number_of_dentries_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfDentriesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfDentriesResponse:
        """
        @summary 获取知识库下的总节点数
        
        @param request: GetTotalNumberOfDentriesRequest
        @return: GetTotalNumberOfDentriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfDentriesHeaders()
        return await self.get_total_number_of_dentries_with_options_async(request, headers, runtime)

    def get_total_number_of_spaces_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        """
        @summary 获取知识库总数
        
        @param request: GetTotalNumberOfSpacesRequest
        @param headers: GetTotalNumberOfSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTotalNumberOfSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetTotalNumberOfSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/statistics/spaceCounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def get_total_number_of_spaces_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
        headers: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        """
        @summary 获取知识库总数
        
        @param request: GetTotalNumberOfSpacesRequest
        @param headers: GetTotalNumberOfSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetTotalNumberOfSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='GetTotalNumberOfSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/statistics/spaceCounts',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_total_number_of_spaces(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        """
        @summary 获取知识库总数
        
        @param request: GetTotalNumberOfSpacesRequest
        @return: GetTotalNumberOfSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders()
        return self.get_total_number_of_spaces_with_options(request, headers, runtime)

    async def get_total_number_of_spaces_async(
        self,
        request: dingtalkdoc__2__0_models.GetTotalNumberOfSpacesRequest,
    ) -> dingtalkdoc__2__0_models.GetTotalNumberOfSpacesResponse:
        """
        @summary 获取知识库总数
        
        @param request: GetTotalNumberOfSpacesRequest
        @return: GetTotalNumberOfSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetTotalNumberOfSpacesHeaders()
        return await self.get_total_number_of_spaces_with_options_async(request, headers, runtime)

    def get_user_info_by_open_token_with_options(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
        headers: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        """
        @summary 查询文档免登的用户信息
        
        @param request: GetUserInfoByOpenTokenRequest
        @param headers: GetUserInfoByOpenTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserInfoByOpenTokenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.open_token):
            query['openToken'] = request.open_token
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
            action='GetUserInfoByOpenToken',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse(),
            self.execute(params, req, runtime)
        )

    async def get_user_info_by_open_token_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
        headers: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        """
        @summary 查询文档免登的用户信息
        
        @param request: GetUserInfoByOpenTokenRequest
        @param headers: GetUserInfoByOpenTokenHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUserInfoByOpenTokenResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.doc_key):
            query['docKey'] = request.doc_key
        if not UtilClient.is_unset(request.open_token):
            query['openToken'] = request.open_token
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
            action='GetUserInfoByOpenToken',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/userInfos',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_user_info_by_open_token(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        """
        @summary 查询文档免登的用户信息
        
        @param request: GetUserInfoByOpenTokenRequest
        @return: GetUserInfoByOpenTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders()
        return self.get_user_info_by_open_token_with_options(request, headers, runtime)

    async def get_user_info_by_open_token_async(
        self,
        request: dingtalkdoc__2__0_models.GetUserInfoByOpenTokenRequest,
    ) -> dingtalkdoc__2__0_models.GetUserInfoByOpenTokenResponse:
        """
        @summary 查询文档免登的用户信息
        
        @param request: GetUserInfoByOpenTokenRequest
        @return: GetUserInfoByOpenTokenResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUserInfoByOpenTokenHeaders()
        return await self.get_user_info_by_open_token_with_options_async(request, headers, runtime)

    def get_uuid_by_dentry_id_with_options(
        self,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.GetUuidByDentryIdRequest,
        headers: dingtalkdoc__2__0_models.GetUuidByDentryIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUuidByDentryIdResponse:
        """
        @summary 根据文件DentryId获取文件DentryUuid
        
        @param request: GetUuidByDentryIdRequest
        @param headers: GetUuidByDentryIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUuidByDentryIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_id):
            query['spaceId'] = request.space_id
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
            action='GetUuidByDentryId',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_id}/queryDentryUuid',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUuidByDentryIdResponse(),
            self.execute(params, req, runtime)
        )

    async def get_uuid_by_dentry_id_with_options_async(
        self,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.GetUuidByDentryIdRequest,
        headers: dingtalkdoc__2__0_models.GetUuidByDentryIdHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.GetUuidByDentryIdResponse:
        """
        @summary 根据文件DentryId获取文件DentryUuid
        
        @param request: GetUuidByDentryIdRequest
        @param headers: GetUuidByDentryIdHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetUuidByDentryIdResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_id):
            query['spaceId'] = request.space_id
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
            action='GetUuidByDentryId',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_id}/queryDentryUuid',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.GetUuidByDentryIdResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_uuid_by_dentry_id(
        self,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.GetUuidByDentryIdRequest,
    ) -> dingtalkdoc__2__0_models.GetUuidByDentryIdResponse:
        """
        @summary 根据文件DentryId获取文件DentryUuid
        
        @param request: GetUuidByDentryIdRequest
        @return: GetUuidByDentryIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUuidByDentryIdHeaders()
        return self.get_uuid_by_dentry_id_with_options(dentry_id, request, headers, runtime)

    async def get_uuid_by_dentry_id_async(
        self,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.GetUuidByDentryIdRequest,
    ) -> dingtalkdoc__2__0_models.GetUuidByDentryIdResponse:
        """
        @summary 根据文件DentryId获取文件DentryUuid
        
        @param request: GetUuidByDentryIdRequest
        @return: GetUuidByDentryIdResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.GetUuidByDentryIdHeaders()
        return await self.get_uuid_by_dentry_id_with_options_async(dentry_id, request, headers, runtime)

    def handover_team_without_auth_with_options(
        self,
        request: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthRequest,
        headers: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse:
        """
        @summary 以超级管理员身份转交小组
        
        @param request: HandoverTeamWithoutAuthRequest
        @param headers: HandoverTeamWithoutAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HandoverTeamWithoutAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='HandoverTeamWithoutAuth',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/members/handoverWithoutAuth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse(),
            self.execute(params, req, runtime)
        )

    async def handover_team_without_auth_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthRequest,
        headers: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse:
        """
        @summary 以超级管理员身份转交小组
        
        @param request: HandoverTeamWithoutAuthRequest
        @param headers: HandoverTeamWithoutAuthHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: HandoverTeamWithoutAuthResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='HandoverTeamWithoutAuth',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/members/handoverWithoutAuth',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse(),
            await self.execute_async(params, req, runtime)
        )

    def handover_team_without_auth(
        self,
        request: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthRequest,
    ) -> dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse:
        """
        @summary 以超级管理员身份转交小组
        
        @param request: HandoverTeamWithoutAuthRequest
        @return: HandoverTeamWithoutAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.HandoverTeamWithoutAuthHeaders()
        return self.handover_team_without_auth_with_options(request, headers, runtime)

    async def handover_team_without_auth_async(
        self,
        request: dingtalkdoc__2__0_models.HandoverTeamWithoutAuthRequest,
    ) -> dingtalkdoc__2__0_models.HandoverTeamWithoutAuthResponse:
        """
        @summary 以超级管理员身份转交小组
        
        @param request: HandoverTeamWithoutAuthRequest
        @return: HandoverTeamWithoutAuthResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.HandoverTeamWithoutAuthHeaders()
        return await self.handover_team_without_auth_with_options_async(request, headers, runtime)

    def list_feeds_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
        headers: dingtalkdoc__2__0_models.ListFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        """
        @summary 查询小组动态
        
        @param request: ListFeedsRequest
        @param headers: ListFeedsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFeedsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.exclude_file):
            query['excludeFile'] = request.exclude_file
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListFeeds',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/feeds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListFeedsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_feeds_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
        headers: dingtalkdoc__2__0_models.ListFeedsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        """
        @summary 查询小组动态
        
        @param request: ListFeedsRequest
        @param headers: ListFeedsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListFeedsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.exclude_file):
            query['excludeFile'] = request.exclude_file
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListFeeds',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/feeds',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListFeedsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_feeds(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        """
        @summary 查询小组动态
        
        @param request: ListFeedsRequest
        @return: ListFeedsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListFeedsHeaders()
        return self.list_feeds_with_options(team_id, request, headers, runtime)

    async def list_feeds_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListFeedsRequest,
    ) -> dingtalkdoc__2__0_models.ListFeedsResponse:
        """
        @summary 查询小组动态
        
        @param request: ListFeedsRequest
        @return: ListFeedsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListFeedsHeaders()
        return await self.list_feeds_with_options_async(team_id, request, headers, runtime)

    def list_hot_docs_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
        headers: dingtalkdoc__2__0_models.ListHotDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        """
        @summary 查询小组热门文档
        
        @param request: ListHotDocsRequest
        @param headers: ListHotDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListHotDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListHotDocs',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/hotDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListHotDocsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_hot_docs_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
        headers: dingtalkdoc__2__0_models.ListHotDocsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        """
        @summary 查询小组热门文档
        
        @param request: ListHotDocsRequest
        @param headers: ListHotDocsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListHotDocsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListHotDocs',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/hotDocs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListHotDocsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_hot_docs(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        """
        @summary 查询小组热门文档
        
        @param request: ListHotDocsRequest
        @return: ListHotDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListHotDocsHeaders()
        return self.list_hot_docs_with_options(team_id, request, headers, runtime)

    async def list_hot_docs_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListHotDocsRequest,
    ) -> dingtalkdoc__2__0_models.ListHotDocsResponse:
        """
        @summary 查询小组热门文档
        
        @param request: ListHotDocsRequest
        @return: ListHotDocsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListHotDocsHeaders()
        return await self.list_hot_docs_with_options_async(team_id, request, headers, runtime)

    def list_pin_spaces_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListPinSpacesRequest,
        headers: dingtalkdoc__2__0_models.ListPinSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListPinSpacesResponse:
        """
        @summary 获取置顶知识库列表
        
        @param request: ListPinSpacesRequest
        @param headers: ListPinSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPinSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListPinSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/pinLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListPinSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def list_pin_spaces_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListPinSpacesRequest,
        headers: dingtalkdoc__2__0_models.ListPinSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListPinSpacesResponse:
        """
        @summary 获取置顶知识库列表
        
        @param request: ListPinSpacesRequest
        @param headers: ListPinSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListPinSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListPinSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/pinLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListPinSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_pin_spaces(
        self,
        request: dingtalkdoc__2__0_models.ListPinSpacesRequest,
    ) -> dingtalkdoc__2__0_models.ListPinSpacesResponse:
        """
        @summary 获取置顶知识库列表
        
        @param request: ListPinSpacesRequest
        @return: ListPinSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListPinSpacesHeaders()
        return self.list_pin_spaces_with_options(request, headers, runtime)

    async def list_pin_spaces_async(
        self,
        request: dingtalkdoc__2__0_models.ListPinSpacesRequest,
    ) -> dingtalkdoc__2__0_models.ListPinSpacesResponse:
        """
        @summary 获取置顶知识库列表
        
        @param request: ListPinSpacesRequest
        @return: ListPinSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListPinSpacesHeaders()
        return await self.list_pin_spaces_with_options_async(request, headers, runtime)

    def list_recents_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListRecentsRequest,
        headers: dingtalkdoc__2__0_models.ListRecentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRecentsResponse:
        """
        @summary 查询文档最近记录列表
        
        @param request: ListRecentsRequest
        @param headers: ListRecentsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecentsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListRecents',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/recentRecords/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRecentsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_recents_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListRecentsRequest,
        headers: dingtalkdoc__2__0_models.ListRecentsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRecentsResponse:
        """
        @summary 查询文档最近记录列表
        
        @param request: ListRecentsRequest
        @param headers: ListRecentsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRecentsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ListRecents',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/recentRecords/lists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRecentsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_recents(
        self,
        request: dingtalkdoc__2__0_models.ListRecentsRequest,
    ) -> dingtalkdoc__2__0_models.ListRecentsResponse:
        """
        @summary 查询文档最近记录列表
        
        @param request: ListRecentsRequest
        @return: ListRecentsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRecentsHeaders()
        return self.list_recents_with_options(request, headers, runtime)

    async def list_recents_async(
        self,
        request: dingtalkdoc__2__0_models.ListRecentsRequest,
    ) -> dingtalkdoc__2__0_models.ListRecentsResponse:
        """
        @summary 查询文档最近记录列表
        
        @param request: ListRecentsRequest
        @return: ListRecentsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRecentsHeaders()
        return await self.list_recents_with_options_async(request, headers, runtime)

    def list_related_space_teams_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        """
        @summary 查询关联了知识库的团队列表
        
        @param request: ListRelatedSpaceTeamsRequest
        @param headers: ListRelatedSpaceTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRelatedSpaceTeamsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListRelatedSpaceTeams',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/relations/spaceTeams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_related_space_teams_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        """
        @summary 查询关联了知识库的团队列表
        
        @param request: ListRelatedSpaceTeamsRequest
        @param headers: ListRelatedSpaceTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRelatedSpaceTeamsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListRelatedSpaceTeams',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/relations/spaceTeams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_related_space_teams(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        """
        @summary 查询关联了知识库的团队列表
        
        @param request: ListRelatedSpaceTeamsRequest
        @return: ListRelatedSpaceTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders()
        return self.list_related_space_teams_with_options(request, headers, runtime)

    async def list_related_space_teams_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedSpaceTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedSpaceTeamsResponse:
        """
        @summary 查询关联了知识库的团队列表
        
        @param request: ListRelatedSpaceTeamsRequest
        @return: ListRelatedSpaceTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedSpaceTeamsHeaders()
        return await self.list_related_space_teams_with_options_async(request, headers, runtime)

    def list_related_teams_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        """
        @summary 查询小组列表
        
        @param request: ListRelatedTeamsRequest
        @param headers: ListRelatedTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRelatedTeamsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListRelatedTeams',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedTeamsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_related_teams_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
        headers: dingtalkdoc__2__0_models.ListRelatedTeamsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        """
        @summary 查询小组列表
        
        @param request: ListRelatedTeamsRequest
        @param headers: ListRelatedTeamsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListRelatedTeamsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListRelatedTeams',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListRelatedTeamsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_related_teams(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        """
        @summary 查询小组列表
        
        @param request: ListRelatedTeamsRequest
        @return: ListRelatedTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedTeamsHeaders()
        return self.list_related_teams_with_options(request, headers, runtime)

    async def list_related_teams_async(
        self,
        request: dingtalkdoc__2__0_models.ListRelatedTeamsRequest,
    ) -> dingtalkdoc__2__0_models.ListRelatedTeamsResponse:
        """
        @summary 查询小组列表
        
        @param request: ListRelatedTeamsRequest
        @return: ListRelatedTeamsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListRelatedTeamsHeaders()
        return await self.list_related_teams_with_options_async(request, headers, runtime)

    def list_space_sections_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
        headers: dingtalkdoc__2__0_models.ListSpaceSectionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        """
        @summary 查询知识库分组
        
        @param request: ListSpaceSectionsRequest
        @param headers: ListSpaceSectionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSpaceSectionsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListSpaceSections',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/spaceSections',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListSpaceSectionsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_space_sections_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
        headers: dingtalkdoc__2__0_models.ListSpaceSectionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        """
        @summary 查询知识库分组
        
        @param request: ListSpaceSectionsRequest
        @param headers: ListSpaceSectionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListSpaceSectionsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListSpaceSections',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/spaceSections',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListSpaceSectionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_space_sections(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        """
        @summary 查询知识库分组
        
        @param request: ListSpaceSectionsRequest
        @return: ListSpaceSectionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListSpaceSectionsHeaders()
        return self.list_space_sections_with_options(team_id, request, headers, runtime)

    async def list_space_sections_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListSpaceSectionsRequest,
    ) -> dingtalkdoc__2__0_models.ListSpaceSectionsResponse:
        """
        @summary 查询知识库分组
        
        @param request: ListSpaceSectionsRequest
        @return: ListSpaceSectionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListSpaceSectionsHeaders()
        return await self.list_space_sections_with_options_async(team_id, request, headers, runtime)

    def list_stars_with_options(
        self,
        request: dingtalkdoc__2__0_models.ListStarsRequest,
        headers: dingtalkdoc__2__0_models.ListStarsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListStarsResponse:
        """
        @summary 获取星标列表
        
        @param request: ListStarsRequest
        @param headers: ListStarsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListStarsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListStars',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/starLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListStarsResponse(),
            self.execute(params, req, runtime)
        )

    async def list_stars_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ListStarsRequest,
        headers: dingtalkdoc__2__0_models.ListStarsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListStarsResponse:
        """
        @summary 获取星标列表
        
        @param request: ListStarsRequest
        @param headers: ListStarsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListStarsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='ListStars',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/starLists/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListStarsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_stars(
        self,
        request: dingtalkdoc__2__0_models.ListStarsRequest,
    ) -> dingtalkdoc__2__0_models.ListStarsResponse:
        """
        @summary 获取星标列表
        
        @param request: ListStarsRequest
        @return: ListStarsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListStarsHeaders()
        return self.list_stars_with_options(request, headers, runtime)

    async def list_stars_async(
        self,
        request: dingtalkdoc__2__0_models.ListStarsRequest,
    ) -> dingtalkdoc__2__0_models.ListStarsResponse:
        """
        @summary 获取星标列表
        
        @param request: ListStarsRequest
        @return: ListStarsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListStarsHeaders()
        return await self.list_stars_with_options_async(request, headers, runtime)

    def list_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.ListTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        """
        @summary 查询小组成员列表
        
        @param request: ListTeamMembersRequest
        @param headers: ListTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListTeamMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def list_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.ListTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        """
        @summary 查询小组成员列表
        
        @param request: ListTeamMembersRequest
        @param headers: ListTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ListTeamMembersResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='ListTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ListTeamMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def list_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        """
        @summary 查询小组成员列表
        
        @param request: ListTeamMembersRequest
        @return: ListTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListTeamMembersHeaders()
        return self.list_team_members_with_options(team_id, request, headers, runtime)

    async def list_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.ListTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.ListTeamMembersResponse:
        """
        @summary 查询小组成员列表
        
        @param request: ListTeamMembersRequest
        @return: ListTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ListTeamMembersHeaders()
        return await self.list_team_members_with_options_async(team_id, request, headers, runtime)

    def mark_star_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.MarkStarRequest,
        headers: dingtalkdoc__2__0_models.MarkStarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MarkStarResponse:
        """
        @summary 标记星标
        
        @param request: MarkStarRequest
        @param headers: MarkStarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MarkStarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='MarkStar',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/stars/mark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MarkStarResponse(),
            self.execute(params, req, runtime)
        )

    async def mark_star_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.MarkStarRequest,
        headers: dingtalkdoc__2__0_models.MarkStarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MarkStarResponse:
        """
        @summary 标记星标
        
        @param request: MarkStarRequest
        @param headers: MarkStarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MarkStarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='MarkStar',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/stars/mark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MarkStarResponse(),
            await self.execute_async(params, req, runtime)
        )

    def mark_star(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.MarkStarRequest,
    ) -> dingtalkdoc__2__0_models.MarkStarResponse:
        """
        @summary 标记星标
        
        @param request: MarkStarRequest
        @return: MarkStarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MarkStarHeaders()
        return self.mark_star_with_options(dentry_uuid, request, headers, runtime)

    async def mark_star_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.MarkStarRequest,
    ) -> dingtalkdoc__2__0_models.MarkStarResponse:
        """
        @summary 标记星标
        
        @param request: MarkStarRequest
        @return: MarkStarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MarkStarHeaders()
        return await self.mark_star_with_options_async(dentry_uuid, request, headers, runtime)

    def move_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
        headers: dingtalkdoc__2__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        """
        @summary 移动知识库节点
        
        @param request: MoveDentryRequest
        @param headers: MoveDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='MoveDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MoveDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def move_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
        headers: dingtalkdoc__2__0_models.MoveDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        """
        @summary 移动知识库节点
        
        @param request: MoveDentryRequest
        @param headers: MoveDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: MoveDentryResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_space_id):
            body['targetSpaceId'] = request.target_space_id
        if not UtilClient.is_unset(request.to_next_dentry_id):
            body['toNextDentryId'] = request.to_next_dentry_id
        if not UtilClient.is_unset(request.to_parent_dentry_id):
            body['toParentDentryId'] = request.to_parent_dentry_id
        if not UtilClient.is_unset(request.to_prev_dentry_id):
            body['toPrevDentryId'] = request.to_prev_dentry_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='MoveDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/move',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.MoveDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def move_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        """
        @summary 移动知识库节点
        
        @param request: MoveDentryRequest
        @return: MoveDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MoveDentryHeaders()
        return self.move_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def move_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.MoveDentryRequest,
    ) -> dingtalkdoc__2__0_models.MoveDentryResponse:
        """
        @summary 移动知识库节点
        
        @param request: MoveDentryRequest
        @return: MoveDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.MoveDentryHeaders()
        return await self.move_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def pin_space_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.PinSpaceRequest,
        headers: dingtalkdoc__2__0_models.PinSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.PinSpaceResponse:
        """
        @summary 置顶知识库
        
        @param request: PinSpaceRequest
        @param headers: PinSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PinSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='PinSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/pin',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.PinSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def pin_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.PinSpaceRequest,
        headers: dingtalkdoc__2__0_models.PinSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.PinSpaceResponse:
        """
        @summary 置顶知识库
        
        @param request: PinSpaceRequest
        @param headers: PinSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PinSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='PinSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/pin',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.PinSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pin_space(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.PinSpaceRequest,
    ) -> dingtalkdoc__2__0_models.PinSpaceResponse:
        """
        @summary 置顶知识库
        
        @param request: PinSpaceRequest
        @return: PinSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.PinSpaceHeaders()
        return self.pin_space_with_options(space_id, request, headers, runtime)

    async def pin_space_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.PinSpaceRequest,
    ) -> dingtalkdoc__2__0_models.PinSpaceResponse:
        """
        @summary 置顶知识库
        
        @param request: PinSpaceRequest
        @return: PinSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.PinSpaceHeaders()
        return await self.pin_space_with_options_async(space_id, request, headers, runtime)

    def query_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
        headers: dingtalkdoc__2__0_models.QueryDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        """
        @summary 查询知识库节点（包括文档和文件夹）
        
        @param request: QueryDentryRequest
        @param headers: QueryDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_space):
            query['includeSpace'] = request.include_space
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def query_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
        headers: dingtalkdoc__2__0_models.QueryDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        """
        @summary 查询知识库节点（包括文档和文件夹）
        
        @param request: QueryDentryRequest
        @param headers: QueryDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.include_space):
            query['includeSpace'] = request.include_space
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QueryDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        """
        @summary 查询知识库节点（包括文档和文件夹）
        
        @param request: QueryDentryRequest
        @return: QueryDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDentryHeaders()
        return self.query_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def query_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.QueryDentryRequest,
    ) -> dingtalkdoc__2__0_models.QueryDentryResponse:
        """
        @summary 查询知识库节点（包括文档和文件夹）
        
        @param request: QueryDentryRequest
        @return: QueryDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDentryHeaders()
        return await self.query_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def query_doc_content_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.QueryDocContentRequest,
        headers: dingtalkdoc__2__0_models.QueryDocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: QueryDocContentRequest
        @param headers: QueryDocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='QueryDocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/query/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDocContentResponse(),
            self.execute(params, req, runtime)
        )

    async def query_doc_content_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.QueryDocContentRequest,
        headers: dingtalkdoc__2__0_models.QueryDocContentHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryDocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: QueryDocContentRequest
        @param headers: QueryDocContentHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryDocContentResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.target_format):
            query['targetFormat'] = request.target_format
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
            action='QueryDocContent',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/query/{dentry_uuid}/contents',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryDocContentResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_doc_content(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.QueryDocContentRequest,
    ) -> dingtalkdoc__2__0_models.QueryDocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: QueryDocContentRequest
        @return: QueryDocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDocContentHeaders()
        return self.query_doc_content_with_options(dentry_uuid, request, headers, runtime)

    async def query_doc_content_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.QueryDocContentRequest,
    ) -> dingtalkdoc__2__0_models.QueryDocContentResponse:
        """
        @summary 获取文档内容
        
        @param request: QueryDocContentRequest
        @return: QueryDocContentResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryDocContentHeaders()
        return await self.query_doc_content_with_options_async(dentry_uuid, request, headers, runtime)

    def query_item_by_url_with_options(
        self,
        request: dingtalkdoc__2__0_models.QueryItemByUrlRequest,
        headers: dingtalkdoc__2__0_models.QueryItemByUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryItemByUrlResponse:
        """
        @summary 根据链接查询节点或知识库信息
        
        @param request: QueryItemByUrlRequest
        @param headers: QueryItemByUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryItemByUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.url):
            query['url'] = request.url
        if not UtilClient.is_unset(request.with_statistical_info):
            query['withStatisticalInfo'] = request.with_statistical_info
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
            action='QueryItemByUrl',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryItemByUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def query_item_by_url_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.QueryItemByUrlRequest,
        headers: dingtalkdoc__2__0_models.QueryItemByUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryItemByUrlResponse:
        """
        @summary 根据链接查询节点或知识库信息
        
        @param request: QueryItemByUrlRequest
        @param headers: QueryItemByUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryItemByUrlResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.url):
            query['url'] = request.url
        if not UtilClient.is_unset(request.with_statistical_info):
            query['withStatisticalInfo'] = request.with_statistical_info
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
            action='QueryItemByUrl',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/items',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryItemByUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_item_by_url(
        self,
        request: dingtalkdoc__2__0_models.QueryItemByUrlRequest,
    ) -> dingtalkdoc__2__0_models.QueryItemByUrlResponse:
        """
        @summary 根据链接查询节点或知识库信息
        
        @param request: QueryItemByUrlRequest
        @return: QueryItemByUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryItemByUrlHeaders()
        return self.query_item_by_url_with_options(request, headers, runtime)

    async def query_item_by_url_async(
        self,
        request: dingtalkdoc__2__0_models.QueryItemByUrlRequest,
    ) -> dingtalkdoc__2__0_models.QueryItemByUrlResponse:
        """
        @summary 根据链接查询节点或知识库信息
        
        @param request: QueryItemByUrlRequest
        @return: QueryItemByUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryItemByUrlHeaders()
        return await self.query_item_by_url_with_options_async(request, headers, runtime)

    def query_mine_space_with_options(
        self,
        union_id: str,
        headers: dingtalkdoc__2__0_models.QueryMineSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        """
        @summary 查询用户的「我的文档」
        
        @param headers: QueryMineSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMineSpaceResponse
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
            action='QueryMineSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/users/{union_id}/mine',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryMineSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_mine_space_with_options_async(
        self,
        union_id: str,
        headers: dingtalkdoc__2__0_models.QueryMineSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        """
        @summary 查询用户的「我的文档」
        
        @param headers: QueryMineSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryMineSpaceResponse
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
            action='QueryMineSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/users/{union_id}/mine',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryMineSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_mine_space(
        self,
        union_id: str,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        """
        @summary 查询用户的「我的文档」
        
        @return: QueryMineSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryMineSpaceHeaders()
        return self.query_mine_space_with_options(union_id, headers, runtime)

    async def query_mine_space_async(
        self,
        union_id: str,
    ) -> dingtalkdoc__2__0_models.QueryMineSpaceResponse:
        """
        @summary 查询用户的「我的文档」
        
        @return: QueryMineSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryMineSpaceHeaders()
        return await self.query_mine_space_with_options_async(union_id, headers, runtime)

    def query_recent_list_with_options(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
        headers: dingtalkdoc__2__0_models.QueryRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        """
        @summary 查询最近列表
        
        @param request: QueryRecentListRequest
        @param headers: QueryRecentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecentListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_type):
            query['creatorType'] = request.creator_type
        if not UtilClient.is_unset(request.file_type):
            query['fileType'] = request.file_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.recent_type):
            query['recentType'] = request.recent_type
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
            action='QueryRecentList',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/docs/recent',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryRecentListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_recent_list_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
        headers: dingtalkdoc__2__0_models.QueryRecentListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        """
        @summary 查询最近列表
        
        @param request: QueryRecentListRequest
        @param headers: QueryRecentListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRecentListResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.creator_type):
            query['creatorType'] = request.creator_type
        if not UtilClient.is_unset(request.file_type):
            query['fileType'] = request.file_type
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.recent_type):
            query['recentType'] = request.recent_type
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
            action='QueryRecentList',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/docs/recent',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QueryRecentListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_recent_list(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        """
        @summary 查询最近列表
        
        @param request: QueryRecentListRequest
        @return: QueryRecentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryRecentListHeaders()
        return self.query_recent_list_with_options(request, headers, runtime)

    async def query_recent_list_async(
        self,
        request: dingtalkdoc__2__0_models.QueryRecentListRequest,
    ) -> dingtalkdoc__2__0_models.QueryRecentListResponse:
        """
        @summary 查询最近列表
        
        @param request: QueryRecentListRequest
        @return: QueryRecentListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QueryRecentListHeaders()
        return await self.query_recent_list_with_options_async(request, headers, runtime)

    def query_space_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
        headers: dingtalkdoc__2__0_models.QuerySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        """
        @summary 查询指定知识库信息
        
        @param request: QuerySpaceRequest
        @param headers: QuerySpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QuerySpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QuerySpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def query_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
        headers: dingtalkdoc__2__0_models.QuerySpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        """
        @summary 查询指定知识库信息
        
        @param request: QuerySpaceRequest
        @param headers: QuerySpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QuerySpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='QuerySpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.QuerySpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_space(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        """
        @summary 查询指定知识库信息
        
        @param request: QuerySpaceRequest
        @return: QuerySpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QuerySpaceHeaders()
        return self.query_space_with_options(space_id, request, headers, runtime)

    async def query_space_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.QuerySpaceRequest,
    ) -> dingtalkdoc__2__0_models.QuerySpaceResponse:
        """
        @summary 查询指定知识库信息
        
        @param request: QuerySpaceRequest
        @return: QuerySpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.QuerySpaceHeaders()
        return await self.query_space_with_options_async(space_id, request, headers, runtime)

    def related_spaces_with_options(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
        headers: dingtalkdoc__2__0_models.RelatedSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        """
        @summary 查询与我关联的知识库列表（支持筛选小组）
        
        @param request: RelatedSpacesRequest
        @param headers: RelatedSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RelatedSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
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
            action='RelatedSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/relations/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RelatedSpacesResponse(),
            self.execute(params, req, runtime)
        )

    async def related_spaces_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
        headers: dingtalkdoc__2__0_models.RelatedSpacesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        """
        @summary 查询与我关联的知识库列表（支持筛选小组）
        
        @param request: RelatedSpacesRequest
        @param headers: RelatedSpacesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RelatedSpacesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.team_id):
            query['teamId'] = request.team_id
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
            action='RelatedSpaces',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/relations/spaces',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RelatedSpacesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def related_spaces(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        """
        @summary 查询与我关联的知识库列表（支持筛选小组）
        
        @param request: RelatedSpacesRequest
        @return: RelatedSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RelatedSpacesHeaders()
        return self.related_spaces_with_options(request, headers, runtime)

    async def related_spaces_async(
        self,
        request: dingtalkdoc__2__0_models.RelatedSpacesRequest,
    ) -> dingtalkdoc__2__0_models.RelatedSpacesResponse:
        """
        @summary 查询与我关联的知识库列表（支持筛选小组）
        
        @param request: RelatedSpacesRequest
        @return: RelatedSpacesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RelatedSpacesHeaders()
        return await self.related_spaces_with_options_async(request, headers, runtime)

    def remove_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.RemoveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        """
        @summary 移除小组成员
        
        @param request: RemoveTeamMembersRequest
        @param headers: RemoveTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveTeamMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
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
            action='RemoveTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members/remove',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RemoveTeamMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def remove_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.RemoveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        """
        @summary 移除小组成员
        
        @param request: RemoveTeamMembersRequest
        @param headers: RemoveTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RemoveTeamMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
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
            action='RemoveTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members/remove',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RemoveTeamMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def remove_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        """
        @summary 移除小组成员
        
        @param request: RemoveTeamMembersRequest
        @return: RemoveTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RemoveTeamMembersHeaders()
        return self.remove_team_members_with_options(team_id, request, headers, runtime)

    async def remove_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.RemoveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.RemoveTeamMembersResponse:
        """
        @summary 移除小组成员
        
        @param request: RemoveTeamMembersRequest
        @return: RemoveTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RemoveTeamMembersHeaders()
        return await self.remove_team_members_with_options_async(team_id, request, headers, runtime)

    def rename_dentry_with_options(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
        headers: dingtalkdoc__2__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        """
        @summary 知识库节点（包括文档和文件夹）重命名
        
        @param request: RenameDentryRequest
        @param headers: RenameDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenameDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='RenameDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RenameDentryResponse(),
            self.execute(params, req, runtime)
        )

    async def rename_dentry_with_options_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
        headers: dingtalkdoc__2__0_models.RenameDentryHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        """
        @summary 知识库节点（包括文档和文件夹）重命名
        
        @param request: RenameDentryRequest
        @param headers: RenameDentryHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RenameDentryResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.name):
            query['name'] = request.name
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='RenameDentry',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/dentries/{dentry_id}/rename',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.RenameDentryResponse(),
            await self.execute_async(params, req, runtime)
        )

    def rename_dentry(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        """
        @summary 知识库节点（包括文档和文件夹）重命名
        
        @param request: RenameDentryRequest
        @return: RenameDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RenameDentryHeaders()
        return self.rename_dentry_with_options(space_id, dentry_id, request, headers, runtime)

    async def rename_dentry_async(
        self,
        space_id: str,
        dentry_id: str,
        request: dingtalkdoc__2__0_models.RenameDentryRequest,
    ) -> dingtalkdoc__2__0_models.RenameDentryResponse:
        """
        @summary 知识库节点（包括文档和文件夹）重命名
        
        @param request: RenameDentryRequest
        @return: RenameDentryResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.RenameDentryHeaders()
        return await self.rename_dentry_with_options_async(space_id, dentry_id, request, headers, runtime)

    def save_team_members_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.SaveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        """
        @summary 添加或修改小组成员
        
        @param request: SaveTeamMembersRequest
        @param headers: SaveTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveTeamMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
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
            action='SaveTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SaveTeamMembersResponse(),
            self.execute(params, req, runtime)
        )

    async def save_team_members_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
        headers: dingtalkdoc__2__0_models.SaveTeamMembersHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        """
        @summary 添加或修改小组成员
        
        @param request: SaveTeamMembersRequest
        @param headers: SaveTeamMembersHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveTeamMembersResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.members):
            body['members'] = request.members
        if not UtilClient.is_unset(request.notify):
            body['notify'] = request.notify
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
            action='SaveTeamMembers',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}/members',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SaveTeamMembersResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_team_members(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        """
        @summary 添加或修改小组成员
        
        @param request: SaveTeamMembersRequest
        @return: SaveTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SaveTeamMembersHeaders()
        return self.save_team_members_with_options(team_id, request, headers, runtime)

    async def save_team_members_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.SaveTeamMembersRequest,
    ) -> dingtalkdoc__2__0_models.SaveTeamMembersResponse:
        """
        @summary 添加或修改小组成员
        
        @param request: SaveTeamMembersRequest
        @return: SaveTeamMembersResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SaveTeamMembersHeaders()
        return await self.save_team_members_with_options_async(team_id, request, headers, runtime)

    def search_with_options(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
        headers: dingtalkdoc__2__0_models.SearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        """
        @summary 搜索知识库和节点
        
        @param request: SearchRequest
        @param headers: SearchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_request):
            body['dentryRequest'] = request.dentry_request
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_request):
            body['spaceRequest'] = request.space_request
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='Search',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchResponse(),
            self.execute(params, req, runtime)
        )

    async def search_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
        headers: dingtalkdoc__2__0_models.SearchHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        """
        @summary 搜索知识库和节点
        
        @param request: SearchRequest
        @param headers: SearchHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.dentry_request):
            body['dentryRequest'] = request.dentry_request
        if not UtilClient.is_unset(request.keyword):
            body['keyword'] = request.keyword
        if not UtilClient.is_unset(request.operator_id):
            body['operatorId'] = request.operator_id
        if not UtilClient.is_unset(request.space_request):
            body['spaceRequest'] = request.space_request
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='Search',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        """
        @summary 搜索知识库和节点
        
        @param request: SearchRequest
        @return: SearchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchHeaders()
        return self.search_with_options(request, headers, runtime)

    async def search_async(
        self,
        request: dingtalkdoc__2__0_models.SearchRequest,
    ) -> dingtalkdoc__2__0_models.SearchResponse:
        """
        @summary 搜索知识库和节点
        
        @param request: SearchRequest
        @return: SearchResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchHeaders()
        return await self.search_with_options_async(request, headers, runtime)

    def search_templates_with_options(
        self,
        request: dingtalkdoc__2__0_models.SearchTemplatesRequest,
        headers: dingtalkdoc__2__0_models.SearchTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchTemplatesResponse:
        """
        @summary 搜索模板中心模板
        
        @param request: SearchTemplatesRequest
        @param headers: SearchTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='SearchTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/templates/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def search_templates_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.SearchTemplatesRequest,
        headers: dingtalkdoc__2__0_models.SearchTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.SearchTemplatesResponse:
        """
        @summary 搜索模板中心模板
        
        @param request: SearchTemplatesRequest
        @param headers: SearchTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='SearchTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/templates/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.SearchTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_templates(
        self,
        request: dingtalkdoc__2__0_models.SearchTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.SearchTemplatesResponse:
        """
        @summary 搜索模板中心模板
        
        @param request: SearchTemplatesRequest
        @return: SearchTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchTemplatesHeaders()
        return self.search_templates_with_options(request, headers, runtime)

    async def search_templates_async(
        self,
        request: dingtalkdoc__2__0_models.SearchTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.SearchTemplatesResponse:
        """
        @summary 搜索模板中心模板
        
        @param request: SearchTemplatesRequest
        @return: SearchTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.SearchTemplatesHeaders()
        return await self.search_templates_with_options_async(request, headers, runtime)

    def share_url_with_options(
        self,
        request: dingtalkdoc__2__0_models.ShareUrlRequest,
        headers: dingtalkdoc__2__0_models.ShareUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ShareUrlResponse:
        """
        @summary 获取文件打开链接
        
        @param request: ShareUrlRequest
        @param headers: ShareUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ShareUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ShareUrl',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/shareUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ShareUrlResponse(),
            self.execute(params, req, runtime)
        )

    async def share_url_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.ShareUrlRequest,
        headers: dingtalkdoc__2__0_models.ShareUrlHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.ShareUrlResponse:
        """
        @summary 获取文件打开链接
        
        @param request: ShareUrlRequest
        @param headers: ShareUrlHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ShareUrlResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ShareUrl',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/shareUrls/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.ShareUrlResponse(),
            await self.execute_async(params, req, runtime)
        )

    def share_url(
        self,
        request: dingtalkdoc__2__0_models.ShareUrlRequest,
    ) -> dingtalkdoc__2__0_models.ShareUrlResponse:
        """
        @summary 获取文件打开链接
        
        @param request: ShareUrlRequest
        @return: ShareUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ShareUrlHeaders()
        return self.share_url_with_options(request, headers, runtime)

    async def share_url_async(
        self,
        request: dingtalkdoc__2__0_models.ShareUrlRequest,
    ) -> dingtalkdoc__2__0_models.ShareUrlResponse:
        """
        @summary 获取文件打开链接
        
        @param request: ShareUrlRequest
        @return: ShareUrlResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.ShareUrlHeaders()
        return await self.share_url_with_options_async(request, headers, runtime)

    def team_templates_with_options(
        self,
        request: dingtalkdoc__2__0_models.TeamTemplatesRequest,
        headers: dingtalkdoc__2__0_models.TeamTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.TeamTemplatesResponse:
        """
        @summary 获取知识库模板列表
        
        @param request: TeamTemplatesRequest
        @param headers: TeamTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TeamTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='TeamTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/workspaces/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.TeamTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def team_templates_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.TeamTemplatesRequest,
        headers: dingtalkdoc__2__0_models.TeamTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.TeamTemplatesResponse:
        """
        @summary 获取知识库模板列表
        
        @param request: TeamTemplatesRequest
        @param headers: TeamTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TeamTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='TeamTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/workspaces/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.TeamTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def team_templates(
        self,
        request: dingtalkdoc__2__0_models.TeamTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.TeamTemplatesResponse:
        """
        @summary 获取知识库模板列表
        
        @param request: TeamTemplatesRequest
        @return: TeamTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.TeamTemplatesHeaders()
        return self.team_templates_with_options(request, headers, runtime)

    async def team_templates_async(
        self,
        request: dingtalkdoc__2__0_models.TeamTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.TeamTemplatesResponse:
        """
        @summary 获取知识库模板列表
        
        @param request: TeamTemplatesRequest
        @return: TeamTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.TeamTemplatesHeaders()
        return await self.team_templates_with_options_async(request, headers, runtime)

    def template_categories_with_options(
        self,
        request: dingtalkdoc__2__0_models.TemplateCategoriesRequest,
        headers: dingtalkdoc__2__0_models.TemplateCategoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.TemplateCategoriesResponse:
        """
        @summary 获取模板分类列表
        
        @param request: TemplateCategoriesRequest
        @param headers: TemplateCategoriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TemplateCategoriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='TemplateCategories',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/templates/categories/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.TemplateCategoriesResponse(),
            self.execute(params, req, runtime)
        )

    async def template_categories_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.TemplateCategoriesRequest,
        headers: dingtalkdoc__2__0_models.TemplateCategoriesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.TemplateCategoriesResponse:
        """
        @summary 获取模板分类列表
        
        @param request: TemplateCategoriesRequest
        @param headers: TemplateCategoriesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: TemplateCategoriesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
        if not UtilClient.is_unset(request.param):
            body['param'] = request.param
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
            action='TemplateCategories',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/templates/categories/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.TemplateCategoriesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def template_categories(
        self,
        request: dingtalkdoc__2__0_models.TemplateCategoriesRequest,
    ) -> dingtalkdoc__2__0_models.TemplateCategoriesResponse:
        """
        @summary 获取模板分类列表
        
        @param request: TemplateCategoriesRequest
        @return: TemplateCategoriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.TemplateCategoriesHeaders()
        return self.template_categories_with_options(request, headers, runtime)

    async def template_categories_async(
        self,
        request: dingtalkdoc__2__0_models.TemplateCategoriesRequest,
    ) -> dingtalkdoc__2__0_models.TemplateCategoriesResponse:
        """
        @summary 获取模板分类列表
        
        @param request: TemplateCategoriesRequest
        @return: TemplateCategoriesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.TemplateCategoriesHeaders()
        return await self.template_categories_with_options_async(request, headers, runtime)

    def unmark_star_with_options(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.UnmarkStarRequest,
        headers: dingtalkdoc__2__0_models.UnmarkStarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UnmarkStarResponse:
        """
        @summary 取消标记星标
        
        @param request: UnmarkStarRequest
        @param headers: UnmarkStarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnmarkStarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='UnmarkStar',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/stars/unmark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UnmarkStarResponse(),
            self.execute(params, req, runtime)
        )

    async def unmark_star_with_options_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.UnmarkStarRequest,
        headers: dingtalkdoc__2__0_models.UnmarkStarHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UnmarkStarResponse:
        """
        @summary 取消标记星标
        
        @param request: UnmarkStarRequest
        @param headers: UnmarkStarHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnmarkStarResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='UnmarkStar',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/dentries/{dentry_uuid}/stars/unmark',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UnmarkStarResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unmark_star(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.UnmarkStarRequest,
    ) -> dingtalkdoc__2__0_models.UnmarkStarResponse:
        """
        @summary 取消标记星标
        
        @param request: UnmarkStarRequest
        @return: UnmarkStarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UnmarkStarHeaders()
        return self.unmark_star_with_options(dentry_uuid, request, headers, runtime)

    async def unmark_star_async(
        self,
        dentry_uuid: str,
        request: dingtalkdoc__2__0_models.UnmarkStarRequest,
    ) -> dingtalkdoc__2__0_models.UnmarkStarResponse:
        """
        @summary 取消标记星标
        
        @param request: UnmarkStarRequest
        @return: UnmarkStarResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UnmarkStarHeaders()
        return await self.unmark_star_with_options_async(dentry_uuid, request, headers, runtime)

    def unpin_space_with_options(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.UnpinSpaceRequest,
        headers: dingtalkdoc__2__0_models.UnpinSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UnpinSpaceResponse:
        """
        @summary 取消置顶知识库
        
        @param request: UnpinSpaceRequest
        @param headers: UnpinSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnpinSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='UnpinSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/unpin',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UnpinSpaceResponse(),
            self.execute(params, req, runtime)
        )

    async def unpin_space_with_options_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.UnpinSpaceRequest,
        headers: dingtalkdoc__2__0_models.UnpinSpaceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UnpinSpaceResponse:
        """
        @summary 取消置顶知识库
        
        @param request: UnpinSpaceRequest
        @param headers: UnpinSpaceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UnpinSpaceResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
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
            action='UnpinSpace',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/spaces/{space_id}/unpin',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UnpinSpaceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def unpin_space(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.UnpinSpaceRequest,
    ) -> dingtalkdoc__2__0_models.UnpinSpaceResponse:
        """
        @summary 取消置顶知识库
        
        @param request: UnpinSpaceRequest
        @return: UnpinSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UnpinSpaceHeaders()
        return self.unpin_space_with_options(space_id, request, headers, runtime)

    async def unpin_space_async(
        self,
        space_id: str,
        request: dingtalkdoc__2__0_models.UnpinSpaceRequest,
    ) -> dingtalkdoc__2__0_models.UnpinSpaceResponse:
        """
        @summary 取消置顶知识库
        
        @param request: UnpinSpaceRequest
        @return: UnpinSpaceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UnpinSpaceHeaders()
        return await self.unpin_space_with_options_async(space_id, request, headers, runtime)

    def update_team_with_options(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
        headers: dingtalkdoc__2__0_models.UpdateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        """
        @summary 更新小组
        
        @param request: UpdateTeamRequest
        @param headers: UpdateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='UpdateTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UpdateTeamResponse(),
            self.execute(params, req, runtime)
        )

    async def update_team_with_options_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
        headers: dingtalkdoc__2__0_models.UpdateTeamHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        """
        @summary 更新小组
        
        @param request: UpdateTeamRequest
        @param headers: UpdateTeamHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTeamResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.name):
            body['name'] = request.name
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
            action='UpdateTeam',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/teams/{team_id}',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UpdateTeamResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_team(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        """
        @summary 更新小组
        
        @param request: UpdateTeamRequest
        @return: UpdateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UpdateTeamHeaders()
        return self.update_team_with_options(team_id, request, headers, runtime)

    async def update_team_async(
        self,
        team_id: str,
        request: dingtalkdoc__2__0_models.UpdateTeamRequest,
    ) -> dingtalkdoc__2__0_models.UpdateTeamResponse:
        """
        @summary 更新小组
        
        @param request: UpdateTeamRequest
        @return: UpdateTeamResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UpdateTeamHeaders()
        return await self.update_team_with_options_async(team_id, request, headers, runtime)

    def user_templates_with_options(
        self,
        request: dingtalkdoc__2__0_models.UserTemplatesRequest,
        headers: dingtalkdoc__2__0_models.UserTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UserTemplatesResponse:
        """
        @summary 用户模板列表
        
        @param request: UserTemplatesRequest
        @param headers: UserTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UserTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='UserTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/users/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UserTemplatesResponse(),
            self.execute(params, req, runtime)
        )

    async def user_templates_with_options_async(
        self,
        request: dingtalkdoc__2__0_models.UserTemplatesRequest,
        headers: dingtalkdoc__2__0_models.UserTemplatesHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkdoc__2__0_models.UserTemplatesResponse:
        """
        @summary 用户模板列表
        
        @param request: UserTemplatesRequest
        @param headers: UserTemplatesHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UserTemplatesResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.operator_id):
            query['operatorId'] = request.operator_id
        body = {}
        if not UtilClient.is_unset(request.option):
            body['option'] = request.option
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
            action='UserTemplates',
            version='doc_2.0',
            protocol='HTTP',
            pathname=f'/v2.0/doc/users/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkdoc__2__0_models.UserTemplatesResponse(),
            await self.execute_async(params, req, runtime)
        )

    def user_templates(
        self,
        request: dingtalkdoc__2__0_models.UserTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.UserTemplatesResponse:
        """
        @summary 用户模板列表
        
        @param request: UserTemplatesRequest
        @return: UserTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UserTemplatesHeaders()
        return self.user_templates_with_options(request, headers, runtime)

    async def user_templates_async(
        self,
        request: dingtalkdoc__2__0_models.UserTemplatesRequest,
    ) -> dingtalkdoc__2__0_models.UserTemplatesResponse:
        """
        @summary 用户模板列表
        
        @param request: UserTemplatesRequest
        @return: UserTemplatesResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkdoc__2__0_models.UserTemplatesHeaders()
        return await self.user_templates_with_options_async(request, headers, runtime)
