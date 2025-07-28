# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.meter_1_0 import models as dingtalkmeter__1__0_models
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

    def get_resource_use_info_with_options(
        self,
        request: dingtalkmeter__1__0_models.GetResourceUseInfoRequest,
        headers: dingtalkmeter__1__0_models.GetResourceUseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmeter__1__0_models.GetResourceUseInfoResponse:
        """
        @summary 获取开放平台当月资源用量
        
        @param request: GetResourceUseInfoRequest
        @param headers: GetResourceUseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResourceUseInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code_list):
            body['benefitCodeList'] = request.benefit_code_list
        if not UtilClient.is_unset(request.period):
            body['period'] = request.period
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
            action='GetResourceUseInfo',
            version='meter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/meter/resources/useInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmeter__1__0_models.GetResourceUseInfoResponse(),
            self.execute(params, req, runtime)
        )

    async def get_resource_use_info_with_options_async(
        self,
        request: dingtalkmeter__1__0_models.GetResourceUseInfoRequest,
        headers: dingtalkmeter__1__0_models.GetResourceUseInfoHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkmeter__1__0_models.GetResourceUseInfoResponse:
        """
        @summary 获取开放平台当月资源用量
        
        @param request: GetResourceUseInfoRequest
        @param headers: GetResourceUseInfoHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: GetResourceUseInfoResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.benefit_code_list):
            body['benefitCodeList'] = request.benefit_code_list
        if not UtilClient.is_unset(request.period):
            body['period'] = request.period
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
            action='GetResourceUseInfo',
            version='meter_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/meter/resources/useInfos/query',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkmeter__1__0_models.GetResourceUseInfoResponse(),
            await self.execute_async(params, req, runtime)
        )

    def get_resource_use_info(
        self,
        request: dingtalkmeter__1__0_models.GetResourceUseInfoRequest,
    ) -> dingtalkmeter__1__0_models.GetResourceUseInfoResponse:
        """
        @summary 获取开放平台当月资源用量
        
        @param request: GetResourceUseInfoRequest
        @return: GetResourceUseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmeter__1__0_models.GetResourceUseInfoHeaders()
        return self.get_resource_use_info_with_options(request, headers, runtime)

    async def get_resource_use_info_async(
        self,
        request: dingtalkmeter__1__0_models.GetResourceUseInfoRequest,
    ) -> dingtalkmeter__1__0_models.GetResourceUseInfoResponse:
        """
        @summary 获取开放平台当月资源用量
        
        @param request: GetResourceUseInfoRequest
        @return: GetResourceUseInfoResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkmeter__1__0_models.GetResourceUseInfoHeaders()
        return await self.get_resource_use_info_with_options_async(request, headers, runtime)
