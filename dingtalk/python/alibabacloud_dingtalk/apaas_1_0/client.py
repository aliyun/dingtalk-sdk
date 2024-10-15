# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.apaas_1_0 import models as dingtalkapaas__1__0_models
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

    def batch_create_template_with_options(
        self,
        request: dingtalkapaas__1__0_models.BatchCreateTemplateRequest,
        headers: dingtalkapaas__1__0_models.BatchCreateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchCreateTemplateResponse:
        """
        @summary 批量创建模板
        
        @param request: BatchCreateTemplateRequest
        @param headers: BatchCreateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_list):
            body['templateList'] = request.template_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchCreateTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchCreateTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_create_template_with_options_async(
        self,
        request: dingtalkapaas__1__0_models.BatchCreateTemplateRequest,
        headers: dingtalkapaas__1__0_models.BatchCreateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchCreateTemplateResponse:
        """
        @summary 批量创建模板
        
        @param request: BatchCreateTemplateRequest
        @param headers: BatchCreateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchCreateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_list):
            body['templateList'] = request.template_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchCreateTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchCreateTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_create_template(
        self,
        request: dingtalkapaas__1__0_models.BatchCreateTemplateRequest,
    ) -> dingtalkapaas__1__0_models.BatchCreateTemplateResponse:
        """
        @summary 批量创建模板
        
        @param request: BatchCreateTemplateRequest
        @return: BatchCreateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchCreateTemplateHeaders()
        return self.batch_create_template_with_options(request, headers, runtime)

    async def batch_create_template_async(
        self,
        request: dingtalkapaas__1__0_models.BatchCreateTemplateRequest,
    ) -> dingtalkapaas__1__0_models.BatchCreateTemplateResponse:
        """
        @summary 批量创建模板
        
        @param request: BatchCreateTemplateRequest
        @return: BatchCreateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchCreateTemplateHeaders()
        return await self.batch_create_template_with_options_async(request, headers, runtime)

    def batch_query_by_template_key_with_options(
        self,
        request: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyRequest,
        headers: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse:
        """
        @summary 批量查询模板
        
        @param request: BatchQueryByTemplateKeyRequest
        @param headers: BatchQueryByTemplateKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryByTemplateKeyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_keys):
            body['templateKeys'] = request.template_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryByTemplateKey',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_query_by_template_key_with_options_async(
        self,
        request: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyRequest,
        headers: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse:
        """
        @summary 批量查询模板
        
        @param request: BatchQueryByTemplateKeyRequest
        @param headers: BatchQueryByTemplateKeyHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchQueryByTemplateKeyResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_keys):
            body['templateKeys'] = request.template_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchQueryByTemplateKey',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_query_by_template_key(
        self,
        request: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyRequest,
    ) -> dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse:
        """
        @summary 批量查询模板
        
        @param request: BatchQueryByTemplateKeyRequest
        @return: BatchQueryByTemplateKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchQueryByTemplateKeyHeaders()
        return self.batch_query_by_template_key_with_options(request, headers, runtime)

    async def batch_query_by_template_key_async(
        self,
        request: dingtalkapaas__1__0_models.BatchQueryByTemplateKeyRequest,
    ) -> dingtalkapaas__1__0_models.BatchQueryByTemplateKeyResponse:
        """
        @summary 批量查询模板
        
        @param request: BatchQueryByTemplateKeyRequest
        @return: BatchQueryByTemplateKeyResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchQueryByTemplateKeyHeaders()
        return await self.batch_query_by_template_key_with_options_async(request, headers, runtime)

    def batch_update_template_with_options(
        self,
        request: dingtalkapaas__1__0_models.BatchUpdateTemplateRequest,
        headers: dingtalkapaas__1__0_models.BatchUpdateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchUpdateTemplateResponse:
        """
        @summary 批量修改模板
        
        @param request: BatchUpdateTemplateRequest
        @param headers: BatchUpdateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_list):
            body['templateList'] = request.template_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchUpdateTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchUpdateTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def batch_update_template_with_options_async(
        self,
        request: dingtalkapaas__1__0_models.BatchUpdateTemplateRequest,
        headers: dingtalkapaas__1__0_models.BatchUpdateTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.BatchUpdateTemplateResponse:
        """
        @summary 批量修改模板
        
        @param request: BatchUpdateTemplateRequest
        @param headers: BatchUpdateTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: BatchUpdateTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_list):
            body['templateList'] = request.template_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='BatchUpdateTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.BatchUpdateTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def batch_update_template(
        self,
        request: dingtalkapaas__1__0_models.BatchUpdateTemplateRequest,
    ) -> dingtalkapaas__1__0_models.BatchUpdateTemplateResponse:
        """
        @summary 批量修改模板
        
        @param request: BatchUpdateTemplateRequest
        @return: BatchUpdateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchUpdateTemplateHeaders()
        return self.batch_update_template_with_options(request, headers, runtime)

    async def batch_update_template_async(
        self,
        request: dingtalkapaas__1__0_models.BatchUpdateTemplateRequest,
    ) -> dingtalkapaas__1__0_models.BatchUpdateTemplateResponse:
        """
        @summary 批量修改模板
        
        @param request: BatchUpdateTemplateRequest
        @return: BatchUpdateTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.BatchUpdateTemplateHeaders()
        return await self.batch_update_template_with_options_async(request, headers, runtime)

    def query_industry_tag_list_with_options(
        self,
        headers: dingtalkapaas__1__0_models.QueryIndustryTagListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryIndustryTagListResponse:
        """
        @summary 查询行业标签
        
        @param headers: QueryIndustryTagListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryIndustryTagListResponse
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
            action='QueryIndustryTagList',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/industries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryIndustryTagListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_industry_tag_list_with_options_async(
        self,
        headers: dingtalkapaas__1__0_models.QueryIndustryTagListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryIndustryTagListResponse:
        """
        @summary 查询行业标签
        
        @param headers: QueryIndustryTagListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryIndustryTagListResponse
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
            action='QueryIndustryTagList',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/industries',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryIndustryTagListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_industry_tag_list(self) -> dingtalkapaas__1__0_models.QueryIndustryTagListResponse:
        """
        @summary 查询行业标签
        
        @return: QueryIndustryTagListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryIndustryTagListHeaders()
        return self.query_industry_tag_list_with_options(headers, runtime)

    async def query_industry_tag_list_async(self) -> dingtalkapaas__1__0_models.QueryIndustryTagListResponse:
        """
        @summary 查询行业标签
        
        @return: QueryIndustryTagListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryIndustryTagListHeaders()
        return await self.query_industry_tag_list_with_options_async(headers, runtime)

    def query_role_tag_list_with_options(
        self,
        headers: dingtalkapaas__1__0_models.QueryRoleTagListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryRoleTagListResponse:
        """
        @summary 查询角色
        
        @param headers: QueryRoleTagListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRoleTagListResponse
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
            action='QueryRoleTagList',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryRoleTagListResponse(),
            self.execute(params, req, runtime)
        )

    async def query_role_tag_list_with_options_async(
        self,
        headers: dingtalkapaas__1__0_models.QueryRoleTagListHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryRoleTagListResponse:
        """
        @summary 查询角色
        
        @param headers: QueryRoleTagListHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryRoleTagListResponse
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
            action='QueryRoleTagList',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/roles',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryRoleTagListResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_role_tag_list(self) -> dingtalkapaas__1__0_models.QueryRoleTagListResponse:
        """
        @summary 查询角色
        
        @return: QueryRoleTagListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryRoleTagListHeaders()
        return self.query_role_tag_list_with_options(headers, runtime)

    async def query_role_tag_list_async(self) -> dingtalkapaas__1__0_models.QueryRoleTagListResponse:
        """
        @summary 查询角色
        
        @return: QueryRoleTagListResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryRoleTagListHeaders()
        return await self.query_role_tag_list_with_options_async(headers, runtime)

    def query_template_categorys_with_options(
        self,
        headers: dingtalkapaas__1__0_models.QueryTemplateCategorysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryTemplateCategorysResponse:
        """
        @summary 查询模板分类
        
        @param headers: QueryTemplateCategorysHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTemplateCategorysResponse
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
            action='QueryTemplateCategorys',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/categories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryTemplateCategorysResponse(),
            self.execute(params, req, runtime)
        )

    async def query_template_categorys_with_options_async(
        self,
        headers: dingtalkapaas__1__0_models.QueryTemplateCategorysHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.QueryTemplateCategorysResponse:
        """
        @summary 查询模板分类
        
        @param headers: QueryTemplateCategorysHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryTemplateCategorysResponse
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
            action='QueryTemplateCategorys',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/categories',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.QueryTemplateCategorysResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_template_categorys(self) -> dingtalkapaas__1__0_models.QueryTemplateCategorysResponse:
        """
        @summary 查询模板分类
        
        @return: QueryTemplateCategorysResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryTemplateCategorysHeaders()
        return self.query_template_categorys_with_options(headers, runtime)

    async def query_template_categorys_async(self) -> dingtalkapaas__1__0_models.QueryTemplateCategorysResponse:
        """
        @summary 查询模板分类
        
        @return: QueryTemplateCategorysResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.QueryTemplateCategorysHeaders()
        return await self.query_template_categorys_with_options_async(headers, runtime)

    def recall_audit_template_with_options(
        self,
        request: dingtalkapaas__1__0_models.RecallAuditTemplateRequest,
        headers: dingtalkapaas__1__0_models.RecallAuditTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.RecallAuditTemplateResponse:
        """
        @summary 撤回模板审核
        
        @param request: RecallAuditTemplateRequest
        @param headers: RecallAuditTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RecallAuditTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_keys):
            body['templateKeys'] = request.template_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RecallAuditTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/audits/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.RecallAuditTemplateResponse(),
            self.execute(params, req, runtime)
        )

    async def recall_audit_template_with_options_async(
        self,
        request: dingtalkapaas__1__0_models.RecallAuditTemplateRequest,
        headers: dingtalkapaas__1__0_models.RecallAuditTemplateHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkapaas__1__0_models.RecallAuditTemplateResponse:
        """
        @summary 撤回模板审核
        
        @param request: RecallAuditTemplateRequest
        @param headers: RecallAuditTemplateHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RecallAuditTemplateResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.template_keys):
            body['templateKeys'] = request.template_keys
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='RecallAuditTemplate',
            version='apaas_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/apaas/templates/audits/recall',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkapaas__1__0_models.RecallAuditTemplateResponse(),
            await self.execute_async(params, req, runtime)
        )

    def recall_audit_template(
        self,
        request: dingtalkapaas__1__0_models.RecallAuditTemplateRequest,
    ) -> dingtalkapaas__1__0_models.RecallAuditTemplateResponse:
        """
        @summary 撤回模板审核
        
        @param request: RecallAuditTemplateRequest
        @return: RecallAuditTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.RecallAuditTemplateHeaders()
        return self.recall_audit_template_with_options(request, headers, runtime)

    async def recall_audit_template_async(
        self,
        request: dingtalkapaas__1__0_models.RecallAuditTemplateRequest,
    ) -> dingtalkapaas__1__0_models.RecallAuditTemplateResponse:
        """
        @summary 撤回模板审核
        
        @param request: RecallAuditTemplateRequest
        @return: RecallAuditTemplateResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkapaas__1__0_models.RecallAuditTemplateHeaders()
        return await self.recall_audit_template_with_options_async(request, headers, runtime)
