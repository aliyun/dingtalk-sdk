# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_gateway_spi.client import Client as SPIClient
from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.cool_ops_1_0 import models as dingtalkcool_ops__1__0_models
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
        self._endpoint_rule = ''
        if UtilClient.empty(self._endpoint):
            self._endpoint = 'api.dingtalk.com'

    def update_isv_opp_status_with_options(
        self,
        request: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusRequest,
        headers: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_opportunity_status_list):
            body['isvOpportunityStatusList'] = request.isv_opportunity_status_list
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
            action='UpdateIsvOppStatus',
            version='coolOps_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/coolOps/isvOpportunities/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse(),
            self.execute(params, req, runtime)
        )

    async def update_isv_opp_status_with_options_async(
        self,
        request: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusRequest,
        headers: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse:
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.isv_opportunity_status_list):
            body['isvOpportunityStatusList'] = request.isv_opportunity_status_list
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
            action='UpdateIsvOppStatus',
            version='coolOps_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/coolOps/isvOpportunities/statuses',
            method='PUT',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse(),
            await self.execute_async(params, req, runtime)
        )

    def update_isv_opp_status(
        self,
        request: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusRequest,
    ) -> dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcool_ops__1__0_models.UpdateIsvOppStatusHeaders()
        return self.update_isv_opp_status_with_options(request, headers, runtime)

    async def update_isv_opp_status_async(
        self,
        request: dingtalkcool_ops__1__0_models.UpdateIsvOppStatusRequest,
    ) -> dingtalkcool_ops__1__0_models.UpdateIsvOppStatusResponse:
        runtime = util_models.RuntimeOptions()
        headers = dingtalkcool_ops__1__0_models.UpdateIsvOppStatusHeaders()
        return await self.update_isv_opp_status_with_options_async(request, headers, runtime)
