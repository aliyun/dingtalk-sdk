# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from typing import Dict
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.customer_1_0 import models as dingtalkcustomer__1__0_models
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
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def custome_rpc_call_with_options(
        self,
        tmp_req: dingtalkcustomer__1__0_models.CustomeRpcCallRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer__1__0_models.CustomeRpcCallResponse:
        """
        @summary 大客户ltcPRC接口调用
        
        @param tmp_req: CustomeRpcCallRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomeRpcCallResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkcustomer__1__0_models.CustomeRpcCallShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.params):
            request.params_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.params, 'params', 'json')
        query = {}
        if not UtilClient.is_unset(request.method_name):
            query['methodName'] = request.method_name
        if not UtilClient.is_unset(request.params_shrink):
            query['params'] = request.params_shrink
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomeRpcCall',
            version='customer_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/customer/rpcCall',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcustomer__1__0_models.CustomeRpcCallResponse(),
            self.execute(params, req, runtime)
        )

    async def custome_rpc_call_with_options_async(
        self,
        tmp_req: dingtalkcustomer__1__0_models.CustomeRpcCallRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer__1__0_models.CustomeRpcCallResponse:
        """
        @summary 大客户ltcPRC接口调用
        
        @param tmp_req: CustomeRpcCallRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: CustomeRpcCallResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalkcustomer__1__0_models.CustomeRpcCallShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.params):
            request.params_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.params, 'params', 'json')
        query = {}
        if not UtilClient.is_unset(request.method_name):
            query['methodName'] = request.method_name
        if not UtilClient.is_unset(request.params_shrink):
            query['params'] = request.params_shrink
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='CustomeRpcCall',
            version='customer_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/customer/rpcCall',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcustomer__1__0_models.CustomeRpcCallResponse(),
            await self.execute_async(params, req, runtime)
        )

    def custome_rpc_call(
        self,
        request: dingtalkcustomer__1__0_models.CustomeRpcCallRequest,
    ) -> dingtalkcustomer__1__0_models.CustomeRpcCallResponse:
        """
        @summary 大客户ltcPRC接口调用
        
        @param request: CustomeRpcCallRequest
        @return: CustomeRpcCallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.custome_rpc_call_with_options(request, headers, runtime)

    async def custome_rpc_call_async(
        self,
        request: dingtalkcustomer__1__0_models.CustomeRpcCallRequest,
    ) -> dingtalkcustomer__1__0_models.CustomeRpcCallResponse:
        """
        @summary 大客户ltcPRC接口调用
        
        @param request: CustomeRpcCallRequest
        @return: CustomeRpcCallResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.custome_rpc_call_with_options_async(request, headers, runtime)

    def project_setup_with_options(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer__1__0_models.ProjectSetupResponse:
        """
        @summary 直签立项审批
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: ProjectSetupResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='ProjectSetup',
            version='customer_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/customer/project/setup',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcustomer__1__0_models.ProjectSetupResponse(),
            self.execute(params, req, runtime)
        )

    async def project_setup_with_options_async(
        self,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer__1__0_models.ProjectSetupResponse:
        """
        @summary 直签立项审批
        
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: ProjectSetupResponse
        """
        req = open_api_models.OpenApiRequest(
            headers=headers
        )
        params = open_api_models.Params(
            action='ProjectSetup',
            version='customer_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/customer/project/setup',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcustomer__1__0_models.ProjectSetupResponse(),
            await self.execute_async(params, req, runtime)
        )

    def project_setup(self) -> dingtalkcustomer__1__0_models.ProjectSetupResponse:
        """
        @summary 直签立项审批
        
        @return: ProjectSetupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.project_setup_with_options(headers, runtime)

    async def project_setup_async(self) -> dingtalkcustomer__1__0_models.ProjectSetupResponse:
        """
        @summary 直签立项审批
        
        @return: ProjectSetupResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.project_setup_with_options_async(headers, runtime)
