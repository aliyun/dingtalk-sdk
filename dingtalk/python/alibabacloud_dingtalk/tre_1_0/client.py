# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.tre_1_0 import models as dingtalktre__1__0_models
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

    def create_ticket_with_options(
        self,
        tmp_req: dingtalktre__1__0_models.CreateTicketRequest,
        headers: dingtalktre__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktre__1__0_models.CreateTicketResponse:
        """
        @summary TRE拉铃服务
        
        @param tmp_req: CreateTicketRequest
        @param headers: CreateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTicketResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalktre__1__0_models.CreateTicketShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.reporters):
            request.reporters_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.reporters, 'reporters', 'json')
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.reporters_shrink):
            body['reporters'] = request.reporters_shrink
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
            action='CreateTicket',
            version='tre_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/tre/ticket',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktre__1__0_models.CreateTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def create_ticket_with_options_async(
        self,
        tmp_req: dingtalktre__1__0_models.CreateTicketRequest,
        headers: dingtalktre__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalktre__1__0_models.CreateTicketResponse:
        """
        @summary TRE拉铃服务
        
        @param tmp_req: CreateTicketRequest
        @param headers: CreateTicketHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: CreateTicketResponse
        """
        UtilClient.validate_model(tmp_req)
        request = dingtalktre__1__0_models.CreateTicketShrinkRequest()
        OpenApiUtilClient.convert(tmp_req, request)
        if not UtilClient.is_unset(tmp_req.reporters):
            request.reporters_shrink = OpenApiUtilClient.array_to_string_with_specified_style(tmp_req.reporters, 'reporters', 'json')
        body = {}
        if not UtilClient.is_unset(request.description):
            body['description'] = request.description
        if not UtilClient.is_unset(request.priority):
            body['priority'] = request.priority
        if not UtilClient.is_unset(request.reporters_shrink):
            body['reporters'] = request.reporters_shrink
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
            action='CreateTicket',
            version='tre_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/tre/ticket',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalktre__1__0_models.CreateTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def create_ticket(
        self,
        request: dingtalktre__1__0_models.CreateTicketRequest,
    ) -> dingtalktre__1__0_models.CreateTicketResponse:
        """
        @summary TRE拉铃服务
        
        @param request: CreateTicketRequest
        @return: CreateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktre__1__0_models.CreateTicketHeaders()
        return self.create_ticket_with_options(request, headers, runtime)

    async def create_ticket_async(
        self,
        request: dingtalktre__1__0_models.CreateTicketRequest,
    ) -> dingtalktre__1__0_models.CreateTicketResponse:
        """
        @summary TRE拉铃服务
        
        @param request: CreateTicketRequest
        @return: CreateTicketResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalktre__1__0_models.CreateTicketHeaders()
        return await self.create_ticket_with_options_async(request, headers, runtime)
