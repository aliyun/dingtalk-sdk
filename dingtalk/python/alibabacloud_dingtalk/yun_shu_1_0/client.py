# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.core import TeaCore

from alibabacloud_tea_openapi.client import Client as OpenApiClient
from alibabacloud_tea_openapi import models as open_api_models
from alibabacloud_gateway_dingtalk.client import Client as GatewayClientClient
from alibabacloud_tea_util.client import Client as UtilClient
from alibabacloud_dingtalk.yun_shu_1_0 import models as dingtalkyun_shu__1__0_models
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

    def save_open_external_log_with_options(
        self,
        request: dingtalkyun_shu__1__0_models.SaveOpenExternalLogRequest,
        headers: dingtalkyun_shu__1__0_models.SaveOpenExternalLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse:
        """
        @summary 生态日志数据互通
        
        @param request: SaveOpenExternalLogRequest
        @param headers: SaveOpenExternalLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveOpenExternalLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.log_source):
            body['logSource'] = request.log_source
        if not UtilClient.is_unset(request.log_type):
            body['logType'] = request.log_type
        if not UtilClient.is_unset(request.open_ext):
            body['openExt'] = request.open_ext
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
            action='SaveOpenExternalLog',
            version='yunShu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yunShu/externalLogs/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse(),
            self.execute(params, req, runtime)
        )

    async def save_open_external_log_with_options_async(
        self,
        request: dingtalkyun_shu__1__0_models.SaveOpenExternalLogRequest,
        headers: dingtalkyun_shu__1__0_models.SaveOpenExternalLogHeaders,
        runtime: util_models.RuntimeOptions,
    ) -> dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse:
        """
        @summary 生态日志数据互通
        
        @param request: SaveOpenExternalLogRequest
        @param headers: SaveOpenExternalLogHeaders
        @param runtime: runtime options for this request RuntimeOptions
        @return: SaveOpenExternalLogResponse
        """
        UtilClient.validate_model(request)
        body = {}
        if not UtilClient.is_unset(request.corp_id):
            body['corpId'] = request.corp_id
        if not UtilClient.is_unset(request.log_source):
            body['logSource'] = request.log_source
        if not UtilClient.is_unset(request.log_type):
            body['logType'] = request.log_type
        if not UtilClient.is_unset(request.open_ext):
            body['openExt'] = request.open_ext
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
            action='SaveOpenExternalLog',
            version='yunShu_1.0',
            protocol='HTTP',
            pathname=f'/v1.0/yunShu/externalLogs/save',
            method='POST',
            auth_type='AK',
            style='ROA',
            req_body_type='none',
            body_type='json'
        )
        return TeaCore.from_map(
            dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse(),
            await self.execute_async(params, req, runtime)
        )

    def save_open_external_log(
        self,
        request: dingtalkyun_shu__1__0_models.SaveOpenExternalLogRequest,
    ) -> dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse:
        """
        @summary 生态日志数据互通
        
        @param request: SaveOpenExternalLogRequest
        @return: SaveOpenExternalLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyun_shu__1__0_models.SaveOpenExternalLogHeaders()
        return self.save_open_external_log_with_options(request, headers, runtime)

    async def save_open_external_log_async(
        self,
        request: dingtalkyun_shu__1__0_models.SaveOpenExternalLogRequest,
    ) -> dingtalkyun_shu__1__0_models.SaveOpenExternalLogResponse:
        """
        @summary 生态日志数据互通
        
        @param request: SaveOpenExternalLogRequest
        @return: SaveOpenExternalLogResponse
        """
        runtime = util_models.RuntimeOptions()
        headers = dingtalkyun_shu__1__0_models.SaveOpenExternalLogHeaders()
        return await self.save_open_external_log_with_options_async(request, headers, runtime)
