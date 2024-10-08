# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from typing import Dict
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.gateway_1_0 import models as dingtalkgateway__1__0_models
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

    def open_connection_with_options(
        self,
        request: dingtalkgateway__1__0_models.OpenConnectionRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgateway__1__0_models.OpenConnectionResponse:
        """
        @summary 云上网关注册长连接
        
        @param request: OpenConnectionRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenConnectionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.local_ip):
            body['localIp'] = request.local_ip
        if not UtilClient.is_unset(request.subscriptions):
            body['subscriptions'] = request.subscriptions
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OpenConnection',
            version='gateway_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/gateway/connections/open',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgateway__1__0_models.OpenConnectionResponse(),
            self.do_roarequest_with_form(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    async def open_connection_with_options_async(
        self,
        request: dingtalkgateway__1__0_models.OpenConnectionRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkgateway__1__0_models.OpenConnectionResponse:
        """
        @summary 云上网关注册长连接
        
        @param request: OpenConnectionRequest
        @param headers: map
        @param runtime: runtime options for this request RuntimeOptions
        @return: OpenConnectionResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.client_id):
            body['clientId'] = request.client_id
        if not UtilClient.is_unset(request.client_secret):
            body['clientSecret'] = request.client_secret
        if not UtilClient.is_unset(request.extras):
            body['extras'] = request.extras
        if not UtilClient.is_unset(request.local_ip):
            body['localIp'] = request.local_ip
        if not UtilClient.is_unset(request.subscriptions):
            body['subscriptions'] = request.subscriptions
        req = open_api_models.OpenApiRequest(
            headers=headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='OpenConnection',
            version='gateway_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/gateway/connections/open',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkgateway__1__0_models.OpenConnectionResponse(),
            await self.do_roarequest_with_form_async(params.action, params.version, params.protocol, params.method, params.auth_type, params.pathname, params.body_type, req, runtime)
        )

    def open_connection(
        self,
        request: dingtalkgateway__1__0_models.OpenConnectionRequest,
    ) -> dingtalkgateway__1__0_models.OpenConnectionResponse:
        """
        @summary 云上网关注册长连接
        
        @param request: OpenConnectionRequest
        @return: OpenConnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.open_connection_with_options(request, headers, runtime)

    async def open_connection_async(
        self,
        request: dingtalkgateway__1__0_models.OpenConnectionRequest,
    ) -> dingtalkgateway__1__0_models.OpenConnectionResponse:
        """
        @summary 云上网关注册长连接
        
        @param request: OpenConnectionRequest
        @return: OpenConnectionResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.open_connection_with_options_async(request, headers, runtime)
