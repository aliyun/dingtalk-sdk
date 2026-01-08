# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.mcp_1_0 import models as dingtalkmcp__1__0_models
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

    def activate_mcp_with_options(
        self,
        request: dingtalkmcp__1__0_models.ActivateMcpRequest,
        headers: dingtalkmcp__1__0_models.ActivateMcpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmcp__1__0_models.ActivateMcpResponse:
        """
        @summary 激活MCP
        
        @param request: ActivateMcpRequest
        @param headers: ActivateMcpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ActivateMcpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mcp_id):
            body['mcpId'] = request.mcp_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ActivateMcp',
            version='mcp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mcp/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmcp__1__0_models.ActivateMcpResponse(),
            self.execute(params, req, runtime)
        )

    async def activate_mcp_with_options_async(
        self,
        request: dingtalkmcp__1__0_models.ActivateMcpRequest,
        headers: dingtalkmcp__1__0_models.ActivateMcpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmcp__1__0_models.ActivateMcpResponse:
        """
        @summary 激活MCP
        
        @param request: ActivateMcpRequest
        @param headers: ActivateMcpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: ActivateMcpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.mcp_id):
            body['mcpId'] = request.mcp_id
        if not UtilClient.is_unset(request.source):
            body['source'] = request.source
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='ActivateMcp',
            version='mcp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mcp/activate',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmcp__1__0_models.ActivateMcpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def activate_mcp(
        self,
        request: dingtalkmcp__1__0_models.ActivateMcpRequest,
    ) -> dingtalkmcp__1__0_models.ActivateMcpResponse:
        """
        @summary 激活MCP
        
        @param request: ActivateMcpRequest
        @return: ActivateMcpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmcp__1__0_models.ActivateMcpHeaders()
        return self.activate_mcp_with_options(request, headers, runtime)

    async def activate_mcp_async(
        self,
        request: dingtalkmcp__1__0_models.ActivateMcpRequest,
    ) -> dingtalkmcp__1__0_models.ActivateMcpResponse:
        """
        @summary 激活MCP
        
        @param request: ActivateMcpRequest
        @return: ActivateMcpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmcp__1__0_models.ActivateMcpHeaders()
        return await self.activate_mcp_with_options_async(request, headers, runtime)

    def delete_mcp_with_options(
        self,
        request: dingtalkmcp__1__0_models.DeleteMcpRequest,
        headers: dingtalkmcp__1__0_models.DeleteMcpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmcp__1__0_models.DeleteMcpResponse:
        """
        @summary 删除MCP实例
        
        @param request: DeleteMcpRequest
        @param headers: DeleteMcpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMcpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteMcp',
            version='mcp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mcp/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmcp__1__0_models.DeleteMcpResponse(),
            self.execute(params, req, runtime)
        )

    async def delete_mcp_with_options_async(
        self,
        request: dingtalkmcp__1__0_models.DeleteMcpRequest,
        headers: dingtalkmcp__1__0_models.DeleteMcpHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmcp__1__0_models.DeleteMcpResponse:
        """
        @summary 删除MCP实例
        
        @param request: DeleteMcpRequest
        @param headers: DeleteMcpHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: DeleteMcpResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.instance_id):
            body['instanceId'] = request.instance_id
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = UtilClient.to_jsonstring(headers.x_acs_dingtalk_access_token)
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        params = open_api_models.Params(
            action='DeleteMcp',
            version='mcp_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/mcp/delete',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmcp__1__0_models.DeleteMcpResponse(),
            await self.execute_async(params, req, runtime)
        )

    def delete_mcp(
        self,
        request: dingtalkmcp__1__0_models.DeleteMcpRequest,
    ) -> dingtalkmcp__1__0_models.DeleteMcpResponse:
        """
        @summary 删除MCP实例
        
        @param request: DeleteMcpRequest
        @return: DeleteMcpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmcp__1__0_models.DeleteMcpHeaders()
        return self.delete_mcp_with_options(request, headers, runtime)

    async def delete_mcp_async(
        self,
        request: dingtalkmcp__1__0_models.DeleteMcpRequest,
    ) -> dingtalkmcp__1__0_models.DeleteMcpResponse:
        """
        @summary 删除MCP实例
        
        @param request: DeleteMcpRequest
        @return: DeleteMcpResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmcp__1__0_models.DeleteMcpHeaders()
        return await self.delete_mcp_with_options_async(request, headers, runtime)
