# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.todo_e_e_1_0 import models as dingtalktodo_e_e__1__0_models
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
        self._product_id = 'dingtalk'
        gateway_client = GatewayClientClient()
        self._spi = gateway_client
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def register_category_source_config_with_options(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @param headers: RegisterCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
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
            action='RegisterCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def register_category_source_config_with_options_async(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
        headers: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @param headers: RegisterCategorySourceConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: RegisterCategorySourceConfigResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.biz_category_id):
            body['bizCategoryId'] = request.biz_category_id
        if not UtilClient.is_unset(request.biz_category_name):
            body['bizCategoryName'] = request.biz_category_name
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
            action='RegisterCategorySourceConfig',
            version='todoEE_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/todoEE/apps/categories/sourceConfigs/register',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def register_category_source_config(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @return: RegisterCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders()
        return self.register_category_source_config_with_options(request, headers, runtime)

    async def register_category_source_config_async(
        self,
        request: dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigRequest,
    ) -> dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigResponse:
        """
        @summary 注册应用类目信息
        
        @param request: RegisterCategorySourceConfigRequest
        @return: RegisterCategorySourceConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktodo_e_e__1__0_models.RegisterCategorySourceConfigHeaders()
        return await self.register_category_source_config_with_options_async(request, headers, runtime)
