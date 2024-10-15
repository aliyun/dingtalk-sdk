# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.ding_phone_1_0 import models as dingtalkding_phone__1__0_models
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

    def add_call_config_with_options(
        self,
        request: dingtalkding_phone__1__0_models.AddCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.AddCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.AddCallConfigResponse:
        """
        @summary 添加外呼码号配置
        
        @param request: AddCallConfigRequest
        @param headers: AddCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
        if not UtilClient.is_unset(request.scope_type):
            query['scopeType'] = request.scope_type
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
            action='AddCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.AddCallConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def add_call_config_with_options_async(
        self,
        request: dingtalkding_phone__1__0_models.AddCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.AddCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.AddCallConfigResponse:
        """
        @summary 添加外呼码号配置
        
        @param request: AddCallConfigRequest
        @param headers: AddCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: AddCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
        if not UtilClient.is_unset(request.scope_type):
            query['scopeType'] = request.scope_type
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
            action='AddCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.AddCallConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def add_call_config(
        self,
        request: dingtalkding_phone__1__0_models.AddCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.AddCallConfigResponse:
        """
        @summary 添加外呼码号配置
        
        @param request: AddCallConfigRequest
        @return: AddCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.AddCallConfigHeaders()
        return self.add_call_config_with_options(request, headers, runtime)

    async def add_call_config_async(
        self,
        request: dingtalkding_phone__1__0_models.AddCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.AddCallConfigResponse:
        """
        @summary 添加外呼码号配置
        
        @param request: AddCallConfigRequest
        @return: AddCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.AddCallConfigHeaders()
        return await self.add_call_config_with_options_async(request, headers, runtime)

    def del_call_config_with_options(
        self,
        request: dingtalkding_phone__1__0_models.DelCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.DelCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.DelCallConfigResponse:
        """
        @summary 删除码号配置
        
        @param request: DelCallConfigRequest
        @param headers: DelCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
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
            action='DelCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.DelCallConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def del_call_config_with_options_async(
        self,
        request: dingtalkding_phone__1__0_models.DelCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.DelCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.DelCallConfigResponse:
        """
        @summary 删除码号配置
        
        @param request: DelCallConfigRequest
        @param headers: DelCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DelCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
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
            action='DelCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='DELETE',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.DelCallConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def del_call_config(
        self,
        request: dingtalkding_phone__1__0_models.DelCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.DelCallConfigResponse:
        """
        @summary 删除码号配置
        
        @param request: DelCallConfigRequest
        @return: DelCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.DelCallConfigHeaders()
        return self.del_call_config_with_options(request, headers, runtime)

    async def del_call_config_async(
        self,
        request: dingtalkding_phone__1__0_models.DelCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.DelCallConfigResponse:
        """
        @summary 删除码号配置
        
        @param request: DelCallConfigRequest
        @return: DelCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.DelCallConfigHeaders()
        return await self.del_call_config_with_options_async(request, headers, runtime)

    def query_call_config_with_options(
        self,
        request: dingtalkding_phone__1__0_models.QueryCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.QueryCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.QueryCallConfigResponse:
        """
        @summary 查询外呼码号配置
        
        @param request: QueryCallConfigRequest
        @param headers: QueryCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
        if not UtilClient.is_unset(request.scope_type):
            query['scopeType'] = request.scope_type
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
            action='QueryCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.QueryCallConfigResponse(),
            self.execute(params, req, runtime)
        )

    async def query_call_config_with_options_async(
        self,
        request: dingtalkding_phone__1__0_models.QueryCallConfigRequest,
        headers: dingtalkding_phone__1__0_models.QueryCallConfigHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkding_phone__1__0_models.QueryCallConfigResponse:
        """
        @summary 查询外呼码号配置
        
        @param request: QueryCallConfigRequest
        @param headers: QueryCallConfigHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: QueryCallConfigResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.corp_id):
            query['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.isv_token):
            query['isvToken'] = request.isv_token
        if not UtilClient.is_unset(request.phone_number):
            query['phoneNumber'] = request.phone_number
        if not UtilClient.is_unset(request.scope_type):
            query['scopeType'] = request.scope_type
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
            action='QueryCallConfig',
            version='dingPhone_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/dingPhone/callConfigs',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkding_phone__1__0_models.QueryCallConfigResponse(),
            await self.execute_async(params, req, runtime)
        )

    def query_call_config(
        self,
        request: dingtalkding_phone__1__0_models.QueryCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.QueryCallConfigResponse:
        """
        @summary 查询外呼码号配置
        
        @param request: QueryCallConfigRequest
        @return: QueryCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.QueryCallConfigHeaders()
        return self.query_call_config_with_options(request, headers, runtime)

    async def query_call_config_async(
        self,
        request: dingtalkding_phone__1__0_models.QueryCallConfigRequest,
    ) -> dingtalkding_phone__1__0_models.QueryCallConfigResponse:
        """
        @summary 查询外呼码号配置
        
        @param request: QueryCallConfigRequest
        @return: QueryCallConfigResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkding_phone__1__0_models.QueryCallConfigHeaders()
        return await self.query_call_config_with_options_async(request, headers, runtime)
