# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.connector_1_0 import models as dingtalkconnector__1__0_models
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

    def create_action_with_options(
        self,
        request: dingtalkconnector__1__0_models.CreateActionRequest,
        headers: dingtalkconnector__1__0_models.CreateActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateActionResponse:
        """
        @summary 创建执行动作
        
        @param request: CreateActionRequest
        @param headers: CreateActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateActionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_info):
            body['actionInfo'] = request.action_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateAction',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/actions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateActionResponse(),
            self.execute(params, req, runtime)
        )

    async def create_action_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.CreateActionRequest,
        headers: dingtalkconnector__1__0_models.CreateActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateActionResponse:
        """
        @summary 创建执行动作
        
        @param request: CreateActionRequest
        @param headers: CreateActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateActionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_info):
            body['actionInfo'] = request.action_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateAction',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/actions',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateActionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_action(
        self,
        request: dingtalkconnector__1__0_models.CreateActionRequest,
    ) -> dingtalkconnector__1__0_models.CreateActionResponse:
        """
        @summary 创建执行动作
        
        @param request: CreateActionRequest
        @return: CreateActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateActionHeaders()
        return self.create_action_with_options(request, headers, runtime)

    async def create_action_async(
        self,
        request: dingtalkconnector__1__0_models.CreateActionRequest,
    ) -> dingtalkconnector__1__0_models.CreateActionResponse:
        """
        @summary 创建执行动作
        
        @param request: CreateActionRequest
        @return: CreateActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateActionHeaders()
        return await self.create_action_with_options_async(request, headers, runtime)

    def create_connector_with_options(
        self,
        request: dingtalkconnector__1__0_models.CreateConnectorRequest,
        headers: dingtalkconnector__1__0_models.CreateConnectorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateConnectorResponse:
        """
        @summary 创建连接器
        
        @param request: CreateConnectorRequest
        @param headers: CreateConnectorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateConnectorResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_info):
            body['connectorInfo'] = request.connector_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateConnector',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/connectors',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateConnectorResponse(),
            self.execute(params, req, runtime)
        )

    async def create_connector_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.CreateConnectorRequest,
        headers: dingtalkconnector__1__0_models.CreateConnectorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateConnectorResponse:
        """
        @summary 创建连接器
        
        @param request: CreateConnectorRequest
        @param headers: CreateConnectorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateConnectorResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_info):
            body['connectorInfo'] = request.connector_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateConnector',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/connectors',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateConnectorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_connector(
        self,
        request: dingtalkconnector__1__0_models.CreateConnectorRequest,
    ) -> dingtalkconnector__1__0_models.CreateConnectorResponse:
        """
        @summary 创建连接器
        
        @param request: CreateConnectorRequest
        @return: CreateConnectorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateConnectorHeaders()
        return self.create_connector_with_options(request, headers, runtime)

    async def create_connector_async(
        self,
        request: dingtalkconnector__1__0_models.CreateConnectorRequest,
    ) -> dingtalkconnector__1__0_models.CreateConnectorResponse:
        """
        @summary 创建连接器
        
        @param request: CreateConnectorRequest
        @return: CreateConnectorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateConnectorHeaders()
        return await self.create_connector_with_options_async(request, headers, runtime)

    def create_invocable_instance_with_options(
        self,
        request: dingtalkconnector__1__0_models.CreateInvocableInstanceRequest,
        headers: dingtalkconnector__1__0_models.CreateInvocableInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateInvocableInstanceResponse:
        """
        @summary 创建一个用于运行执行动作/集成流的可调用实例
        
        @param request: CreateInvocableInstanceRequest
        @param headers: CreateInvocableInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInvocableInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        if not UtilClient.is_unset(request.instance_key):
            body['instanceKey'] = request.instance_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInvocableInstance',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateInvocableInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def create_invocable_instance_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.CreateInvocableInstanceRequest,
        headers: dingtalkconnector__1__0_models.CreateInvocableInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateInvocableInstanceResponse:
        """
        @summary 创建一个用于运行执行动作/集成流的可调用实例
        
        @param request: CreateInvocableInstanceRequest
        @param headers: CreateInvocableInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateInvocableInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        if not UtilClient.is_unset(request.instance_key):
            body['instanceKey'] = request.instance_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateInvocableInstance',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/instances',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateInvocableInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_invocable_instance(
        self,
        request: dingtalkconnector__1__0_models.CreateInvocableInstanceRequest,
    ) -> dingtalkconnector__1__0_models.CreateInvocableInstanceResponse:
        """
        @summary 创建一个用于运行执行动作/集成流的可调用实例
        
        @param request: CreateInvocableInstanceRequest
        @return: CreateInvocableInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateInvocableInstanceHeaders()
        return self.create_invocable_instance_with_options(request, headers, runtime)

    async def create_invocable_instance_async(
        self,
        request: dingtalkconnector__1__0_models.CreateInvocableInstanceRequest,
    ) -> dingtalkconnector__1__0_models.CreateInvocableInstanceResponse:
        """
        @summary 创建一个用于运行执行动作/集成流的可调用实例
        
        @param request: CreateInvocableInstanceRequest
        @return: CreateInvocableInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateInvocableInstanceHeaders()
        return await self.create_invocable_instance_with_options_async(request, headers, runtime)

    def create_trigger_with_options(
        self,
        request: dingtalkconnector__1__0_models.CreateTriggerRequest,
        headers: dingtalkconnector__1__0_models.CreateTriggerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateTriggerResponse:
        """
        @summary 创建触发器
        
        @param request: CreateTriggerRequest
        @param headers: CreateTriggerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTriggerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        if not UtilClient.is_unset(request.trigger_info):
            body['triggerInfo'] = request.trigger_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTrigger',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateTriggerResponse(),
            self.execute(params, req, runtime)
        )

    async def create_trigger_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.CreateTriggerRequest,
        headers: dingtalkconnector__1__0_models.CreateTriggerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.CreateTriggerResponse:
        """
        @summary 创建触发器
        
        @param request: CreateTriggerRequest
        @param headers: CreateTriggerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTriggerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        if not UtilClient.is_unset(request.trigger_info):
            body['triggerInfo'] = request.trigger_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='CreateTrigger',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.CreateTriggerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_trigger(
        self,
        request: dingtalkconnector__1__0_models.CreateTriggerRequest,
    ) -> dingtalkconnector__1__0_models.CreateTriggerResponse:
        """
        @summary 创建触发器
        
        @param request: CreateTriggerRequest
        @return: CreateTriggerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateTriggerHeaders()
        return self.create_trigger_with_options(request, headers, runtime)

    async def create_trigger_async(
        self,
        request: dingtalkconnector__1__0_models.CreateTriggerRequest,
    ) -> dingtalkconnector__1__0_models.CreateTriggerResponse:
        """
        @summary 创建触发器
        
        @param request: CreateTriggerRequest
        @return: CreateTriggerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.CreateTriggerHeaders()
        return await self.create_trigger_with_options_async(request, headers, runtime)

    def get_action_detail_with_options(
        self,
        request: dingtalkconnector__1__0_models.GetActionDetailRequest,
        headers: dingtalkconnector__1__0_models.GetActionDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.GetActionDetailResponse:
        """
        @summary 获取执行动作详情
        
        @param request: GetActionDetailRequest
        @param headers: GetActionDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActionDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetActionDetail',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/actions/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.GetActionDetailResponse(),
            self.execute(params, req, runtime)
        )

    async def get_action_detail_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.GetActionDetailRequest,
        headers: dingtalkconnector__1__0_models.GetActionDetailHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.GetActionDetailResponse:
        """
        @summary 获取执行动作详情
        
        @param request: GetActionDetailRequest
        @param headers: GetActionDetailHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetActionDetailResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='GetActionDetail',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/actions/details/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.GetActionDetailResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_action_detail(
        self,
        request: dingtalkconnector__1__0_models.GetActionDetailRequest,
    ) -> dingtalkconnector__1__0_models.GetActionDetailResponse:
        """
        @summary 获取执行动作详情
        
        @param request: GetActionDetailRequest
        @return: GetActionDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.GetActionDetailHeaders()
        return self.get_action_detail_with_options(request, headers, runtime)

    async def get_action_detail_async(
        self,
        request: dingtalkconnector__1__0_models.GetActionDetailRequest,
    ) -> dingtalkconnector__1__0_models.GetActionDetailResponse:
        """
        @summary 获取执行动作详情
        
        @param request: GetActionDetailRequest
        @return: GetActionDetailResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.GetActionDetailHeaders()
        return await self.get_action_detail_with_options_async(request, headers, runtime)

    def invoke_instance_with_options(
        self,
        request: dingtalkconnector__1__0_models.InvokeInstanceRequest,
        headers: dingtalkconnector__1__0_models.InvokeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.InvokeInstanceResponse:
        """
        @summary 调用执行实例
        
        @param request: InvokeInstanceRequest
        @param headers: InvokeInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        if not UtilClient.is_unset(request.input_json_string):
            body['inputJsonString'] = request.input_json_string
        if not UtilClient.is_unset(request.instance_key):
            body['instanceKey'] = request.instance_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InvokeInstance',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/instances/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.InvokeInstanceResponse(),
            self.execute(params, req, runtime)
        )

    async def invoke_instance_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.InvokeInstanceRequest,
        headers: dingtalkconnector__1__0_models.InvokeInstanceHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.InvokeInstanceResponse:
        """
        @summary 调用执行实例
        
        @param request: InvokeInstanceRequest
        @param headers: InvokeInstanceHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: InvokeInstanceResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connect_asset_uri):
            body['connectAssetUri'] = request.connect_asset_uri
        if not UtilClient.is_unset(request.input_json_string):
            body['inputJsonString'] = request.input_json_string
        if not UtilClient.is_unset(request.instance_key):
            body['instanceKey'] = request.instance_key
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='InvokeInstance',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/instances/invoke',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.InvokeInstanceResponse(),
            await self.execute_async(params, req, runtime)
        )

    def invoke_instance(
        self,
        request: dingtalkconnector__1__0_models.InvokeInstanceRequest,
    ) -> dingtalkconnector__1__0_models.InvokeInstanceResponse:
        """
        @summary 调用执行实例
        
        @param request: InvokeInstanceRequest
        @return: InvokeInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.InvokeInstanceHeaders()
        return self.invoke_instance_with_options(request, headers, runtime)

    async def invoke_instance_async(
        self,
        request: dingtalkconnector__1__0_models.InvokeInstanceRequest,
    ) -> dingtalkconnector__1__0_models.InvokeInstanceResponse:
        """
        @summary 调用执行实例
        
        @param request: InvokeInstanceRequest
        @return: InvokeInstanceResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.InvokeInstanceHeaders()
        return await self.invoke_instance_with_options_async(request, headers, runtime)

    def pull_data_by_page_with_options(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        """
        @summary 分页拉取连接器主数据
        
        @param request: PullDataByPageRequest
        @param headers: PullDataByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDataByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.data_model_id):
            query['dataModelId'] = request.data_model_id
        if not UtilClient.is_unset(request.datetime_filter_field):
            query['datetimeFilterField'] = request.datetime_filter_field
        if not UtilClient.is_unset(request.max_datetime):
            query['maxDatetime'] = request.max_datetime
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.min_datetime):
            query['minDatetime'] = request.min_datetime
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
            action='PullDataByPage',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/data',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.PullDataByPageResponse(),
            self.execute(params, req, runtime)
        )

    async def pull_data_by_page_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPageHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        """
        @summary 分页拉取连接器主数据
        
        @param request: PullDataByPageRequest
        @param headers: PullDataByPageHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDataByPageResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.data_model_id):
            query['dataModelId'] = request.data_model_id
        if not UtilClient.is_unset(request.datetime_filter_field):
            query['datetimeFilterField'] = request.datetime_filter_field
        if not UtilClient.is_unset(request.max_datetime):
            query['maxDatetime'] = request.max_datetime
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.min_datetime):
            query['minDatetime'] = request.min_datetime
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
            action='PullDataByPage',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/data',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.PullDataByPageResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pull_data_by_page(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        """
        @summary 分页拉取连接器主数据
        
        @param request: PullDataByPageRequest
        @return: PullDataByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPageHeaders()
        return self.pull_data_by_page_with_options(request, headers, runtime)

    async def pull_data_by_page_async(
        self,
        request: dingtalkconnector__1__0_models.PullDataByPageRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPageResponse:
        """
        @summary 分页拉取连接器主数据
        
        @param request: PullDataByPageRequest
        @return: PullDataByPageResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPageHeaders()
        return await self.pull_data_by_page_with_options_async(request, headers, runtime)

    def pull_data_by_pk_with_options(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        """
        @summary 通过业务主键拉取单条连接器主数据
        
        @param request: PullDataByPkRequest
        @param headers: PullDataByPkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDataByPkResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.primary_key):
            query['primaryKey'] = request.primary_key
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
            action='PullDataByPk',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/data/{data_model_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.PullDataByPkResponse(),
            self.execute(params, req, runtime)
        )

    async def pull_data_by_pk_with_options_async(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
        headers: dingtalkconnector__1__0_models.PullDataByPkHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        """
        @summary 通过业务主键拉取单条连接器主数据
        
        @param request: PullDataByPkRequest
        @param headers: PullDataByPkHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: PullDataByPkResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.app_id):
            query['appId'] = request.app_id
        if not UtilClient.is_unset(request.primary_key):
            query['primaryKey'] = request.primary_key
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
            action='PullDataByPk',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/data/{data_model_id}',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.PullDataByPkResponse(),
            await self.execute_async(params, req, runtime)
        )

    def pull_data_by_pk(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        """
        @summary 通过业务主键拉取单条连接器主数据
        
        @param request: PullDataByPkRequest
        @return: PullDataByPkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPkHeaders()
        return self.pull_data_by_pk_with_options(data_model_id, request, headers, runtime)

    async def pull_data_by_pk_async(
        self,
        data_model_id: str,
        request: dingtalkconnector__1__0_models.PullDataByPkRequest,
    ) -> dingtalkconnector__1__0_models.PullDataByPkResponse:
        """
        @summary 通过业务主键拉取单条连接器主数据
        
        @param request: PullDataByPkRequest
        @return: PullDataByPkResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.PullDataByPkHeaders()
        return await self.pull_data_by_pk_with_options_async(data_model_id, request, headers, runtime)

    def search_actions_with_options(
        self,
        request: dingtalkconnector__1__0_models.SearchActionsRequest,
        headers: dingtalkconnector__1__0_models.SearchActionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SearchActionsResponse:
        """
        @summary 搜索执行动作
        
        @param request: SearchActionsRequest
        @param headers: SearchActionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchActionsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_id):
            body['connectorId'] = request.connector_id
        if not UtilClient.is_unset(request.connector_provider_corp_id):
            body['connectorProviderCorpId'] = request.connector_provider_corp_id
        if not UtilClient.is_unset(request.integration_types):
            body['integrationTypes'] = request.integration_types
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
            action='SearchActions',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/actions/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SearchActionsResponse(),
            self.execute(params, req, runtime)
        )

    async def search_actions_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.SearchActionsRequest,
        headers: dingtalkconnector__1__0_models.SearchActionsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SearchActionsResponse:
        """
        @summary 搜索执行动作
        
        @param request: SearchActionsRequest
        @param headers: SearchActionsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchActionsResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_id):
            body['connectorId'] = request.connector_id
        if not UtilClient.is_unset(request.connector_provider_corp_id):
            body['connectorProviderCorpId'] = request.connector_provider_corp_id
        if not UtilClient.is_unset(request.integration_types):
            body['integrationTypes'] = request.integration_types
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
            action='SearchActions',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/actions/search',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SearchActionsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_actions(
        self,
        request: dingtalkconnector__1__0_models.SearchActionsRequest,
    ) -> dingtalkconnector__1__0_models.SearchActionsResponse:
        """
        @summary 搜索执行动作
        
        @param request: SearchActionsRequest
        @return: SearchActionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SearchActionsHeaders()
        return self.search_actions_with_options(request, headers, runtime)

    async def search_actions_async(
        self,
        request: dingtalkconnector__1__0_models.SearchActionsRequest,
    ) -> dingtalkconnector__1__0_models.SearchActionsResponse:
        """
        @summary 搜索执行动作
        
        @param request: SearchActionsRequest
        @return: SearchActionsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SearchActionsHeaders()
        return await self.search_actions_with_options_async(request, headers, runtime)

    def search_connectors_with_options(
        self,
        request: dingtalkconnector__1__0_models.SearchConnectorsRequest,
        headers: dingtalkconnector__1__0_models.SearchConnectorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SearchConnectorsResponse:
        """
        @summary 搜索连接器
        
        @param request: SearchConnectorsRequest
        @param headers: SearchConnectorsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchConnectorsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='SearchConnectors',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/connectors',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SearchConnectorsResponse(),
            self.execute(params, req, runtime)
        )

    async def search_connectors_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.SearchConnectorsRequest,
        headers: dingtalkconnector__1__0_models.SearchConnectorsHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SearchConnectorsResponse:
        """
        @summary 搜索连接器
        
        @param request: SearchConnectorsRequest
        @param headers: SearchConnectorsHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SearchConnectorsResponse
        """
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.max_results):
            query['maxResults'] = request.max_results
        if not UtilClient.is_unset(request.next_token):
            query['nextToken'] = request.next_token
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
            action='SearchConnectors',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/assets/connectors',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SearchConnectorsResponse(),
            await self.execute_async(params, req, runtime)
        )

    def search_connectors(
        self,
        request: dingtalkconnector__1__0_models.SearchConnectorsRequest,
    ) -> dingtalkconnector__1__0_models.SearchConnectorsResponse:
        """
        @summary 搜索连接器
        
        @param request: SearchConnectorsRequest
        @return: SearchConnectorsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SearchConnectorsHeaders()
        return self.search_connectors_with_options(request, headers, runtime)

    async def search_connectors_async(
        self,
        request: dingtalkconnector__1__0_models.SearchConnectorsRequest,
    ) -> dingtalkconnector__1__0_models.SearchConnectorsResponse:
        """
        @summary 搜索连接器
        
        @param request: SearchConnectorsRequest
        @return: SearchConnectorsResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SearchConnectorsHeaders()
        return await self.search_connectors_with_options_async(request, headers, runtime)

    def sync_data_with_options(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
        headers: dingtalkconnector__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        """
        @summary 同步连接器数据
        
        @param request: SyncDataRequest
        @param headers: SyncDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.trigger_data_list):
            body['triggerDataList'] = request.trigger_data_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SyncData',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers/data/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SyncDataResponse(),
            self.execute(params, req, runtime)
        )

    async def sync_data_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
        headers: dingtalkconnector__1__0_models.SyncDataHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        """
        @summary 同步连接器数据
        
        @param request: SyncDataRequest
        @param headers: SyncDataHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SyncDataResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.app_id):
            body['appId'] = request.app_id
        if not UtilClient.is_unset(request.trigger_data_list):
            body['triggerDataList'] = request.trigger_data_list
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='SyncData',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers/data/sync',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.SyncDataResponse(),
            await self.execute_async(params, req, runtime)
        )

    def sync_data(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        """
        @summary 同步连接器数据
        
        @param request: SyncDataRequest
        @return: SyncDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SyncDataHeaders()
        return self.sync_data_with_options(request, headers, runtime)

    async def sync_data_async(
        self,
        request: dingtalkconnector__1__0_models.SyncDataRequest,
    ) -> dingtalkconnector__1__0_models.SyncDataResponse:
        """
        @summary 同步连接器数据
        
        @param request: SyncDataRequest
        @return: SyncDataResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.SyncDataHeaders()
        return await self.sync_data_with_options_async(request, headers, runtime)

    def update_action_with_options(
        self,
        request: dingtalkconnector__1__0_models.UpdateActionRequest,
        headers: dingtalkconnector__1__0_models.UpdateActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateActionResponse:
        """
        @summary 更新执行动作信息
        
        @param request: UpdateActionRequest
        @param headers: UpdateActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateActionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_info):
            body['actionInfo'] = request.action_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateAction',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/actions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateActionResponse(),
            self.execute(params, req, runtime)
        )

    async def update_action_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateActionRequest,
        headers: dingtalkconnector__1__0_models.UpdateActionHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateActionResponse:
        """
        @summary 更新执行动作信息
        
        @param request: UpdateActionRequest
        @param headers: UpdateActionHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateActionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.action_info):
            body['actionInfo'] = request.action_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateAction',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/actions',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateActionResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_action(
        self,
        request: dingtalkconnector__1__0_models.UpdateActionRequest,
    ) -> dingtalkconnector__1__0_models.UpdateActionResponse:
        """
        @summary 更新执行动作信息
        
        @param request: UpdateActionRequest
        @return: UpdateActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateActionHeaders()
        return self.update_action_with_options(request, headers, runtime)

    async def update_action_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateActionRequest,
    ) -> dingtalkconnector__1__0_models.UpdateActionResponse:
        """
        @summary 更新执行动作信息
        
        @param request: UpdateActionRequest
        @return: UpdateActionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateActionHeaders()
        return await self.update_action_with_options_async(request, headers, runtime)

    def update_connector_with_options(
        self,
        request: dingtalkconnector__1__0_models.UpdateConnectorRequest,
        headers: dingtalkconnector__1__0_models.UpdateConnectorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateConnectorResponse:
        """
        @summary 更新连接器信息
        
        @param request: UpdateConnectorRequest
        @param headers: UpdateConnectorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateConnectorResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_info):
            body['connectorInfo'] = request.connector_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateConnector',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/connectors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateConnectorResponse(),
            self.execute(params, req, runtime)
        )

    async def update_connector_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateConnectorRequest,
        headers: dingtalkconnector__1__0_models.UpdateConnectorHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateConnectorResponse:
        """
        @summary 更新连接器信息
        
        @param request: UpdateConnectorRequest
        @param headers: UpdateConnectorHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateConnectorResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.connector_info):
            body['connectorInfo'] = request.connector_info
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateConnector',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/connectors',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateConnectorResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_connector(
        self,
        request: dingtalkconnector__1__0_models.UpdateConnectorRequest,
    ) -> dingtalkconnector__1__0_models.UpdateConnectorResponse:
        """
        @summary 更新连接器信息
        
        @param request: UpdateConnectorRequest
        @return: UpdateConnectorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateConnectorHeaders()
        return self.update_connector_with_options(request, headers, runtime)

    async def update_connector_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateConnectorRequest,
    ) -> dingtalkconnector__1__0_models.UpdateConnectorResponse:
        """
        @summary 更新连接器信息
        
        @param request: UpdateConnectorRequest
        @return: UpdateConnectorResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateConnectorHeaders()
        return await self.update_connector_with_options_async(request, headers, runtime)

    def update_trigger_with_options(
        self,
        request: dingtalkconnector__1__0_models.UpdateTriggerRequest,
        headers: dingtalkconnector__1__0_models.UpdateTriggerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateTriggerResponse:
        """
        @summary 更新触发事件信息
        
        @param request: UpdateTriggerRequest
        @param headers: UpdateTriggerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTriggerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        if not UtilClient.is_unset(request.trigger_info):
            body['triggerInfo'] = request.trigger_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateTrigger',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateTriggerResponse(),
            self.execute(params, req, runtime)
        )

    async def update_trigger_with_options_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateTriggerRequest,
        headers: dingtalkconnector__1__0_models.UpdateTriggerHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkconnector__1__0_models.UpdateTriggerResponse:
        """
        @summary 更新触发事件信息
        
        @param request: UpdateTriggerRequest
        @param headers: UpdateTriggerHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: UpdateTriggerResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.integrator_flag):
            body['integratorFlag'] = request.integrator_flag
        if not UtilClient.is_unset(request.trigger_info):
            body['triggerInfo'] = request.trigger_info
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='UpdateTrigger',
            version='connector_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/connector/triggers',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkconnector__1__0_models.UpdateTriggerResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_trigger(
        self,
        request: dingtalkconnector__1__0_models.UpdateTriggerRequest,
    ) -> dingtalkconnector__1__0_models.UpdateTriggerResponse:
        """
        @summary 更新触发事件信息
        
        @param request: UpdateTriggerRequest
        @return: UpdateTriggerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateTriggerHeaders()
        return self.update_trigger_with_options(request, headers, runtime)

    async def update_trigger_async(
        self,
        request: dingtalkconnector__1__0_models.UpdateTriggerRequest,
    ) -> dingtalkconnector__1__0_models.UpdateTriggerResponse:
        """
        @summary 更新触发事件信息
        
        @param request: UpdateTriggerRequest
        @return: UpdateTriggerResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkconnector__1__0_models.UpdateTriggerHeaders()
        return await self.update_trigger_with_options_async(request, headers, runtime)
