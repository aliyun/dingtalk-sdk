# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalkcustomer_service_1_0 import models as dingtalkcustomer_service__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def create_ticket(
        self,
        request: dingtalkcustomer_service__1__0_models.CreateTicketRequest,
    ) -> dingtalkcustomer_service__1__0_models.CreateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcustomer_service__1__0_models.CreateTicketHeaders()
        return self.create_ticket_with_options(request, headers, runtime)

    async def create_ticket_async(
        self,
        request: dingtalkcustomer_service__1__0_models.CreateTicketRequest,
    ) -> dingtalkcustomer_service__1__0_models.CreateTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcustomer_service__1__0_models.CreateTicketHeaders()
        return await self.create_ticket_with_options_async(request, headers, runtime)

    def create_ticket_with_options(
        self,
        request: dingtalkcustomer_service__1__0_models.CreateTicketRequest,
        headers: dingtalkcustomer_service__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer_service__1__0_models.CreateTicketResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.foreign_id):
            body['foreignId'] = request.foreign_id
        if not UtilClient.is_unset(request.foreign_name):
            body['foreignName'] = request.foreign_name
        if not UtilClient.is_unset(request.open_instance_id):
            body['openInstanceId'] = request.open_instance_id
        if not UtilClient.is_unset(request.production_type):
            body['productionType'] = request.production_type
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcustomer_service__1__0_models.CreateTicketResponse(),
            self.do_roarequest('CreateTicket', 'customerService_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/customerService/tickets', 'json', req, runtime)
        )

    async def create_ticket_with_options_async(
        self,
        request: dingtalkcustomer_service__1__0_models.CreateTicketRequest,
        headers: dingtalkcustomer_service__1__0_models.CreateTicketHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcustomer_service__1__0_models.CreateTicketResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.source_id):
            body['sourceId'] = request.source_id
        if not UtilClient.is_unset(request.foreign_id):
            body['foreignId'] = request.foreign_id
        if not UtilClient.is_unset(request.foreign_name):
            body['foreignName'] = request.foreign_name
        if not UtilClient.is_unset(request.open_instance_id):
            body['openInstanceId'] = request.open_instance_id
        if not UtilClient.is_unset(request.production_type):
            body['productionType'] = request.production_type
        if not UtilClient.is_unset(request.template_id):
            body['templateId'] = request.template_id
        if not UtilClient.is_unset(request.title):
            body['title'] = request.title
        if not UtilClient.is_unset(request.properties):
            body['properties'] = request.properties
        real_headers = {}
        if not UtilClient.is_unset(headers.common_headers):
            real_headers = headers.common_headers
        if not UtilClient.is_unset(headers.x_acs_dingtalk_access_token):
            real_headers['x-acs-dingtalk-access-token'] = headers.x_acs_dingtalk_access_token
        req = open_api_models.OpenApiRequest(
            headers=real_headers,
            body=OpenApiUtilClient.parse_to_map(body)
        )
        return TeaCore.from_map(
            dingtalkcustomer_service__1__0_models.CreateTicketResponse(),
            await self.do_roarequest_async('CreateTicket', 'customerService_1.0', 'HTTP', 'POST', 'AK', f'/v1.0/customerService/tickets', 'json', req, runtime)
        )
