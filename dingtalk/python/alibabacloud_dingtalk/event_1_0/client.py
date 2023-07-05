# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore
from typing import Dict

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.event_1_0 import models as dingtalkevent__1__0_models
from alibabacloud_tea_util import models as util_models
from alibabacloud_openapi_util.client import Client as OpenApiUtilClient


class Client(OpenApiClient):
    """
    *\
    """
    _client: SPIClient = None

    def __init__(
        self, 
        config: open_api_models.Config,
    ):
        super().__init__(config)
        self._client = GatewayClientClient()
        self._spi = self._client
        self._signature_algorithm = 'v2'
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def get_call_back_faile_result_with_options(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetCallBackFaileResult',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/callbacks/failedResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            self.execute(params, req, runtime)
        )

    async def get_call_back_faile_result_with_options_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
        headers: dingtalkevent__1__0_models.GetCallBackFaileResultHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.begin_time):
            query['beginTime'] = request.begin_time
        if not UtilClient.is_unset(request.end_time):
            query['endTime'] = request.end_time
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
            action='GetCallBackFaileResult',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/callbacks/failedResults',
            method='GET',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.GetCallBackFaileResultResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_call_back_faile_result(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return self.get_call_back_faile_result_with_options(request, headers, runtime)

    async def get_call_back_faile_result_async(
        self,
        request: dingtalkevent__1__0_models.GetCallBackFaileResultRequest,
    ) -> dingtalkevent__1__0_models.GetCallBackFaileResultResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkevent__1__0_models.GetCallBackFaileResultHeaders()
        return await self.get_call_back_faile_result_with_options_async(request, headers, runtime)

    def re_push_suite_ticket_with_options(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
        if not UtilClient.is_unset(request.suite_secret):
            query['suiteSecret'] = request.suite_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='RePushSuiteTicket',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/suiteTicket/rePush',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.RePushSuiteTicketResponse(),
            self.execute(params, req, runtime)
        )

    async def re_push_suite_ticket_with_options_async(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
        headers: Dict[str, str],
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        UtilClient.validate_model(request)
        query = {}
        if not UtilClient.is_unset(request.suite_id):
            query['suiteId'] = request.suite_id
        if not UtilClient.is_unset(request.suite_secret):
            query['suiteSecret'] = request.suite_secret
        req = open_api_models.OpenApiRequest(
            headers=headers,
            query=OpenApiUtilClient.query(query)
        )
        params = open_api_models.Params(
            action='RePushSuiteTicket',
            version='event_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/event/suiteTicket/rePush',
            method='POST',
            auth_type='Anonymous',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkevent__1__0_models.RePushSuiteTicketResponse(),
            await self.execute_async(params, req, runtime)
        )

    def re_push_suite_ticket(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return self.re_push_suite_ticket_with_options(request, headers, runtime)

    async def re_push_suite_ticket_async(
        self,
        request: dingtalkevent__1__0_models.RePushSuiteTicketRequest,
    ) -> dingtalkevent__1__0_models.RePushSuiteTicketResponse:
        runtime = util_models.RuntimeOptions()
        headers = {}
        return await self.re_push_suite_ticket_with_options_async(request, headers, runtime)
